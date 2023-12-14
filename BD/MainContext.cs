using Microsoft.EntityFrameworkCore;
using DB.Entities;

namespace DB
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
        }
        public DbSet<DbUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingStatic(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        internal static void OnModelCreatingStatic(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbUser>();
        }
    }
}