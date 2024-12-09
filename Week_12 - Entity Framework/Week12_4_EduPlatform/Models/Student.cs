using System.ComponentModel.DataAnnotations;

namespace Week12_4_EduPlatform.Models
{
    public class Student : BaseModel<int>
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
