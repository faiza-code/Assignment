using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class PatternStart
    {
        static void Main(string[] args)
        {
            int size = 5;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
