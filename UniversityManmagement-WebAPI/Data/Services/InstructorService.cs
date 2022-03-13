using System;
using System.Collections.Generic;
using System.Linq;
using UniversityManagement.Data.Models;

namespace UniversityManmagement_WebAPI.Data.Services
{
    public class CourseService
    {
        private UniversityManagementContext _context;

        public CourseService(UniversityManagementContext context)
        {
            _context = context;
        }
        
    }
}
