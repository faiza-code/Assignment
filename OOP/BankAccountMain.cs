using MakeenAssignment.OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP
{
    internal class BankAccountMain
    {
        static void Main(string[] args)
        {

            BankAccount acc = new BankAccount("Faiza", 12452, 67398, 985090);
            //Console.WriteLine(acc.widthDrow(-1000));

            int usreValue;
            do {
                Console.WriteLine("Wellcome to Bank Account");
                Console.WriteLine("------------------------");
                string menu = " 1 - for deposite option enter (1) \n" +
                              " 2 - for withDraw enter  (2) \n" +
                              " 3 - for Balance inforamation enter (3) \n" +
                              " 4 - Exit (4)";

                Console.WriteLine(menu);
                usreValue = int.Parse(Console.ReadLine());
                switch (usreValue)
                {
                    case 1:
                        Console.WriteLine("Wellcome to  the Deposite :");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine($"Yours Balance account {acc.Balance}");
                        Console.WriteLine("Please enter your amount for deposite :");
                        int amount = int.Parse(Console.ReadLine());
                        Console.WriteLine(acc.widthDrow(amount));

                        break;
                    case 2:
                        Console.WriteLine("Wellcome to  the withdraw :");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine($"Yours bank accont {acc.Balance}");
                        Console.WriteLine("Please enter your amount for withdraw :");
                        amount = int.Parse(Console.ReadLine());
                        Console.WriteLine(acc.deposit(amount));

                        break;
                    case 3:
                        Console.WriteLine(acc.totaleBalance());
                        break;
                    case 4:
                        return; 

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
                Console.WriteLine();
            }
                while (usreValue != 0) ;
            
        }
    }
}
