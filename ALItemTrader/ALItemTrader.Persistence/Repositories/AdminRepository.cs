using System;
using System.Collections.Generic;
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
            return new List<Admin>
            {
                new Admin
                {
                    Id = Guid.Empty,
                    FirstName = "Tom",
                    LastName = "Ryder"
                },
                new Admin
                {
                    Id = Guid.Empty,
                    FirstName = "Dan",
                    LastName = "Cheney"
                }
            };
        }

        public Admin GetById(Guid id)
        {
            return new Admin
            {
                Id = Guid.Empty,
                FirstName = "Dan",
                LastName = "Cheney"
            };
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