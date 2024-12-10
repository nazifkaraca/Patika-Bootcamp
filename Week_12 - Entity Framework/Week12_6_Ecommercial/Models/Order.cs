using System.ComponentModel.DataAnnotations.Schema;

namespace Week12_6_Ecommercial.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
