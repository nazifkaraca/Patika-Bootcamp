namespace Week12_6_Ecommercial.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime SignUpDate { get; set; }

        // Set virtual for lazy loading
        public virtual ICollection<Order> Orders { get; set; }
    }
}
