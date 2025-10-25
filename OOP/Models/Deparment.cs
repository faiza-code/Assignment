using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP.Models
{
    public class Deparment
    {
      public  int id;
      public string name;
      public string description;

        public void Remamber()
        {
            Console.WriteLine("استانس اليوم الخميس الونيس ");
        }

        public string Remamber1()
        {
            return $"استانس اليوم الخميس الونيس ";
        }
    }
}
