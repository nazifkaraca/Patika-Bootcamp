using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week12_6_Ecommercial.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        // Set virtual for lazy loading
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }

        public int StockQuantity { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
