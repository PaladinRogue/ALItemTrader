using ALItemTrader.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ALItemTrader.Persistence
{
    public class ALItemTraderDbContext : IdentityDbContext
    {
        public ALItemTraderDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Item> Items { get; set; }
    }
}
