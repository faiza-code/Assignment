using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenSalalahDay.Moudel
{
    public class Employee
    {
        public int id;
        public string firstName;
        public string lastName;
        public double loggedHour;
        public decimal wage;
        public const double TAX = 0.03;

        public int  IdNum { get; set; }
        public string name { get; set; }
        public int Lname { get; set; }

        public void Greeting()
        {
            Console.WriteLine("Hello to Code Academy");
        }

        public string Greeting1()
        {
            //return "Hello to Code Academy";
            return $"Welcome {this.firstName} to the Company\nYou ID Numbre is {this.id} ";
        }

        //public static void printLine()
        public static void printLine(int a, char c)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        //Creat Constractor :
        public Employee(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
           
        }
        public Employee(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
    
        }
    }
}
