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
    public class EnrollmentController : ControllerBase
    {
        public EnrollmentService _enrollmentService;

        public EnrollmentController(EnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpPost("add-enrollment")]
        public IActionResult AddEnrollment([FromBody]EnrollmentVM enrollment)
        {
            _enrollmentService.AddEnrollment(enrollment);
            return Ok();
        }
    }
}
