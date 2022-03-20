using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagement.Data.Models
{
    public class CourseVM
    {
        [StringLength(50, MinimumLength =1)]
        public string Title { get; set; }

        [Range(0,5)]
        public int Credits { get; set; }

        public int? DepartmentID { get; set; }

        public List<int> EnrollmentsId { get; set; }

        public List<int> Course_InstructorsId { get; set; }
    }
}
