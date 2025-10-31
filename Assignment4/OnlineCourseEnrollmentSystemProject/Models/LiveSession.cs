using MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.OnlineCourseEnrollmentSystemProject.Models
{
     public class LiveSession : Course
    {
        
        public DateTime Schedule { get; set; }


        public LiveSession(string name, string instructor, Level level, DateTime schedule) 
        : base(name, instructor, level)
        {
            Schedule = schedule;
        }


        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Scheduled : {Schedule}");
        }

     }
}
