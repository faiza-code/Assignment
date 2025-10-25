using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP.Models
{
    internal class Multiply
    {
        public static int multi(int x, int y)
        {
            return x * y;
        }

        public static double multi(double x, double y)
        {
            return x * y;
        }
        public static string multi(string x, int y)
        {
            string result = " ";
            for (int i = 0; i < y ; i++)
            {
                result +=$"{x}" ;
            }
            return result;
        }
    }
}
