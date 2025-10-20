using MakeenAssignment.OOP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            //animal.Move();
            Console.WriteLine("----Attributes of Engle----");
            Engle engle = new Engle();
            engle.Move();
            engle.fly();

            Console.WriteLine("----Attributes of Dog----");
            Dog dog = new Dog();
            dog.Move();
            dog.Proneness();

            Console.WriteLine("----Attributes of Duck----");
            Duck duck = new Duck();
            duck.Move();
            duck.Feathers();

            Console.WriteLine("----Attributes of Cat----");
            Cat cat = new Cat();
            cat.Move();
            cat.typeCalws();



        }
    }
}
