using MakeenAssignment.Assignment4.LibrarySystemBookStatusTracking.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.LibrarySystemBookStatusTracking.Models
{
    public  class Book
    {
        public string Title{ get; set; }
        public string Author { get; set; }
        public BookStatus Status{ get; set; }

        public Book(string title, string author, BookStatus status)
        {
            Title = title;
            Author = author;
            Status = status;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Book Informarion : " +
                $"TiTle Book : {Title}" +$"Author Book : {Author}"+ $"Book Status : {Status}");
        }
    }
}
