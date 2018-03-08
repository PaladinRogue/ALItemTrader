using System.Collections.Generic;
using ALItemTrader.Domain.Base;
using ALItemTrader.Domain.Identifiers;

namespace ALItemTrader.Domain
{
    public class Player : User
    {
        public PlayerId Id { get; set; }
        public string DCI { get; set; }
        public List<Character> Characters { get; set; }
    }
}
