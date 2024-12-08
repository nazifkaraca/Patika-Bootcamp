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
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        [Column("BookPrice", TypeName = "decimal(18, 2)")] // Set custom column name and type (2 floating points)
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        [Column("LastBorrowed")] // Set custom name for a column
        public DateTime? LastBarrowedDate { get; set; }

        // Navigation Reference Property
        public List<Review> Reviews { get; set; }
    }
}
