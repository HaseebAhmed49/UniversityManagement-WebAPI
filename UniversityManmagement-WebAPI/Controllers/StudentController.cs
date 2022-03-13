using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniversityManmagement_WebAPI.Data.Services;
using UniversityManagement.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversityManmagement_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        public StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("add-studnet")]
        public IActionResult AddStudent([FromBody]StudentVM student)
        {
            _studentService.AddStudent(student);
            return Ok();
        }

        [HttpGet("get-all-students")]
        public IActionResult GetAllStudents()
        {
            var allStudents = _studentService.GetAllStudents();
            return Ok(allStudents);
        }

        [HttpGet("get-student-by-id/{id}")]
        public IActionResult GetInstructorById(int id)
        {
            var student = _studentService.GetStudentById(id);
            return Ok(student);
        }

        [HttpPut("update-student-by-id/{id}")]
        public IActionResult UpdateStudentById(int id,[FromBody]StudentVM student)
        {
            var updatedStudent = _studentService.UpdateStudentById(id,student);
            return Ok(updatedStudent);
        }

        [HttpDelete("delete-student-by-id/{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            _studentService.DeleteStudentById(id);
            return Ok();
        }
    }
}
