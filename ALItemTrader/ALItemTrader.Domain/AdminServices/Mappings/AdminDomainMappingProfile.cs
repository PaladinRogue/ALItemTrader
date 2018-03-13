using ALItemTrader.Domain.AdminServices.Models;
using ALItemTrader.Domain.Models;
using AutoMapper;
using Common.Domain.Interfaces;
using Common.Domain.Models.Interfaces;

namespace ALItemTrader.Domain.AdminServices.Mappings
{
    public class AdminDomainMappingProfile : Profile
    {
        public AdminDomainMappingProfile()
        {
            CreateMap<Admin, AdminProjection>()
                .IncludeBase<IEntity, IVersionedProjection>();
            CreateMap<AdminDdto, Admin>();
        }
    }
}
