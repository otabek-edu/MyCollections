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
            modelBuilder.Entity<User>()
                .HasMany(u => u.Collections)
                .WithOne(c => c.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Collection>()
                .HasMany(c => c.Items)
                .WithOne(i => i.Collection)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Collection>()
                .HasMany(c => c.CustomProperties)
                .WithOne(cp => cp.Collection)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.CustomPropertyValues)
                .WithOne(cpv => cpv.Item)
                .OnDelete(DeleteBehavior.NoAction);

            new AppDbConfig(modelBuilder).Configure();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

    }
}
