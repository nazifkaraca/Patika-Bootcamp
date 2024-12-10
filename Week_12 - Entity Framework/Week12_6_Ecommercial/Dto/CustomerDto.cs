using System.Runtime.CompilerServices;
using Week12_6_Ecommercial.Models;

namespace Week12_6_Ecommercial.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime SignUpDate { get; set; }

        public List<Order> Orders { get; set; }
    }
}
