using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP2.Models
{
    public class Duck : Engle
    {
        public string Bill { get; set; } // المنقار 
        public string Plumage { get; set; } // الريش

        public void Feathers()
        {
            Console.WriteLine("Ducks have waterproof feathers thanks to an oil gland, which keeps them warm and dry.");
        }

    }
}
