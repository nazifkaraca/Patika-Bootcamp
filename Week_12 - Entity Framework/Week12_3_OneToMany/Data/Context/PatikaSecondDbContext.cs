using Microsoft.EntityFrameworkCore;
using Week12_3_OneToMany.Data.Entity;

namespace Week12_3_OneToMany.Data.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public PatikaSecondDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.UserName)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Email)
                      .IsRequired()
                      .HasMaxLength(128);

                entity.HasMany(x => x.Posts)
                      .WithOne(x => x.User)
                      .HasForeignKey(x => x.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title)
                      .IsRequired();

                entity.Property(e => e.Content)
                      .IsRequired();

                entity.Property(e => e.UserId)
                      .IsRequired();

                entity.HasOne(x => x.User)
                      .WithMany(x => x.Posts)
                      .HasForeignKey(x => x.UserId);
            });
                        
        }
    }
}
