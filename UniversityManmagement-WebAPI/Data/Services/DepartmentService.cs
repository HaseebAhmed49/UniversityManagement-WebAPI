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
            var _department = new Department()
            {
                StartDate = DateTime.Now,
                Budget = department.Budget,
                Name = department.Name,
            };

            foreach(var id in department.CoursesId)
            {
                var _course = (from c in _context.Courses
                                   where c.CourseID == id
                                   select c).FirstOrDefault();
                _department.Courses.Add(_course);
            }
            _context.Departments.Add(_department);
            _context.SaveChanges();
        }
    }
}