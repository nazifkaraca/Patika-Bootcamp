using System.ComponentModel.DataAnnotations.Schema;

namespace Week12_1_EntityCoreEntry.Data.Entity
{
    public class BookDetail
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }

        public int BookId { get; set; } // Foreign key
        public Book Book { get; set; }
    }
}
