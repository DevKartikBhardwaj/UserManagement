using Microsoft.EntityFrameworkCore;
using UserManagement.DAL.Entities;

namespace UserManagement.DAL.DatabaseContext
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
            });
        }
    }
}
