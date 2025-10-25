using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3.Models
{
    public class Truck : Vehicle
    {
        public double loadCapacity { get; set; }
        public Truck(string make, string model, int year, double loadCapacity) : base(make, model, year) 
        {
               this.loadCapacity = loadCapacity;  
        }
     
        public override void DisplayInfo()
        {
            Console.WriteLine($"Truck: {year} {make} {model}, Load Capacity: {loadCapacity} ");
        }
    }
}
