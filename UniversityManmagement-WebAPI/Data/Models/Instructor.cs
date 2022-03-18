using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversityManmagement_WebAPI.Data.Models;

namespace UniversityManagement.Data.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First Name length should be less than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [Display(Name ="Hire Date")]
        public DateTime HireDate { get; set; }

        [Display(Name ="Full Name")]
        public string FullName
        {
            get => LastName + ", " + FirstMidName;            
        }

        public List<Course_Instructor>? Course_Instructors { get; set; }

        public OfficeAssignment? OfficeAssignment { get; set; }
    }
}
