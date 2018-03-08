using ALItemTrader.Domain;
using ALItemTrader.Persistence.Repositories.Interfaces;

namespace ALItemTrader.Persistence.Repositories
{
    public class ItemRepository : IRepository<Item>
    {
        private readonly ALItemTraderDbContext _context;

        public ItemRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public void Add(Item item)
        {
            _context.Items.Add(item);
        }
    }
}