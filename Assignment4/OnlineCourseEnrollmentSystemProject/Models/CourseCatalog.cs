using MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Models
{
    public class CourseCatalog
    {
        public List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

   
        public List<Course> this[Level level]
        {
            get
            {
                List<Course> courses1 = new List<Course>();
                foreach (var element in courses)
                {
                    if (element.Level == level)
                    {
                        courses1.Add(element);
                    }
                }
                return courses1;
            }
        }















    }
}
