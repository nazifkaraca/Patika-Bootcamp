namespace Week8_2_MVCProject.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Order { get; set; }
        public string Greetings { get; set; }
    }
}
