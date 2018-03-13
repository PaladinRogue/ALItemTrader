using System;
using Common.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace ALItemTrader.Domain.Models.Base
{
    public abstract class User : Entity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IdentityUser Identity { get; set; }
    }
}
