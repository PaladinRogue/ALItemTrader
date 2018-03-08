using ALItemTrader.Persistence.Repositories.Interfaces;
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

        public void Add(IdentityUser user)
        {
            _context.Users.Add(user);
        }
    }
}