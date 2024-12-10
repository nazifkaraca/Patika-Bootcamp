using System.ComponentModel.DataAnnotations.Schema;

namespace Week12_6_Ecommercial.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }

        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
