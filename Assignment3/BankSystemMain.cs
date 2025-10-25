using MakeenAssignment.Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3
{
    public  class BankSystemMain
    {
        static void Main(string[] args)
        {

            // Create multiple bank accounts
            BankAccount acc1 = new BankAccount(1001, "Alice", 500);
            BankAccount acc2 = new BankAccount(1002, "Bob", 1000);
            BankAccount acc3 = new BankAccount(1003, "Charlie", 300);

            // Perform operations
            acc1.Deposit(200);
            acc2.Withdraw(150);
            acc3.Deposit(100);

            // Show accounts
            acc1.ShowAccount();
            acc2.ShowAccount();
            acc3.ShowAccount();

            // Show total accounts
            BankAccount.ShowTotalAccounts();

            // Keep console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        



  
        }
    }
}
