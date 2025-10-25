using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3.Models
{
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public int isbn { get; set; }

        public Book( string title , string author ,int year , int isbn ) {
            this.title = title;
            this.author = author;
            this.year = year;
            this.isbn = isbn;
        }

        public string PrintBookInfo()
        { 
            return $"Book infomation :\n Book Name : {this.title} Writin by: {this.author} Publiction year: {this.year} ISBN Number: {this.isbn}";
        }

        public bool Check(int specificYear )
        {
           return year < specificYear;
        }





    }
}
