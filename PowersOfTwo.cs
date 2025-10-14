using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class PowersOfTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 powers of 2 are:");

            // Using a loop and Math.Pow()
            for (int i = 0; i < 10; i++)
            {
                double power = Math.Pow(2, i);
                Console.WriteLine($"2^{i} = {power}");
            }

        }
    }
}

