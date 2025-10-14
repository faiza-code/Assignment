using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class SimpleBankSystem
    {
        static void Main(string[] args)
        {
            // Banking App 01
            //Data Store (مخزن البيانات )
            //transfer account id 1 - 1                    
            //  0       1           2
            string[] UserName = { "usif", "hossam", "Masad" };
            string[] Password = { "123", "456", "789" };
            decimal[] Balance = { 1000, 20000, 30000 };
            bool isAuthenticated = false;
            int userIndex = -1;
            //------------------------------------------
            //login system 
            do
            {
                Console.WriteLine("\t\t\t Welcome to Bank Muscat ");
                Console.WriteLine("\t\t\t ------------------------ ");
                Console.WriteLine("\t \t \t ---------------------------------");
                Console.WriteLine("\t \t \t Login Page ");
                Console.Write(" \t \t  UserName : ");
                string userValue = Console.ReadLine();
                Console.WriteLine();
                Console.Write(" \t \t  Password : ");
                string userPass = Console.ReadLine();

                for (int i = 0; i < UserName.Length; i++)
                {
                    if (!(userValue == UserName[i] && userPass == Password[i]))
                    {
                        if (UserName.Length == i)
                        {
                            Console.WriteLine("Invalid username or password");
                        }
                    }
                    else if (userValue == UserName[i] && userPass == Password[i])
                    {
                        isAuthenticated = true;
                        userIndex = i;
                        break;
                    }
                }
            }
            while (!isAuthenticated);

            Console.WriteLine($" Welcome mr{UserName[userIndex]}" +
                $" \n your balance is {Balance[userIndex]} ");


            string menu = "1- for deposite option enter (1) \n 2- for withDraw enter (2) \n 3- for Balance information enter (3):";
            Console.WriteLine(menu);
            int val = int.Parse(Console.ReadLine());
            switch (val)
            {
                case 1:
                    Console.WriteLine("Welcome to the Deposite ");
                    Console.WriteLine("------------------------");
                    Console.WriteLine($"your bank account amount {Balance[userIndex]}");
                    Console.WriteLine("please enter your amount for deposite : ");
                    int amount = int.Parse(Console.ReadLine());//only read the value as string
                    if (amount <= 0)
                    {
                        Console.WriteLine("invalid amount ");
                    }
                    else
                    {
                        Balance[userIndex] = amount;
                        Console.WriteLine($"your new Balance is {Balance[userIndex]}");
                    }
                    break;
                case 2:
                    Console.WriteLine("Welcome to the Withdraw ");
                    Console.WriteLine("------------------------");
                    Console.WriteLine($"your bank account amount {Balance[userIndex]}");
                    Console.WriteLine("please enter your amount for withdraw : ");
                    amount = int.Parse(Console.ReadLine());//only read the value as string
                    if (amount <= 0)
                    {
                        Console.WriteLine("invalid amount ");
                    }
                    else
                    {
                        Balance[userIndex] -= amount;
                        Console.WriteLine($"your new Balance is {Balance[userIndex]}");
                    }
                    break;
                case 3:
                    Console.WriteLine($"your current total balance is : {Balance[userIndex]}");
                    break;
                default:
                    Console.WriteLine("invalid input ");
                    break;
            }
        }
    }
}