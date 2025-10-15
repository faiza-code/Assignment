using MakeenSalalahDay.Moudel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MakeenSalalahDay

{
    internal class Program1
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee();
            // employee1.firstName = "Faiza";
            // employee1.lastName = "Alhandali";
            // employee1.age = 28;
            // employee1.salary = 3000.89;

            // Console.WriteLine($"Employee name is : {employee1.firstName} {employee1.lastName}");

            //Employee employee2 = new Employee();
            //employee2.firstName = "Asama";
            //employee2.lastName = "Alalawi";
            //employee2.age = 30;
            //employee2.salary = 5000.86;

            // Console.WriteLine($"Employee name is : {employee2.firstName} {employee2.lastName}");

            //    public override string ToString()
            //{
            //    return $"Employee name is : {employee2.firstName} {employee2.lastName}";
            //}
            Employee[] employee = new Employee[3];
            for (int i = 1; i < employee.Length; i++)
            {
                employee[i] = new Employee();
                Console.WriteLine($"Pleas Enter employee{i} First Name :");
                employee[i].firstName = Console.ReadLine();

                Console.WriteLine($"Pleas Enter employee{i} Last Name :");
                employee[i].lastName = Console.ReadLine();

                //Console.WriteLine($"Pleas Enter employee{i} Salary :");
                //employee[i].salary = double.Parse(Console.ReadLine());

                Console.WriteLine($"Pleas Enter employee{i} Wage :");
                employee[i].wage = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"Pleas Enter employee{i} Logged Hour :");
                employee[i].loggedHour = double.Parse(Console.ReadLine());

            }
                foreach (Employee e in employee)
                {
                    decimal notSalary = (e.wage * (decimal)e.loggedHour) - (e.wage*(decimal)(e.loggedHour * Employee.TAX));
                    Console.WriteLine($"Employee {e.firstName}: Not Salary is {notSalary}");







                }


            }
        }
    }

