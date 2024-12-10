namespace Week12_6_Ecommercial.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Virtual for lazy loading
        public virtual ICollection<Product> Products { get; set; }
    }
}
