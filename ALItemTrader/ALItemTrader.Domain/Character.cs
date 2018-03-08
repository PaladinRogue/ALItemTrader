using System.Collections.Generic;
using ALItemTrader.Domain.Identifiers;

namespace ALItemTrader.Domain
{
    public class Character
    {
        public CharacterId Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public List<Item> Items { get; set; }
        public Player Player { get; set; }
    }
}