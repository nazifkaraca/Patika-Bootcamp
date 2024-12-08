namespace Week12_1_EntityCoreEntry.Data.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; set; } // If navigation property exists in one agents, it should be added other one as well
    }
}
