using System;
using System.Collections.Generic;
using ALItemTrader.Domain.Models;
using ALItemTrader.Persistence.Interfaces;

namespace ALItemTrader.Persistence.Repositories
{
    public class CharacterRepository : IRepository<Character>
    {
        private readonly ALItemTraderDbContext _context;

        public CharacterRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public IList<Character> Get()
        {
            throw new NotImplementedException();
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