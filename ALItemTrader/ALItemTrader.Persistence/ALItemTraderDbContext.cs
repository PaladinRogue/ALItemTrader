using ALItemTrader.Domain;
using Microsoft.EntityFrameworkCore;

namespace ALItemTrader.Persistence
{
    public class ALItemTraderDbContext : DbContext
    {
        public ALItemTraderDbContext(DbContextOptions<ALItemTraderDbContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Item> Items { get; set; }
    }
}
