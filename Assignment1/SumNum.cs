using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment1
{
    internal class SumNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Second Number :");
            string num1 = Console.ReadLine();
            int userInteger = int.Parse(num1);

            Console.WriteLine("Enter the First Number :");
            string num2 = Console.ReadLine();
            int userInteger2 = int.Parse(num2);

            int sum = userInteger + userInteger2;
            Console.WriteLine($"{userInteger}" + " " + " +" + $"{userInteger2}" + " " + "=" +$"{sum}");

        }
    }
}
