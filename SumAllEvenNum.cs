using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class SumAllEvenNum
    {
        static void Main(string[] args)
        {
            int sum;
            for(int i=0; i <= 100; i++)
            {
                sum = i;
                if (i %2 ==0)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of all even number is : {sum}");
            }
        }
    }
}
