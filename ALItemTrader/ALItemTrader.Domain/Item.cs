using ALItemTrader.Domain.Identifiers;

namespace ALItemTrader.Domain
{
    public class Item
    {
        public ItemId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Rarity { get; set; }
        public bool ForTrade { get; set; }
        public Character Character { get; set; }
    }
}
