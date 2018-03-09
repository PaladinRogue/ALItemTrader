using System;
using ALItemTrader.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ALItemTrader.Persistence.Repositories
{
    public class IdentityUserRepository : IRepository<IdentityUser>
    {
        private readonly ALItemTraderDbContext _context;

        public IdentityUserRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public IdentityUser GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(IdentityUser user)
        {
            _context.Users.Add(user);
        }

        public void Update(IdentityUser obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}