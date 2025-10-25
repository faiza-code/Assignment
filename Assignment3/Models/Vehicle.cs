using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3.Models
{
    public class Vehicle
    {
        public string  make { get; set; }
        public string model { get; set; }
        public int year { get; set; }

        public Vehicle( string make , string model , int year) {
            this.make = make;
            this.model = model;
            this.year = year;
        
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicl information : {year} {make} {model}");
        }
    }
}
