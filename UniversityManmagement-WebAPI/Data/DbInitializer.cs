using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using UniversityManagement.Data.Models;

namespace UniversityManmagement_WebAPI.Data
{
    public class DbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<UniversityManagementContext>();

            //    var students = new List<Student>
            //{
            //new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            //new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            //new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            //};

            //    students.ForEach(s => context.Students.Add(s));
            //    context.SaveChanges();
                var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,DepartmentID=1},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,DepartmentID=2},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,DepartmentID=1},
            new Course{CourseID=1045,Title="Calculus",Credits=4,DepartmentID=2},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,DepartmentID=1},
            new Course{CourseID=2021,Title="Composition",Credits=3,DepartmentID=2},
            new Course{CourseID=2042,Title="Literature",Credits=4,DepartmentID=1}
            };
                courses.ForEach(s => context.Courses.Add(s));
                context.SaveChanges();
                var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade="A"},
            new Enrollment{StudentID=1,CourseID=4022,Grade="C"},
            new Enrollment{StudentID=1,CourseID=4041,Grade="B"},
            new Enrollment{StudentID=2,CourseID=1045,Grade="A"},
            new Enrollment{StudentID=2,CourseID=3141,Grade="A"},
            new Enrollment{StudentID=2,CourseID=2021,Grade="A"},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade="A"},
            new Enrollment{StudentID=5,CourseID=4041,Grade="A"},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade="A"},
            };
                enrollments.ForEach(s => context.Enrollments.Add(s));
                context.SaveChanges();








                //if (!context.Departments.Any())
                //{
                //    context.Departments.AddRange(new Department()
                //    {
                //        Name = "Computer Science",
                //        Budget = 20000,
                //        StartDate = DateTime.Now,
                //        Courses = null,
                //    }, new Department
                //    {
                //        Name = "General Science",
                //        Budget = 20000,
                //        StartDate = DateTime.Now,
                //        Courses = null,
                //    });
                //    context.SaveChanges();
                //}
                //if(!context.Courses.Any())
                //{
                //    context.Courses.AddRange(new Course()
                //    {
                //        Credits = 4,
                //        Title = "DCS",
                //        Department = (from d in context.Departments
                //                      where d.Name == "EE"
                //                      select d).FirstOrDefault(),
                //        DepartmentID = (from d in context.Departments
                //                        where d.Name == "EE"
                //                        select d).FirstOrDefault().DepartmentId,
                //        Enrollments = null,
                //        Course_Instructors = null
                //    },new Course()
                //    {
                //        Credits = 4,
                //        Title = "SCS",
                //        Department = (from d in context.Departments
                //                      where d.Name == "General Science"
                //                      select d).FirstOrDefault(),
                //        DepartmentID = (from d in context.Departments
                //                        where d.Name == "General Science"
                //                        select d).FirstOrDefault().DepartmentId,
                //        Enrollments = null,
                //        Course_Instructors = null
                //    });
                //    context.SaveChanges();
                //}
                //if(!context.Instructors.Any())
                //{
                //    context.Instructors.AddRange(new Instructor()
                //    {
                //        LastName = "Haseeb",
                //        FirstMidName = "",
                //        HireDate = DateTime.Now,
                //        Courses = null,
                //        OfficeAssignment = null
                //    },
                //    new Instructor
                //    {
                //        LastName = "Ahmed",
                //        FirstMidName = "",
                //        HireDate = DateTime.Now,
                //        Courses = null,
                //        OfficeAssignment = null
                //    });
                //    context.SaveChanges();
                //}
            }
        }

        public DbInitializer()
        {
        }
    }
}
