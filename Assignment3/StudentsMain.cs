using MakeenAssignment.Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3
{
    public class StudentsMain
    {
        static void Main(string[] args)
        {
            Students student1 = new Students(172893, "Faiza");
            Students student2 = new Students(123947 , "Marwa");
            Students student3 = new Students(146457 , "Ahmed");

            student1.AddGrade(50);
            student2.AddGrade(90);
            student3.AddGrade(70);

            Console.WriteLine(student1.PrintStudentReport());
            Console.WriteLine(student3.PrintStudentReport());
            Console.WriteLine(student3.PrintStudentReport());


        }
    }
}
