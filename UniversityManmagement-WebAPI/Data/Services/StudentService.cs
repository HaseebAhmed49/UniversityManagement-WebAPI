using System;
using System.Collections.Generic;
using System.Linq;
using UniversityManagement.Data.Models;

namespace UniversityManmagement_WebAPI.Data.Services
{
    public class StudentService
    {
        private UniversityManagementContext _context;

        public StudentService(UniversityManagementContext context)
        {
            _context = context;
        }

        public void AddStudent(StudentVM student)
        {
            List<Enrollment> enrollments = new List<Enrollment>();
            foreach (var id in student.EnrollmentsId)
            {
                var enrollment = (from s in _context.Enrollments
                              where id == s.EnrollmentID
                              select s).FirstOrDefault();
                enrollments.Add(enrollment);
            }
            var _student = new Student()
            {                
                LastName = student.LastName,
                FirstMidName = student.FirstMidName,
                EnrollmentDate = DateTime.Now,
                Enrollments = enrollments
            };
            _context.Students.Add(_student);
            _context.SaveChanges();
        }

        public List<Student> GetAllStudents() => _context.Students.ToList();

        public Student GetStudentById(int studentId) => _context.Students.FirstOrDefault(n => n.StudentId == studentId);

        public Student UpdateStudentById(int studentId, StudentVM student)
        {
            var _student = _context.Students.FirstOrDefault(i => i.StudentId == studentId);
            if(_student!=null)
            {
                _student.FirstMidName = student.FirstMidName;
                _student.LastName = student.LastName;
                _student.EnrollmentDate = student.EnrollmentDate;
                _context.SaveChanges();
            }
            return _student;
        }

        public void DeleteStudentById(int studentId)
        {
            var _student = _context.Students.FirstOrDefault(i => i.StudentId == studentId);
            if (_student != null)
            {
                _context.Students.Remove(_student);
                _context.SaveChanges();
            }
        }
    }
}
