using System;

namespace ALItemTrader.Domain.Identifiers
{
    [Serializable]
    public class PlayerId : TypedId
    {
        public static PlayerId Create()
        {
            return new PlayerId();
        }

    }
}
