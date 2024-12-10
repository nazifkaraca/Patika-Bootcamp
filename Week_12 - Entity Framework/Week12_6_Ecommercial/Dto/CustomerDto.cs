using System.Runtime.CompilerServices;

namespace Week12_6_Ecommercial.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime SignUpDate { get; set; }
    }
}
