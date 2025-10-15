using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment1
{
    internal class largestNumber
    {
        static void Main(string[] args)
        {
            int[] largNum = { 9, 4, 8, 7, 10, 35, 5 };
            int max = largNum[0];

            for (int i = 1; i < largNum.Length; i++)
            {
                if (largNum[i] > max)
                {
                    max = largNum[i]; 
                }
            }
            Console.WriteLine(max);
            }
        }
    }


