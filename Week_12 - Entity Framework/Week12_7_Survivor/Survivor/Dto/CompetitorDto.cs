namespace Survivor.Dto
{
    public class CompetitorDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CategoryId { get; set; } // Foreign key
    }
}
