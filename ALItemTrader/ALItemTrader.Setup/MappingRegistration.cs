using ALItemTrader.Application.Admin.Mappings;
using ALItemTrader.Domain.AdminServices.Mappings;
using AutoMapper;
using Common.Domain.Mappings;

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
            configuration.AddProfile<DomainMappingProfile>();

            configuration.AddProfile<AdminDomainMappingProfile>();
        }
    }
}
