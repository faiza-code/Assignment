using MakeenAssignment.Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3
{
    public class AnimalSoundSimulationMain
    {
      public static void ListName(List<Animal> animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals);
            }
        }
     static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
        {
            new Dog("Bingooo"),
            new Cat("Leoooo"),
            new Cow("Losey")
        };

            ListName(animals);

        }
    }
}
