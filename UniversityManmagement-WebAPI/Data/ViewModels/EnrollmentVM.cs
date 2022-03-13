using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Data.Models
{
    public enum GradeVM
    {
        A,B,C,D,F
    }

    public class EnrollmentVM
    {
        public int CourseID { get; set; }

        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText ="No grade")]
        public GradeVM? Grade { get; set; }

        public virtual Course Course { get; set; }
        public Student Student { get; set; }

        public EnrollmentVM()
        {
        }
    }
}
