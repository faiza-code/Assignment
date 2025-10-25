using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3.Models
{
    public class Car :Vehicle 
    {
        public int doorNumber { get; set; }
        public Car(string make, string model, int year, int doornumber):base(make, model, year) {
            this.make = make;
            this.model = model;
            this.year = year;
            this.doorNumber = doornumber;
                
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {year} {make} {model}, Doors: {doorNumber}");
        }

    }
}
