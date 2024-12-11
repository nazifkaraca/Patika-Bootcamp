using Survivor.Data.Entity;

namespace Survivor.Dto
{
    public class CategoryDto : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
