using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3.Models
{
    public class BankAccount
    {
        private static int totalAccounts = 0;
        private int accountNumber;
        private double balance;
        private string owner;

        public BankAccount( int accountNumber, string owner, double initialBalance )
        { 
            this.accountNumber = accountNumber;
            this.owner = owner;
            this.balance = initialBalance >= 0 ? initialBalance : throw new ArgumentException("Initial balance cannot be negative.");
            totalAccounts++;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Enter positive amount.");
                return;
            }
            balance += amount;
            Console.WriteLine($"Deposited {amount}. New Balance: {balance}");
        }

        // Withdraw method
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Enter positive amount.");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New Balance: {balance}");
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Balance cannot be negative.");
                balance = value;
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Owner name cannot be empty.");
                owner = value;
            }
        }

        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"Total accounts created: {totalAccounts}");
        }

        // Show account details
        public void ShowAccount()
        {
            Console.WriteLine($"AccountNumber: {AccountNumber}, Owner: {Owner}, Balance: {Balance}");
        }
    }





















}
}
