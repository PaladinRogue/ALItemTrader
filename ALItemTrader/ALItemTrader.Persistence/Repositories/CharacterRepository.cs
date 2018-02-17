using ALItemTrader.Domain;
using ALItemTrader.Persistence.Repositories.Interfaces;

namespace ALItemTrader.Persistence.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ALItemTraderDbContext _context;

        public CharacterRepository(ALItemTraderDbContext context)
        {
            _context = context;
        }

        public void Add(Character character)
        {
            _context.Characters.Add(character);
        }
    }
}