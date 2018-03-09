using System;
using System.Collections.Generic;
using ALItemTrader.Domain.Base;

namespace ALItemTrader.Domain
{
    public class Player : User
    {
        public Guid Id { get; set; }
        public string DCI { get; set; }
        public List<Character> Characters { get; set; }
    }
}
