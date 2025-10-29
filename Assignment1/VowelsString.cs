using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment1
{
    public class VowelsString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);

            Console.WriteLine($"Number of vowels: {vowelCount}");
        }

        static int CountVowels(string value)
        {
            int count = 0;
            string vowels = "halalaS neekaM";

            foreach (char c in value)
            {
                if (vowels.IndexOf(c) >= 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

