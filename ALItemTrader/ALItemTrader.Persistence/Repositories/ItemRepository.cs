using System;
using System.Collections.Generic;
using ALItemTrader.Domain.Models;
using ALItemTrader.Persistence.Interfaces;

namespace ALItemTrader.Persistence.Repositories
{
    public class ItemRepository : IRepository<Item>
    {
        private readonly ALItemTraderDbContext _context;

        public ItemRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public IList<Item> Get()
        {
            throw new NotImplementedException();
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