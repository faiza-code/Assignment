using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3.Models
{
    public class Cow: Animal
    {

        public Cow(string name) : base(name) { 
         this.Name = name;  
        }
        public override void MakeSound()
        {
            Console.WriteLine("Moo!");
        }
    }
}
