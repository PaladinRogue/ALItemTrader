using System;
using ALItemTrader.Domain.AdminServices.Models;
using ALItemTrader.Domain.Exceptions;
using ALItemTrader.Domain.Interfaces;
using ALItemTrader.Domain.Logging;
using ALItemTrader.Domain.Models;

namespace ALItemTrader.Domain.AdminServices
{
    public class AdminCommandService : Logger, ICommandService<AdminDdto>
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
