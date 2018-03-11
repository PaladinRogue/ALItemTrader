using ALItemTrader.Application.Admin;
using ALItemTrader.Application.Admin.Interfaces;
using ALItemTrader.Domain.AdminServices;
using ALItemTrader.Domain.AdminServices.Interfaces;
using ALItemTrader.Domain.Interfaces;
using ALItemTrader.Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ALItemTrader.Persistence;
using ALItemTrader.Persistence.Interfaces;
using ALItemTrader.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;

namespace ALItemTrader.Setup
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IAdminApplicationService, AdminApplicationService>();

            services.AddScoped<IAdminCommandService, AdminCommandService>();
            services.AddScoped<IAdminQueryService, AdminQueryService>();

            services.AddScoped<IRepository<Admin>, AdminRepository>();
            services.AddScoped<IRepository<Player>, PlayerRepository>();
            services.AddScoped<IRepository<Character>, CharacterRepository>();
            services.AddScoped<IRepository<Item>, ItemRepository>();
            services.AddScoped<IRepository<IdentityUser>, IdentityUserRepository>();


            services.AddDbContext<ALItemTraderDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:TestDb"]));
        }
    }
}
