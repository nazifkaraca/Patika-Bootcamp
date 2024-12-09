using System.ComponentModel.DataAnnotations;

namespace Week12_4_EduPlatform.Models
{
    public class Instructor : BaseModel<int>
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public List<Course> Courses { get; set; }

    }
}
