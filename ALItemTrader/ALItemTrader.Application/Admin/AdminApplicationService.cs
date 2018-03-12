using System;
using System.Collections.Generic;
using System.Transactions;
using ALItemTrader.Application.Admin.Interfaces;
using ALItemTrader.Application.Admin.Models;
using ALItemTrader.Domain.AdminServices.Interfaces;
using ALItemTrader.Domain.AdminServices.Models;
using AutoMapper;

namespace ALItemTrader.Application.Admin
{
    public class AdminApplicationService : IAdminApplicationService
    {
        private readonly IAdminCommandService _adminCommandService;
        private readonly IAdminQueryService _adminQueryService;
        private readonly IMapper _mapper;

        public AdminApplicationService(IMapper mapper, IAdminCommandService adminCommandService, IAdminQueryService adminQueryService)
        {
            _mapper = mapper;
            _adminCommandService = adminCommandService;
            _adminQueryService = adminQueryService;
        }

        public IList<AdminAdto> GetAdmins()
        {
            return _mapper.Map<IList<AdminProjection>, IList<AdminAdto>>(_adminQueryService.GetAll());
        }

        public AdminAdto GetAdminById(Guid id)
        {
            return _mapper.Map<AdminProjection, AdminAdto> (_adminQueryService.Get(id));
        }

        public AdminAdto Create(CreateAdminAdto admin)
        {
            var newAdmin = _mapper.Map<CreateAdminAdto, AdminDdto>(admin);

            var result = _adminCommandService.Create(newAdmin);

            return _mapper.Map<AdminDdto, AdminAdto>(newAdmin);
        }
    }
}

