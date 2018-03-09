using System;
using ALItemTrader.Domain.Interfaces;
using ALItemTrader.Domain.Models;

namespace ALItemTrader.Persistence.Repositories
{
    public class PlayerRepository : IRepository<Player>
    {
        private readonly ALItemTraderDbContext _context;

        public PlayerRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public Player GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(Player player)
        {
            _context.Players.Add(player);
        }

        public void Update(Player obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}