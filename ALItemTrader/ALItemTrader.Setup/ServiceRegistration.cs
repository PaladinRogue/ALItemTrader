using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ALItemTrader.Persistence;
using ALItemTrader.Persistence.Repositories;
using ALItemTrader.Domain.Interfaces;
using ALItemTrader.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace ALItemTrader.Setup
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IRepository<Admin>, AdminRepository>();
            services.AddScoped<IRepository<Player>, PlayerRepository>();
            services.AddScoped<IRepository<Character>, CharacterRepository>();
            services.AddScoped<IRepository<Item>, ItemRepository>();
            services.AddScoped<IRepository<IdentityUser>, IdentityUserRepository>();
                        
            services.AddDbContext<ALItemTraderDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:TestDb"]));
        }
    }
}
