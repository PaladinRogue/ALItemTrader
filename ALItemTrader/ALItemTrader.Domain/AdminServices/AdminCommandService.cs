using System;
using ALItemTrader.Domain.AdminServices.Interfaces;
using ALItemTrader.Domain.AdminServices.Models;
using ALItemTrader.Domain.Exceptions;
using ALItemTrader.Domain.Logging;
using ALItemTrader.Domain.Models;
using ALItemTrader.Persistence.Interfaces;
using AutoMapper;

namespace ALItemTrader.Domain.AdminServices
{
    public class AdminCommandService : Logger, IAdminCommandService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Admin> _adminRepository;

        public AdminCommandService(IMapper mapper, IRepository<Admin> adminRepository)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public bool Create(AdminDdto entity)
{
            try
            {
                _adminRepository.Add(_mapper.Map<AdminDdto, Admin>(entity));

                return true;
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw new DomainException("Unable to create admin");
            }
        }
    }
}
