using System;
using ALItemTrader.Domain.Models.Base;

namespace ALItemTrader.Domain.Models
{
    public class Admin : User
    {
        public Guid Id { get; set; }
    }
}
