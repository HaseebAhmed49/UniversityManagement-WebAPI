using System;
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
                //var context = serviceScope.ServiceProvider.GetService<UniversityManagementContext>();
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
