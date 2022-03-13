using System;
using UniversityManagement.Data.Models;

namespace UniversityManmagement_WebAPI.Data.Models
{
    public class Course_Instructor
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public int InstructorId { get; set; }

        public Instructor Instructor { get; set; }
    }
}
