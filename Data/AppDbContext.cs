using Microsoft.EntityFrameworkCore;
using StudentScoreAPI.Models;

namespace StudentScoreAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(150);
                // Assuming 'cpf' was used as ID previously, but usually IDs are long/guid/int
                // Kept CPF as a property if needed, but added a standard Id
            });
        }
    }
}
