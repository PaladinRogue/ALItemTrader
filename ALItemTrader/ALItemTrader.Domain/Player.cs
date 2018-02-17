using System;
using System.Collections.Generic;

namespace ALItemTrader.Domain
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DCI { get; set; }
        public List<Character> Characters { get; set; }
    }
}
