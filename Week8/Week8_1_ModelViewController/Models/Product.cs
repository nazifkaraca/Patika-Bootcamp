using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı gereklidir.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(0, 1000000)]
        public decimal Price { get; set; }
    }
}
