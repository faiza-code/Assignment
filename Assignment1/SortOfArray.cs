using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment1
{
    internal class SortOfArray
    {
        static void main(string[] args)
        {
 
            int[] numbers = { 5, 2, 8, 1, 9, 4, 7, 3, 6 };

            Console.WriteLine("Original array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            
            Array.Sort(numbers);

            Console.WriteLine("Sorted array (ascending):");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
