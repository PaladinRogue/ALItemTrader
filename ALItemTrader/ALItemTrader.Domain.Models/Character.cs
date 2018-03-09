using System;
using System.Collections.Generic;

namespace ALItemTrader.Domain.Models
{
    public class Character
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public List<Item> Items { get; set; }
        public Player Player { get; set; }
    }
}