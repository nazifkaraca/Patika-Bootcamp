namespace Week12_1_EntityCoreEntry.Data.Entity
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Navigation Properties
        public List<Book> Books { get; set; }
    }
}
