using Microsoft.EntityFrameworkCore;
using _9_Book_MgtSystem.Models;
namespace _9_Book_MgtSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Bookk> Bookks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bookk>()
                .Property(b => b.Price)
                .HasColumnType("decimal(18,2)");
            base.OnModelCreating(modelBuilder);
        }
    }
}
