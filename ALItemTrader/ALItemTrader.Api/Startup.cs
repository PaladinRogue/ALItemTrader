using ALItemTrader.Api.Formatters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ALItemTrader.Persistence;
using ALItemTrader.Persistence.Repositories;
using ALItemTrader.Persistence.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json;

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
            services.AddMvc(options =>
            {
                // Remove any json output formatter 
                options.OutputFormatters.RemoveType<JsonOutputFormatter>();

                // Add custom json output formatter 
                options.OutputFormatters.Add(new CustomJsonOutputFormatter(new JsonSerializerSettings(), System.Buffers.ArrayPool<char>.Shared));
            });

            services.AddScoped<ICharacterRepository, CharacterRepository>();
            
            services.AddDbContext<ALItemTraderDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:TestDb"]));
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
    }
}
