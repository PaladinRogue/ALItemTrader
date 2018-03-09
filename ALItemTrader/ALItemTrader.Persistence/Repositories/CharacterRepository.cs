using System;
using ALItemTrader.Domain;
using ALItemTrader.Domain.Interfaces;
using ALItemTrader.Domain.Models;

namespace ALItemTrader.Persistence.Repositories
{
    public class CharacterRepository : IRepository<Character>
    {
        private readonly ALItemTraderDbContext _context;

        public CharacterRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public Character GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(Character character)
        {
            _context.Characters.Add(character);
        }

        public void Update(Character obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}