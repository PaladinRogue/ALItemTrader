using ALItemTrader.Api.Formatters;
using ALItemTrader.Setup;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ALItemTrader.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(UseCustomJsonOutputFormatter);

            ServiceRegistration.RegisterServices(Configuration, services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        public static void UseCustomJsonOutputFormatter(MvcOptions options)
        {
            // Remove any json output formatter 
            options.OutputFormatters.RemoveType<JsonOutputFormatter>();

            // Add custom json output formatter 
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            options.OutputFormatters.Add(new CustomJsonOutputFormatter(jsonSerializerSettings, System.Buffers.ArrayPool<char>.Shared));
        }
    }
}
