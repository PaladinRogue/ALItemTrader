using ALItemTrader.Domain;
using ALItemTrader.Persistence.Repositories.Interfaces;

namespace ALItemTrader.Persistence.Repositories
{
    public class AdminRepository : IRepository<Admin>
    {
        private readonly ALItemTraderDbContext _context;

        public AdminRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public void Add(Admin admin)
        {
            _context.Admins.Add(admin);
        }
    }
}