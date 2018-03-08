using System;
using ALItemTrader.Application.ApplicationServices.Users.Dto;

namespace ALItemTrader.Application.ApplicationServices.Users
{
    public class UserApplicationService
    {
        public UserAdto GetUser(Guid userId)
        {

        }

        public async UserAdto CreateUserFromFacebook(CreateUserFromFacebookAdto user)
        {

            if (user == null)
            {
                var appUser = new AppUser
                {
                    FirstName = userInfo.FirstName,
                    LastName = userInfo.LastName,
                    FacebookId = userInfo.Id,
                    Email = userInfo.Email,
                    UserName = userInfo.Email,
                    PictureUrl = userInfo.Picture.Data.Url
                };

                var result = await _userManager.CreateAsync(appUser, Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8));

                if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

                await _appDbContext.Customers.AddAsync(new Customer { IdentityId = appUser.Id, Location = "", Locale = userInfo.Locale, Gender = userInfo.Gender });
                await _appDbContext.SaveChangesAsync();
            }
        }
    }
}
}
