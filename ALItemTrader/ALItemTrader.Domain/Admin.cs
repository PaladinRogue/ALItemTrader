using ALItemTrader.Domain.Base;
using ALItemTrader.Domain.Identifiers;

namespace ALItemTrader.Domain
{
    public class Admin : User
    {
        public AdminId Id { get; set; }
    }
}
