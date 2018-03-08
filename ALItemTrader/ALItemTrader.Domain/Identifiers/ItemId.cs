using System;

namespace ALItemTrader.Domain.Identifiers
{
    [Serializable]
    public class ItemId : TypedId
    {
        public static ItemId Create()
        {
            return new ItemId();
        }

    }
}
