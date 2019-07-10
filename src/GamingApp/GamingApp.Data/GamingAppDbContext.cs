using GamingApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GamingApp.Data
{
    public class GamingAppDbContext : DbContext
    {
        public GamingAppDbContext(DbContextOptions options) 
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserType> UserTypes { get; set; }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
