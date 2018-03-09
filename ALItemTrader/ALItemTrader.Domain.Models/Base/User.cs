using Microsoft.AspNetCore.Identity;

namespace ALItemTrader.Domain.Models.Base
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IdentityUser Identity { get; set; }
    }
}
