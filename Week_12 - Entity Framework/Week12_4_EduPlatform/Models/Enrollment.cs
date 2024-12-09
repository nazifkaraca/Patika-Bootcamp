using System.ComponentModel.DataAnnotations.Schema;

namespace Week12_4_EduPlatform.Models
{
    public class Enrollment : BaseModel<int>
    {
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }

        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}
