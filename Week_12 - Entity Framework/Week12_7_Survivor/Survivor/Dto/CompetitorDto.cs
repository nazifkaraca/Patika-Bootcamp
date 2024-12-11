using Survivor.Data.Entity;

namespace Survivor.Dto
{
    public class CompetitorDto : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CategoryId { get; set; } // Foreign key
    }
}
