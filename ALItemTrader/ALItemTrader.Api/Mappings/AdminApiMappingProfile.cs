using ALItemTrader.Api.Resources.Admin;
using ALItemTrader.Application.Admin.Models;
using AutoMapper;

namespace ALItemTrader.Api.Mappings
{
    public class AdminApiMappingProfile : Profile
    {
        public AdminApiMappingProfile()
        {
            CreateMap<AdminAdto, AdminResource>();
        }
    }
}
