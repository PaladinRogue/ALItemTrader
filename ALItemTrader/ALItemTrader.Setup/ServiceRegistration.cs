using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ALItemTrader.Persistence;
using ALItemTrader.Persistence.Repositories;
using ALItemTrader.Persistence.Repositories.Interfaces;

namespace ALItemTrader.Setup
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<ICharacterRepository, CharacterRepository>();
                        
            services.AddDbContext<ALItemTraderDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:TestDb"]));
        }
    }
}
