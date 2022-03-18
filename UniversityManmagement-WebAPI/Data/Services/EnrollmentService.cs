using System;
using System.Collections.Generic;
using System.Linq;
using UniversityManagement.Data.Models;
using UniversityManmagement_WebAPI.Data.Models;

namespace UniversityManmagement_WebAPI.Data.Services
{
    public class EnrollmentService
    {
        private UniversityManagementContext _context;

        public EnrollmentService(UniversityManagementContext context)
        {
            _context = context;
        }

        public void AddEnrollment(EnrollmentVM enrollment)
        {
            var _enrollment = new Enrollment()
            {
                Course = (from c in _context.Courses
                          where c.CourseID == enrollment.CourseID
                          select c).FirstOrDefault(),
                Student = (from s in _context.Students
                           where s.StudentId == enrollment.StudentID
                           select s).FirstOrDefault(),
                Grade = "A",
                CourseID = enrollment.CourseID,
                StudentID = enrollment.StudentID                
            };

            _context.Enrollments.Add(_enrollment);
            _context.SaveChanges();
        }
    }
}