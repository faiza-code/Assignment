using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP2.Models
{
    public class Dog : Animal
    {

        public string TypeofDog { get; set; }

        public void Proneness() // المطاردة 
        {
            Console.WriteLine("Some dogs have a strong instinct to chase, while others are more curious about their surroundings. ");
        }
    }
}
