using System;
using ALItemTrader.Domain.Base;

namespace ALItemTrader.Domain
{
    public class Admin : User
    {
        public Guid Id { get; set; }
    }
}
