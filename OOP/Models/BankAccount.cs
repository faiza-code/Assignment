using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.OOP.Models
{
    internal class BankAccount
    {
        public const decimal MAXWIDTHDROW = 5000;
        private string username;
        private int password;
        private int id;
        private decimal balance;

        public string Username { get => username; set => username = value; }
        public int Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
        public decimal Balance { get => balance; set => balance = value; }

        public BankAccount(string username, int password, int id ,decimal balance)
        {
            this.Username = username;
            this.Password = password;
            this.Id = id;
            this.Balance = balance;
        }

        public string widthDrow(decimal amount)
        {
            if (amount > MAXWIDTHDROW)
            {
                return $"you Can't With Draw more than {MAXWIDTHDROW} per day";
            }
            else if (amount < 0)
            {
                return $"invalid amoount please enter a positive amount  ";
            }
            else if (this.Balance >= amount)
            {
                this.balance -= amount;

                return $"withdraw successfully please take the money and your current balance is {this.Balance}";
            }
            return $"something went wrong ";
        }

        public string deposit(decimal amount) 
        {
            if (amount > MAXWIDTHDROW)
            {
                return $"you Can't With Draw more than {MAXWIDTHDROW} per day";
            }
            else if (amount < 0)
            {
                return $"invalid amoount please enter a positive amount  ";
            }
            else if (this.Balance >= amount)
            {
                this.balance += amount;

                return $"withdraw successfully please take the money and your current balance is {this.Balance}";
            }
            return $"something went wrong ";
        }

        public string totaleBalance()
        {
            return $"Your Total balance is : {this.Balance}";
        }








    }
}
