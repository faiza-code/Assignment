using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP2.Models
{
    public abstract class Animal
    {
        public string movement { get; set; }
        public string heterotrophic { get; set; } //االتكاثر
        public string reproduction { get; set; } // التغذية 
        public Animal() { }

        public void Move()
        {
            Console.WriteLine("I am moving");
        }
    }
}
