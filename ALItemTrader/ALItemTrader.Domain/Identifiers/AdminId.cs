using System;

namespace ALItemTrader.Domain.Identifiers
{
    [Serializable]
    public class AdminId : TypedId
    {
        public static AdminId Create()
        {
            return new AdminId();
        }

    }
}
