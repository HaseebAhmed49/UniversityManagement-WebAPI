using Microsoft.EntityFrameworkCore;
using UniversityManagement.Data.Models;
using UniversityManmagement_WebAPI.Data.Models;

namespace UniversityManmagement_WebAPI.Data
{
    public class UniversityManagementContext : DbContext
    {

        public DbSet<Course> Courses { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course_Instructor> Course_Instructors { get; set; }

        public UniversityManagementContext(DbContextOptions<UniversityManagementContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Instructor>()
                .HasOne(c => c.Course)
                .WithMany(ci => ci.Course_Instructors)
                .HasForeignKey(cid => cid.CourseId);

            modelBuilder.Entity<Course_Instructor>()
                .HasOne(i => i.Instructor)
                .WithMany(ci => ci.Course_Instructors)
                .HasForeignKey(i => i.InstructorId);
        }
    }
}
