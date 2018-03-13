using System;
using System.Collections.Generic;
using System.Linq;
using ALItemTrader.Domain.Models;
using ALItemTrader.Persistence.Interfaces;

namespace ALItemTrader.Persistence.Repositories
{
    public class AdminRepository : IRepository<Admin>
    {
        private readonly ALItemTraderDbContext _context;

        public AdminRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public IList<Admin> Get()
        {
            return _context.Admins.ToList();
        }

        public Admin GetById(Guid id)
        {
            return _context.Admins.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Admin admin)
        {
            _context.Admins.Add(admin);

            _context.SaveChanges();
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