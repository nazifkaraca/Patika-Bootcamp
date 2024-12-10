using System.ComponentModel.DataAnnotations;

namespace Week12_6_Ecommercial.Dto
{
    public class ProductUpdateDto
    {
        [Range(0, 100)]
        public decimal PriceIncreasePercentage { get; set; }

        [Range(0, int.MaxValue)]
        public int StockIncrease { get; set; }
    }
}
