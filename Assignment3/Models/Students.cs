using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3.Models
{
     public class Students
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<int> grades;


        public Students(int id, string name)
        {
            this.id = id;
            this.name = name;
            grades = new List<int>();
        }

        public int AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else { 
            Console.WriteLine("Invalid input , must be between 0 and 100.");
            }
            return grade;
        }
        public double CalculateAverage()
        {
            if (grades.Count == 0) 
            { 
                return 0; 
            }
            
            int sum = 0;
            for (int i = 0; i < grades.Count; i++)
            { 
                sum += grades[i];
            }
            return (double)sum / grades.Count;
        }

        public string PrintStudentReport()
        {
            
            CalculateAverage();
            return $"Student Name: {this.name}\n Student ID : {this.id}\n Student Grades : {AddGrade}" +
                   $" \n Student Total Average : {CalculateAverage} ";
        }






    }
}
