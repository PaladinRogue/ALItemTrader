using System.Collections.Generic;
using ALItemTrader.Domain.Models.Base;

namespace ALItemTrader.Domain.Models
{
    public class Player : User
    {
        public string DCI { get; set; }
        public List<Character> Characters { get; set; }
    }
}
