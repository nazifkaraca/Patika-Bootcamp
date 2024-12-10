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

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public int StockQuantity { get; set; }
    }
}
