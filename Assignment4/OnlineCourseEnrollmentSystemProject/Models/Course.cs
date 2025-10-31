using MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Models
{
     public class Course
     {
        public string Name { get; set; }
        public string Instructor { get; set; }
        public Level Level{ get; set; }

        public Course(string name, string instructor, Level level)
        {
            Name = name;
            Instructor = instructor;
            Level = level;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Course: {Name}, Instructor: {Instructor}, Level: {Level}");
        }

     }
}
