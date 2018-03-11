using ALItemTrader.Domain.AdminServices.Models;
using ALItemTrader.Domain.Models;
using AutoMapper;

namespace ALItemTrader.Domain.AdminServices.Mappings
{
    public class AdminDomainMappingProfile : Profile
    {
        public AdminDomainMappingProfile()
        {
            CreateMap<Admin, AdminProjection>();
            CreateMap<AdminDdto, Admin>();
        }
    }
}
