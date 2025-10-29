using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment2
{
    public class StudentGradeManagementSystem
    {
         static string[] students = new string[100];
         static int[] grades = new int[100];
         static  int count = 0; 
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Update Grade");
                Console.WriteLine("3.View All Students and Grades");
                Console.WriteLine("4.Show Average, Highest, and Lowest Grades");
                Console.WriteLine("5.Exit");
                Console.Write("Choose an option: ");
                int userVlue = int.Parse(Console.ReadLine());

                switch (userVlue)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        UpdateGrade();
                        break;
                    case 3:
                        ViewStudents();
                        break;
                    case 4:
                        ShowStatistics();
                        break;
                    case 5:
                        return; 
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void AddStudent()
        {
            if (count >= students.Length)
            {
                Console.WriteLine("Student list full.");
                return;
            }

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            int grade = GetValidGrade();

            students[count] = name;
            grades[count] = grade;
            count++;

            Console.WriteLine("Student added.");
        }

        static void UpdateGrade()
        {
            Console.Write("Enter student name to update grade: ");
            string name = Console.ReadLine();

            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (students[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            int newGrade = GetValidGrade();
            grades[index] = newGrade;
            Console.WriteLine("Grade updated.");
        }

        static void ViewStudents()
        {
            if (count == 0)
            {
                Console.WriteLine("No students added.");
                return;
            }

            Console.WriteLine("Students and Grades:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{students[i]} - {grades[i]}");
            }
        }

        static void ShowStatistics()
        {
            if (count == 0)
            {
                Console.WriteLine("No students to show statistics.");
                return;
            }

            int sum = 0;
            int highest = grades[0];
            int lowest = grades[0];

            for (int i = 0; i < count; i++)
            {
                sum += grades[i];
                if (grades[i] > highest) highest = grades[i];
                if (grades[i] < lowest) lowest = grades[i];
            }

            double average = (double)sum / count;

            Console.WriteLine($"Average grade: {average:F2}");
            Console.WriteLine($"Highest grade: {highest}");
            Console.WriteLine($"Lowest grade: {lowest}");
        }

        static int GetValidGrade()
        {
            int grade;
            while (true)
            {
                Console.Write("Enter grade (0 - 100): ");
                if (int.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
                }
            }
            return grade;
        }
    }
    }
