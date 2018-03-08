using ALItemTrader.Domain;
using ALItemTrader.Persistence.Repositories.Interfaces;

namespace ALItemTrader.Persistence.Repositories
{
    public class PlayerRepository : IRepository<Player>
    {
        private readonly ALItemTraderDbContext _context;

        public PlayerRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public void Add(Player player)
        {
            _context.Players.Add(player);
        }
    }
}