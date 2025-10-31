using MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Enum;
using MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject
{
    public class Program
    {
        static void Main (string[] args)
        {
            CourseCatalog catalog = new CourseCatalog();

            
            catalog.AddCourse(new VideoCourse("Faiza Alhandali", "Youssif Mohammed", Level.Beginner, "6"));
            catalog.AddCourse(new LiveSession("Youssif Mohammed", "Programming C#", Level.Intermediate, new DateTime(2025, 11, 10, 18, 30, 0)));
            catalog.AddCourse(new VideoCourse("Intermediate Java", "Carol", Level.Intermediate, "5"));
         

            
            Console.WriteLine("Beginner Level Courses:");
            foreach (var course in catalog[Level.Beginner])
            {
                course.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
