using System;
using ALItemTrader.Domain;
using ALItemTrader.Domain.Interfaces;
using ALItemTrader.Domain.Models;

namespace ALItemTrader.Persistence.Repositories
{
    public class ItemRepository : IRepository<Item>
    {
        private readonly ALItemTraderDbContext _context;

        public ItemRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public Item GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(Item item)
        {
            _context.Items.Add(item);
        }

        public void Update(Item obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}