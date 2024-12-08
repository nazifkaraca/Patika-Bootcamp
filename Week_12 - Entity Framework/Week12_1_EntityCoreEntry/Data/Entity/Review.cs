using System.ComponentModel.DataAnnotations.Schema;

namespace Week12_1_EntityCoreEntry.Data.Entity
{
    public class Review
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string ReviewerName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        [ForeignKey(nameof(BookId))] // Indicating book id as a foreign key
        public Book Book { get; set; }
    }
}
