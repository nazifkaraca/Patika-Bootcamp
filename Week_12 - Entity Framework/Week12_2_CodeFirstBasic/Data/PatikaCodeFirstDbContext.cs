using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Week12_2_CodeFirstBasic.Data.Entity;

namespace Week12_2_CodeFirstBasic.Data
{
    public class PatikaCodeFirstDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public PatikaCodeFirstDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("Games");
                entity.HasKey(e => e.Id);

                entity.HasIndex(e => e.Name);

                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.Platform)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Rating)
                      .IsRequired()
                      .HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movies");
                entity.HasKey(e => e.Id);

                entity.HasIndex(e => e.Title);

                entity.Property(e => e.Title)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.Genre)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.ReleaseYear)
                      .IsRequired();
            });
        }
    }
}
