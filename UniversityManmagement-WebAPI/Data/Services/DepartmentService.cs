using System;
using System.Collections.Generic;
using System.Linq;
using UniversityManagement.Data.Models;
using UniversityManmagement_WebAPI.Data.Models;

namespace UniversityManmagement_WebAPI.Data.Services
{
    public class DepartmentService
    {
        private UniversityManagementContext _context;

        public DepartmentService(UniversityManagementContext context)
        {
            _context = context;
        }

        public void AddDepartment(DepartmentVM department)
        {
            List<Course> course = new List<Course>();
            if (department.CoursesId.Count > 0)
            {
                foreach (var id in department.CoursesId)
                {
                    if (id != 0)
                    {
                        Course courseSelected = (from c in _context.Courses
                                                 where c.CourseID == id
                                                 select c).FirstOrDefault();
                        if (courseSelected != null)
                        {
                            course.Add(courseSelected);
                        }
                    }
                    else
                        course = new List<Course>();
                }
            }
            var _department = new Department()
            {
                StartDate = DateTime.Now,
                Budget = department.Budget,
                Name = department.Name,
                Courses = course.Count > 0 ? course : new List<Course>(),//department.CoursesId == null ? null : course,
                InstructorID = department.InstructorID,
                Administrator = department.InstructorID == 0 ? null : (from i in _context.Instructors
                                                                       where i.InstructorId == department.InstructorID
                                                                       select i).FirstOrDefault(),                
            };
            _context.Departments.Add(_department);
            _context.SaveChanges();
        }
    }
}