using MakeenAssignment.Assignment4.LibrarySystemBookStatusTracking.Enum;
using MakeenAssignment.Assignment4.LibrarySystemBookStatusTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.LibrarySystemBookStatusTracking
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

          
            library.AddBook(new Book("Bitter", "Akwaeke Emezi", BookStatus.Available));
            library.AddBook(new Book("Ghost Boys ", "Jewell Parker Rhodes ", BookStatus.CheckedOut));
            library.AddBook(new Book("With the Fire on High ", " Elizabeth Acevedo", BookStatus.Reserved));
          

           
            Console.WriteLine("All Books in Library:");
            foreach (var element in library.Books)
            {
                Console.WriteLine(element);
            }

            
            library.ChangeStatus("Ghost Boys", BookStatus.Available);

          
            library.ShowBooksByStatus(BookStatus.Available);
            library.ShowBooksByStatus(BookStatus.CheckedOut);


        }
    }
}
