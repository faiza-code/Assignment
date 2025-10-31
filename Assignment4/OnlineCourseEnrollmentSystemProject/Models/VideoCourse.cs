using MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Models
{
    public class VideoCourse : Course
    {
        public string DurationHours { get; set; }
        public VideoCourse(string name, string instructor, Level level, string durationHours)
        : base(name, instructor, level)
        {
            DurationHours = durationHours;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Duration: {DurationHours} ");
        }
    }
}
