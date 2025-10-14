using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
           
            int firstnum = 0, secondNum = 1, z, i, num = 15;

            Console.Write(firstnum + " " + secondNum + " ");
            for (i = 2; i < num; ++i)
            {
                z = firstnum + secondNum;
                Console.Write(z + " ");
                firstnum = secondNum;
                secondNum = z;

            }
        }
    }
}
