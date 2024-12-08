using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Week12_1_EntityCoreEntry.Data.Entity
{
    [Table("Books")] // Determining table name
    [Index(nameof(Author))] // Boosts search and filter by the author column
    public class Book
    {
        [Key] // Indication key value
        public int Id { get; set; }

        [Required] // Indicating this property required
        [StringLength(100)] // Maximum character limit
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        [Column("BookPrice", TypeName = "decimal(18, 2)")] // Set custom column name and type (2 floating points)
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        [Column("LastBorrowed")] // Set custom name for a column
        public DateTime? LastBarrowedDate { get; set; }

        // Navigation Reference Properties
        public List<Review> Reviews { get; set; }
        public BookDetail Detail { get; set; }
        public int CategoryId { get; set; } // Foreign key for category
        public Category Category { get; set; }
        public List<Author> Authors { get; set; }
    }
}
