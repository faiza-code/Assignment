using MakeenAssignment.Assignment4.LibrarySystemBookStatusTracking.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.LibrarySystemBookStatusTracking.Models
{
    public class Library
    {
        public List<Book> Books = new List<Book>();
        public Book this[string title]
        {
            get
            {
                return Books.Find(book => book.Title.Equals(title));
            }
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }


        public void ChangeStatus(string title, BookStatus status)
        {
            var book = this[title];
            if (book != null)
            {
                book.Status = status;
                Console.WriteLine($"Status of '{book.Title}' is {status}.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found.");
            }
        }


        public void ShowBooksByStatus(BookStatus status)
        {
            Console.WriteLine($"Books with status {status}:");
            foreach (var book in Books)
            {
                if (book.Status == status)
                {
                    Console.WriteLine(book);
                }
            }
        }


    }
}
