using MakeenAssignment.Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace MakeenAssignment.Assignment3
{
    public class BookMain
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Bitter ", " Akwaeke Emezi  ", 2023, 978059);
            Book book2 = new Book("Ghost Boys ", "Jewell Parker Rhodes ", 2019, 978031);
            Book book3 = new Book("With the Fire on High ", " Elizabeth Acevedo", 2021, 978006);

            Console.WriteLine(book1.PrintBookInfo());
            Console.WriteLine(book2.PrintBookInfo());
            Console.WriteLine(book3.PrintBookInfo());

            Console.WriteLine();

            int yearCheck = 1997;
            Console.WriteLine($"Is {book1.title} older than {yearCheck}? {book1.Check(yearCheck)}");
            Console.WriteLine($"Is {book2.title} older than {yearCheck}? {book2.Check(yearCheck)}");
            Console.WriteLine($"Is {book3.title} older than {yearCheck}? {book3.Check(yearCheck)}");


            //Book[] book = new Book[3];
            //book[0] = new Book("Bitter ", " Akwaeke Emezi  ", 2023, 978059);
            //book[0] = new Book("Ghost Boys ", "Jewell Parker Rhodes ", 2019, 978031);
            //book[0] = new Book("With the Fire on High ", " Elizabeth Acevedo", 2021, 978006);
















        }
    }
}
