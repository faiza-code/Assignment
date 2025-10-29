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

            
            BankAccount bankAccount1 = new BankAccount(1239, "Faiza", 9000);
            BankAccount bankAccount2 = new BankAccount(3458, "Marwa", 5000);
            BankAccount bankAccount3 = new BankAccount(9023, "Noor", 500);


            bankAccount1.Deposit(200);
            bankAccount2.Withdraw(150);
            bankAccount3.Deposit(100);

            
            bankAccount1.ShowAccount();
            bankAccount2.ShowAccount();
            bankAccount3.ShowAccount();

            
            BankAccount.ShowTotalAccounts();

   
            Console.WriteLine("To End Process Press any key to exit...");
            Console.ReadKey();
        



  
        }
    }
}
