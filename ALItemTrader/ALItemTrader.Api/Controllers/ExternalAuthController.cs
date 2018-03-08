using System;
using System.Net.Http;
using System.Threading.Tasks;
using AngularASPNETCore2WebApiAuth.Auth;
using AngularASPNETCore2WebApiAuth.Data;
using AngularASPNETCore2WebApiAuth.Helpers;
using AngularASPNETCore2WebApiAuth.Models;
using AngularASPNETCore2WebApiAuth.ViewModels;
using Common.Api.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
 

namespace AngularASPNETCore2WebApiAuth.Controllers
{
  [Route("api/[controller]/[action]")]
  public class ExternalAuthController : Controller
  {
    private readonly ApplicationDbContext _appDbContext;
    private readonly FacebookAuthSettings _fbAuthSettings;
    private readonly IJwtFactory _jwtFactory;
    private readonly JwtIssuerOptions _jwtOptions;
    private static readonly HttpClient Client = new HttpClient();

    public ExternalAuthController(IOptions<FacebookAuthSettings> fbAuthSettingsAccessor, ApplicationDbContext appDbContext, IJwtFactory jwtFactory, IOptions<JwtIssuerOptions> jwtOptions)
    {
      _fbAuthSettings = fbAuthSettingsAccessor.Value;
      _appDbContext = appDbContext;
      _jwtFactory = jwtFactory;
      _jwtOptions = jwtOptions.Value;
    }

    // POST api/externalauth/facebook
    [HttpPost]
    public async Task<IActionResult> Facebook([FromBody]FacebookAuthViewModel model)
    {
      // 1.generate an app access token
      var appAccessTokenResponse = await Client.GetStringAsync($"https://graph.facebook.com/oauth/access_token?client_id={_fbAuthSettings.AppId}&client_secret={_fbAuthSettings.AppSecret}&grant_type=client_credentials");
      var appAccessToken = JsonConvert.DeserializeObject<FacebookAppAccessToken>(appAccessTokenResponse);
      // 2. validate the user access token
      var userAccessTokenValidationResponse = await Client.GetStringAsync($"https://graph.facebook.com/debug_token?input_token={model.AccessToken}&access_token={appAccessToken.AccessToken}");
      var userAccessTokenValidation = JsonConvert.DeserializeObject<FacebookUserAccessTokenValidation>(userAccessTokenValidationResponse);

      if (!userAccessTokenValidation.Data.IsValid)
      {
        return BadRequest(Errors.AddErrorToModelState("login_failure", "Invalid facebook token.", ModelState));
      }

      // 3. we've got a valid token so we can request user data from fb
      var userInfoResponse = await Client.GetStringAsync($"https://graph.facebook.com/v2.8/me?fields=id,email,first_name,last_name,name,gender,locale,birthday,picture&access_token={model.AccessToken}");
      var userInfo = JsonConvert.DeserializeObject<FacebookUserData>(userInfoResponse);

      // 4. ready to create the local user account (if necessary) and jwt
        var user = await _userManager.FindByEmailAsync(userInfo.Email);


        // generate the jwt for the local user...
        var localUser = await _userManager.FindByNameAsync(userInfo.Email);

      if (localUser==null)
      {
        return BadRequest(Errors.AddErrorToModelState("login_failure", "Failed to create local user account.", ModelState));
      }

      var jwt = await Tokens.GenerateJwt(_jwtFactory.GenerateClaimsIdentity(localUser.UserName, localUser.Id),
        _jwtFactory, localUser.UserName, _jwtOptions, new JsonSerializerSettings {Formatting = Formatting.Indented});
  
      return new OkObjectResult(jwt);
    }
  }
}
