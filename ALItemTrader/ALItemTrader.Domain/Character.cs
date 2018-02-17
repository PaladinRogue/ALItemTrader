using System;

namespace ALItemTrader.Domain
{
    public class Character
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public Player Player { get; set; }
    }
}