using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MakeenAssignment.Assignment1
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number :");
            string num = Console.ReadLine();
            int userInteger = int.Parse(num);
            if (isPrime(userInteger))
            {
                Console.WriteLine($"The {userInteger} is Prime Number");
            }
            else
            {
                Console.WriteLine($"The {userInteger} is Not Prime Number");
            }

        }

        static bool isPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;

            return true;
        }


    }
}

