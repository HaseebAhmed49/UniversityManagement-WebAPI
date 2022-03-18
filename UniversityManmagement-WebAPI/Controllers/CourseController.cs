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
    public class CourseController : ControllerBase
    {
        public CourseService _courseService;

        public CourseController(CourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost("add-course")]
        public IActionResult AddCourse([FromBody]CourseVM course)
        {
            _courseService.AddCourses(course);
            return Ok();
        }

        [HttpGet("get-all-course")]
        public IActionResult GetAllCourse()
        {
            var courses = _courseService.GetAllCourses();
            return Ok(courses);
        }

    }
}
