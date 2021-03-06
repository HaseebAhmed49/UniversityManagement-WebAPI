using System;
using System.Collections.Generic;
using System.Linq;
using UniversityManagement.Data.Models;
using UniversityManmagement_WebAPI.Data.Models;

namespace UniversityManmagement_WebAPI.Data.Services
{
    public class InstructorService
    {
        private UniversityManagementContext _context;

        public InstructorService(UniversityManagementContext context)
        {
            _context = context;
        }

        public void AddInstructor(InstructorVM instructor)
        {
            var _instructor = new Instructor()
            {
                LastName = instructor.LastName,
                FirstMidName = instructor.FirstMidName,
                HireDate = DateTime.Now,
            };
            _context.Instructors.Add(_instructor);
            _context.SaveChanges();

            foreach (var id in instructor.Course_InstructorsId)
            {
                var _course_instructor = new Course_Instructor()
                {
                    CourseId = id,
                    InstructorId = _instructor.InstructorId
                };

                _context.Course_Instructors.Add(_course_instructor);
                _context.SaveChanges();
            }
        }

        public List<Instructor> GetAllInstructors() => _context.Instructors.ToList();

        public Instructor GetInstructorById(int instructorId) => _context.Instructors.FirstOrDefault(n => n.InstructorId == instructorId);

        public Instructor UpdateInstructorById(int instructorId,InstructorVM instructor)
        {
            var _instructor = _context.Instructors.FirstOrDefault(i => i.InstructorId == instructorId);
            if(_instructor!=null)
            {
                _instructor.FirstMidName = instructor.FirstMidName;
                _instructor.LastName = instructor.LastName;
                _context.SaveChanges();
            }
            return _instructor;
        }

        public void DeleteInstructorById(int instructorId)
        {
            var _instructor = _context.Instructors.FirstOrDefault(i => i.InstructorId == instructorId);
            if (_instructor != null)
            {
                _context.Instructors.Remove(_instructor);
                _context.SaveChanges();
            }
        }
    }
}
