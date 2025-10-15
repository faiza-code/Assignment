using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment2
{
    internal class LoginForm
    {
        public string Username { get; set; }
        public string Password { get; set; } // In a real application, never store plain text passwords.

        public LoginForm(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // Override the ToString() method to provide a custom string representation
        public override string ToString()
        {
            return $"Welcome, {Username}! You are now logged in.";
        }
        static void Main(string[] args)
        {
            // Simulate a registered user
            LoginForm register = new LoginForm("admin", "password123");

            Console.Write("Enter Username: ");
            string enteredUsername = Console.ReadLine();

            Console.Write("Enter Password: ");
            string enteredPassword = Console.ReadLine();

            // Simple "login" check
            if (enteredUsername == register.Username && enteredPassword == register.Password)
            {
                // When the User object is passed to Console.WriteLine, its ToString() method is implicitly called.
                Console.WriteLine(register);
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }
    }
}
