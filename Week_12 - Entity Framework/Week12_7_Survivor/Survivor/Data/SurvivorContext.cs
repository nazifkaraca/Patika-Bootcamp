using Microsoft.EntityFrameworkCore;
using Survivor.Data.Entity;

namespace Survivor.Data
{
    public class SurvivorContext : DbContext
    {
        public SurvivorContext(DbContextOptions<SurvivorContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Competitor> Competitors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Ünlüler", CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default},
                new Category { Id = 2, Name = "Gönüllüler", CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default }
            );

            modelBuilder.Entity<Competitor>().HasData(
                new Competitor { Id = 1, CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default, FirstName = "Acun", LastName = "Ilıcalı", CategoryId = 1 },
                new Competitor { Id = 2, CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default, FirstName = "Aleyna", LastName = "Avcı", CategoryId = 1 },
                new Competitor { Id = 3, CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default, FirstName = "Hadise", LastName = "Açıkgöz", CategoryId = 1 },
                new Competitor { Id = 5, CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default, FirstName = "Özge", LastName = "Açık", CategoryId = 1 },
                new Competitor { Id = 4, CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default, FirstName = "Sertan", LastName = "Bozkuş", CategoryId = 1 },
                new Competitor { Id = 6, CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default, FirstName = "Kıvanç", LastName = "Tatlıtuğ", CategoryId = 2 },
                new Competitor { Id = 7, CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default, FirstName = "Ahmet", LastName = "Yılmaz", CategoryId = 2 },
                new Competitor { Id = 8, CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default, FirstName = "Elif", LastName = "Demirtaş", CategoryId = 2 },
                new Competitor { Id = 9, CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default, FirstName = "Cem", LastName = "Öztürk", CategoryId = 2 },
                new Competitor { Id = 10, CreatedDate = new DateTime(2024, 12, 10, 19, 0, 0), ModifiedDate = null, IsDeleted = default, FirstName = "Ayşe", LastName = "Karaca", CategoryId = 2 }
            );
        }
    }
}
