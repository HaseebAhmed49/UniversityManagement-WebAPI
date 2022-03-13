using System;
using System.Collections.Generic;
using System.Linq;
using UniversityManagement.Data.Models;
using UniversityManmagement_WebAPI.Data.Models;

namespace UniversityManmagement_WebAPI.Data.Services
{
    public class CourseService
    {
        private UniversityManagementContext _context;

        public CourseService(UniversityManagementContext context)
        {
            _context = context;
        }

        public void AddCourses(CourseVM course)
        {
            var _course = new Course()
            {
                Title = course.Title,
                Credits = course.Credits,
                DepartmentID = course.DepartmentID,
                Department = (from d in _context.Departments
                              where d.DepartmentId == course.DepartmentID
                              select d).FirstOrDefault(),                
            };

            foreach(var id in course.EnrollmentsId)
            {
                var _enrollment = (from e in _context.Enrollments
                                   where e.EnrollmentID == id
                                   select e).FirstOrDefault();
                _course.Enrollments.Add(_enrollment);
            }

            _context.Courses.Add(_course);
            _context.SaveChanges();

            //foreach (var id in course.Course_InstructorsId)
            //{
            //    var _course_instructor = new Course_Instructor()
            //    {
            //        CourseId = _course.CourseID,
            //    };

            //    _context.Course_Instructors.Add(_course_instructor);
            //    _context.SaveChanges();
            //}
        }

        public List<Course> GetAllCourses() => _context.Courses.ToList();

    }
}