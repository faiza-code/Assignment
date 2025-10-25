using MakeenAssignment.OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            //Deparment d1 = new Deparment();
            //d1.id = 1234;
            //d1.name = "Faiza";
            //Console.WriteLine($"Deparment ID is : {d1.id} is name : {d1.name}");

            //Deparment d2 = new Deparment();
            //d2.id = 5683;
            //d2.name = "Asma";
            //Console.WriteLine($"Deparment ID is : {d2.id} is name : {d2.name}");


            Deparment[] dep = new Deparment[3];
            for (int i = 1; i < dep.Length; i++)
            {
                dep[i] = new Deparment();
                Console.WriteLine($"Deparmant ID of departement {i} :");
                dep[i].id = int.Parse(Console.ReadLine());

                Console.WriteLine($"Deparmant Name of departement {i} :");
                dep[i].name = Console.ReadLine();

                Console.WriteLine($"Deparmant Descrepation of departement {i} :");
                dep[i].description = Console.ReadLine();

                dep[i].Remamber();
                Console.WriteLine(dep[i].Remamber1());

            }
        }


    }
}
    

