﻿using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Data.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        [DisplayFormat(NullDisplayText ="No grade")]
        public Grade? Grade { get; set; }

        public int CourseID { get; set; }

        public Course Course { get; set; }

        public int StudentID { get; set; }

        public Student Student { get; set; }

        public Enrollment()
        {
        }
    }
}
