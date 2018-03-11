using System;
using System.Collections.Generic;
using ALItemTrader.Domain.AdminServices.Interfaces;
using ALItemTrader.Domain.AdminServices.Models;
using ALItemTrader.Domain.Models;
using ALItemTrader.Persistence.Interfaces;
using AutoMapper;

namespace ALItemTrader.Domain.AdminServices
{
    public class AdminQueryService : IAdminQueryService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Admin> _adminRepository;

        public AdminQueryService(IMapper mapper, IRepository<Admin> adminRepository)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public AdminProjection Get(Guid id)
        {
            return _mapper.Map<Admin, AdminProjection>(_adminRepository.GetById(id));
        }

        public IList<AdminProjection> GetAll()
        {
            return _mapper.Map<IList<Admin>, IList<AdminProjection>>(_adminRepository.Get());
        }
    }
}
