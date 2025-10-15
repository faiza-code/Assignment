using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment1
{
    internal class ReverseString
    {
        static void Main (string[] args)
        {
            //    string s = "Faiza";
            //    string r = "";
            //    char ch;

            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        ch = s.[i];
            //        r = ch + r;
            //    }

            //    Console.WriteLine(r);

            string word = "Faiza";
            char[] charArray = word.ToCharArray();

            Array.Reverse(charArray);
            string reversed = new string(charArray);

            Console.WriteLine(reversed);
        }
    }
}
