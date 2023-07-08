using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;

namespace MyItems.Backend
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Item> Items { get; set; }

        // onmodel creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AppDbConfig(modelBuilder).Configure();
        }
    }
}
