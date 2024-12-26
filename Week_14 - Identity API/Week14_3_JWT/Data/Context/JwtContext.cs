using Microsoft.EntityFrameworkCore;
using Week14_3_JWT.Data.Entity;

namespace Week14_3_JWT.Data.Context
{
    public class JwtContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public JwtContext(DbContextOptions<JwtContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }

    }
}
