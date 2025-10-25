using MakeenAssignment.Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3
{
     public class VehicleSystemMain
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle = new Vehicle();

            Car car = new Car("Mercedes", "JClass", 2025, 4);
            Truck truck = new Truck("Volvo", "FH", 2024, 2);

            
            Console.WriteLine("---------------------------------");
            car.DisplayInfo();
            Console.WriteLine("---------------------------------");
            truck.DisplayInfo();
            


        }
    }
}
