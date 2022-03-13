using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniversityManagement.Data.Models;
using UniversityManmagement_WebAPI.Data.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversityManmagement_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class InstructorController : ControllerBase
    {
        public InstructorService _instructorService;

        public InstructorController(InstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpPost("add-instructor")]
        public IActionResult AddInstructor([FromBody]InstructorVM instructor)
        {
            _instructorService.AddInstructor(instructor);
            return Ok();
        }

        [HttpGet("get-all-instructors")]
        public IActionResult GetAllInstructors()
        {
            var allInstructors = _instructorService.GetAllInstructors();
            return Ok(allInstructors);
        }

        [HttpGet("get-instructor-by-id/{id}")]
        public IActionResult GetInstructorById(int id)
        {
            var instructor = _instructorService.GetInstructorById(id);
            return Ok(instructor);
        }

        [HttpPut("update-instructor-by-id/{id}")]
        public IActionResult UpdateInstructorById(int id,[FromBody]InstructorVM instructor)
        {
            var updatedinstructor = _instructorService.UpdateInstructorById(id,instructor);
            return Ok(updatedinstructor);
        }

        [HttpDelete("delete-instructor-by-id/{id}")]
        public IActionResult DeleteInstructorById(int id)
        {
            _instructorService.DeleteInstructorById(id);
            return Ok();
        }
    }
}
