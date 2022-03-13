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
    public class DepartmentController : ControllerBase
    {
        public DepartmentService _departmentService;

        public DepartmentController(DepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpPost("add-department")]
        public IActionResult AddDepartment([FromBody]DepartmentVM department)
        {
            _departmentService.AddDepartment(department);
            return Ok();
        }
    }
}
