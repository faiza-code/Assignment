using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int number = 5;
            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
           
            else if (number == 0)
            {
                Console.WriteLine("Factorial of 0 is 1.");
            }
            else
            {
                long factorial = 1; 

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i; 
                }

                Console.WriteLine("Factorial of " + number + " is: " + factorial);
            }

        }
    }
}
