using System;
using ALItemTrader.Application.Admin.Models;
using ALItemTrader.Domain.AdminServices.Models;
using AutoMapper;

namespace ALItemTrader.Application.Admin.Mappings
{
    public class AdminApplicationMappingProfile : Profile
    {
        public AdminApplicationMappingProfile()
        {
            CreateMap<AdminProjection, AdminAdto>();
            CreateMap<AdminDdto, AdminAdto>();
            CreateMap<CreateAdminAdto, AdminDdto>()
                .ForMember(dest => dest.Id,
                    opts => opts.MapFrom(src => Guid.NewGuid()));
        }
    }
}
