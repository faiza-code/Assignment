using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment2
{
    public class LibraryBookBorrowingSystem
    {
        static string[] books = {
        "The Great Gatsby",
        "To Kill a Mockingbird",
        "1984",
        "Pride and Prejudice",
        "The Catcher in the Rye"
    };

        static bool[] isBorrowed = new bool[books.Length];
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Library Book Borrowing System Menu:");
                Console.WriteLine("1. View Books");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Check Availability");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewBooks();
                        break;
                    case "2":
                        BorrowBook();
                        break;
                    case "3":
                        ReturnBook();
                        break;
                    case "4":
                        CheckAvailability();
                        break;
                    case "5":
                        Console.WriteLine("Exiting system...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ViewBooks()
        {
            Console.WriteLine("Books in Library:");
            for (int i = 0; i < books.Length; i++)
            {
                string status = isBorrowed[i] ? "Borrowed" : "Available";
                Console.WriteLine($"{i + 1}. {books[i]} - {status}");
            }
        }

        static void BorrowBook()
        {
            Console.Write("Enter book number to borrow: ");
            if (int.TryParse(Console.ReadLine(), out int bookNum) && bookNum >= 1 && bookNum <= books.Length)
            {
                int index = bookNum - 1;
                if (!isBorrowed[index])
                {
                    isBorrowed[index] = true;
                    Console.WriteLine($"You have borrowed \"{books[index]}\".");
                }
                else
                {
                    Console.WriteLine("Sorry, this book is already borrowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid book number.");
            }
        }

        static void ReturnBook()
        {
            Console.Write("Enter book number to return: ");
            if (int.TryParse(Console.ReadLine(), out int bookNum) && bookNum >= 1 && bookNum <= books.Length)
            {
                int index = bookNum - 1;
                if (isBorrowed[index])
                {
                    isBorrowed[index] = false;
                    Console.WriteLine($"You have returned \"{books[index]}\".");
                }
                else
                {
                    Console.WriteLine("This book was not borrowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid book number.");
            }
        }

        static void CheckAvailability()
        {
            Console.Write("Enter book number to check availability: ");
            if (int.TryParse(Console.ReadLine(), out int bookNum) && bookNum >= 1 && bookNum <= books.Length)
            {
                int index = bookNum - 1;
                if (!isBorrowed[index])
                {
                    Console.WriteLine($"\"{books[index]}\" is available.");
                }
                else
                {
                    Console.WriteLine($"\"{books[index]}\" is currently borrowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid book number.");
            }
        }
    }
}

