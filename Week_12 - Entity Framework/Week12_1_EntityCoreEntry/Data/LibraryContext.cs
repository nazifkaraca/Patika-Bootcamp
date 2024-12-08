using Microsoft.EntityFrameworkCore;
using System.Net;
using Week12_1_EntityCoreEntry.Data.Entity;

namespace Week12_1_EntityCoreEntry.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }

        // Fluent API configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Books table
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Books");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
                entity.Property(e => e.PublicationYear).HasColumnName("Year");

                // One to many relationship
                entity.HasMany(e => e.Reviews)
                      .WithOne(e => e.Book)
                      .HasForeignKey(e => e.BookId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Detail)
                      .WithOne(e => e.Book)
                      .HasForeignKey<BookDetail>(e => e.BookId);

                // Many to many relationship
                entity.HasMany(e => e.Authors)
                      .WithMany(e => e.Books)
                      .UsingEntity(e => e.ToTable("BookAuthors")); // Entity Framework will automatically create the intermadiate table
            });

            // Configure Reviews table
            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Reviews");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ReviewerName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Rating).HasColumnName("Stars");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                // It means that a category may include many book and connection can be done with category id
                entity.HasMany(e => e.Books)
                      .WithOne(e => e.Category)
                      .HasForeignKey(e => e.CategoryId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
