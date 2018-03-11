using ALItemTrader.Application.Admin.Mappings;
using ALItemTrader.Domain.AdminServices.Mappings;
using AutoMapper;

namespace ALItemTrader.Setup
{
    public class MappingRegistration
    {

        public static void RegisterMappers(IMapperConfigurationExpression configuration)
        {
            RegisterApplicationMappers(configuration);
            RegisterDomainMappers(configuration);
        }

        public static void RegisterApplicationMappers(IMapperConfigurationExpression configuration)
        {
            configuration.AddProfile<AdminApplicationMappingProfile>();
        }

        public static void RegisterDomainMappers(IMapperConfigurationExpression configuration)
        {
            configuration.AddProfile<AdminDomainMappingProfile>();
        }
    }
}
