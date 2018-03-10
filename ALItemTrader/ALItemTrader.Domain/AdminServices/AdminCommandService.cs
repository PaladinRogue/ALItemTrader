using System;
using ALItemTrader.Domain.AdminServices.Interfaces;
using ALItemTrader.Domain.AdminServices.Models;
using ALItemTrader.Domain.Exceptions;
using ALItemTrader.Domain.Logging;
using ALItemTrader.Domain.Models;
using ALItemTrader.Persistence.Interfaces;

namespace ALItemTrader.Domain.AdminServices
{
    public class AdminCommandService : Logger, IAdminCommandService
    {
        private readonly IRepository<Admin> _adminRepository;

        public AdminCommandService(IRepository<Admin> adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public bool Create(AdminDdto entity)
{
            try
            {
                _adminRepository.Add(new Admin());

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
