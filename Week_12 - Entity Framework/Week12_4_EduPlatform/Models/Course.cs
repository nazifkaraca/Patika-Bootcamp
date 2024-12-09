using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week12_4_EduPlatform.Models
{
    public class Course : BaseModel<int>
    {
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int InstructorId { get; set; }

        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
