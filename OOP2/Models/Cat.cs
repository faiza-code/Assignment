using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP2.Models
{
    public sealed class Cat : Animal
    {

        public string Claws { get; set; } // المخالب 
        public string Bodystructure { get; set; } // هيكل الجسم  
        public string TypeofCat { get; set; }


        public void typeCalws()
        {

            Console.WriteLine("They extend them to grip surfaces or fight and retract them for walking.");
        }

    }
}
