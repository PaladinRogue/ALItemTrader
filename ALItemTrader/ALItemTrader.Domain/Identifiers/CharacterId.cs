using System;

namespace ALItemTrader.Domain.Identifiers
{
    [Serializable]
    public class CharacterId : TypedId
    {
        public static CharacterId Create()
        {
            return new CharacterId();
        }

    }
}
