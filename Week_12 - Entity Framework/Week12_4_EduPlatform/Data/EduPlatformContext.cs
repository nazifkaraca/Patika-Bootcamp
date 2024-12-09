using Microsoft.EntityFrameworkCore;
using Week12_4_EduPlatform.Models;

namespace Week12_4_EduPlatform.Data
{
    public class EduPlatformContext : DbContext
    {
        public EduPlatformContext(DbContextOptions<EduPlatformContext> options) : base(options) { }
        
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                        .HasOne(c => c.Instructor)
                        .WithMany(i => i.Courses)
                        .HasForeignKey(c => c.InstructorId);

            modelBuilder.Entity<Enrollment>()
                        .HasOne(c => c.Student)
                        .WithMany(s => s.Enrollments)
                        .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                        .HasOne(e => e.Course)
                        .WithMany(c => c.Enrollments)
                        .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Course>()
                        .Property(c => c.Price)
                        .HasPrecision(18, 2);
        }
    }
}
