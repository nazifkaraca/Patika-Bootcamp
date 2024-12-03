using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Week11_3_GalacticTourAgency.Attributes;

namespace Week11_3_GalacticTourAgency.Models
{
    public class GalacticProduct
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı gereklidir.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Ürün adı 3 ile 100 karakter arasında olmalıdır.")]
        public string Name { get; set; }

        [Range(0.01, 1000, ErrorMessage = "Fiyat 0.01 ile 1000 arasında olmalıdır.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Gezegen adı boş geçilemez.")]
        [RegularExpression("^(Merkür|Venüs|Mars)$", ErrorMessage = "Geçerli bir gezegene air bir ürün değil.")]
        public string Planet { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Üretim Tarihi")]
        public DateTime ManifacturingDate { get; set; }

        [Range(1, 10)]
        [Display(Name = "Rating")]
        public int GalacticRating { get; set; }

        // Custom Attribute
        [GalacticElementComposition(minElements: 2, maxElements: 5)]
        public string Composition { get; set; }
    }
}
