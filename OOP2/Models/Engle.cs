using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP2.Models
{
    public class Engle : Animal
    {

        public string Fly { get; set; }
        public string TypeofEngle { get; set; }

        public Engle() { }
        public void fly()
        {
            Console.WriteLine("I'm flaying");
        }
    }
}
