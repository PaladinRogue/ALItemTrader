using System;
using ALItemTrader.Domain.Interfaces;
using ALItemTrader.Domain.Models;

namespace ALItemTrader.Persistence.Repositories
{
    public class AdminRepository : IRepository<Admin>
    {
        private readonly ALItemTraderDbContext _context;

        public AdminRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public Admin GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(Admin admin)
        {
            _context.Admins.Add(admin);
        }

        public void Update(Admin obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}