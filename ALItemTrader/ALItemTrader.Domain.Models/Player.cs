using System;
using System.Collections.Generic;
using ALItemTrader.Domain.Models.Base;

namespace ALItemTrader.Domain.Models
{
    public class Player : User
    {
        public Guid Id { get; set; }
        public string DCI { get; set; }
        public List<Character> Characters { get; set; }
    }
}
