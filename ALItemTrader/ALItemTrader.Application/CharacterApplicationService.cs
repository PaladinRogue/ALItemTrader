using System;
using ALItemTrader.Domain.Interfaces;
using ALItemTrader.Domain.Models;
using ALItemTrader.Persistence.Interfaces;

namespace ALItemTrader.Application
{
    public class CharacterApplicationService
    {
        private readonly IRepository<Character> _characterRepository;

        public CharacterApplicationService(IRepository<Character> characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public CharacterAdto GetCharacterById(Guid id)
        {
            throw new NotImplementedException();
        }
    }

    public class CharacterAdto
    {
    }
}

