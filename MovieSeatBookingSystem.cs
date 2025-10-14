using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class MovieSeatBookingSystem
    {
        static void Main(string[] args)
        {
            //DataStore Decleration 
            string[,] seatBooking = new string[5, 5];
            int TotalSeatCount = 25;
            int UserInput;

            Console.WriteLine("\t\t\t welcome to Makeen Cinema ");
            Console.WriteLine("\t\t\t ------------------------- ");
            Console.WriteLine("Please Enter your query : ");
            string menu = "1-show Avaliable Seats \n 2-Book a seat  \n 3-Cancel Booking \n 4-show Seat Count  \n 5- Exit";
            Console.WriteLine(menu);
            int desiredRow, desiredColumn;
            //Array Filling and Visualization 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    seatBooking[i, j] = $"A({i + 1},{j + 1})";

                }

            }
            do
            {
                UserInput = int.Parse(Console.ReadLine());
                switch (UserInput)
                {
                    case 1:
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {

                                Console.Write($"\t\t {seatBooking[i, j]}");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("\t\t\t Welcome to booking system ");
                        Console.WriteLine("\t\t\t please choose from Available  seats your seat  (rows and column) to book  ");
                        Console.WriteLine("enter the Row : ");
                        desiredRow = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the Column : ");
                        desiredColumn = int.Parse(Console.ReadLine());
                        seatBooking[desiredRow - 1, desiredColumn - 1] = "X";
                        TotalSeatCount--;
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {

                                Console.Write($"\t\t {seatBooking[i, j]}");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("\t\t\t Welcome to cancelation system  ");
                        Console.WriteLine("\t\t\t please choose from bellow seat (rows and column) to cancel  ");
                        Console.WriteLine("enter the Row : ");
                        desiredRow = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the Column : ");
                        desiredColumn = int.Parse(Console.ReadLine());
                        seatBooking[desiredRow - 1, desiredColumn - 1] = $"A({desiredRow},{desiredColumn})";
                        TotalSeatCount++;
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {

                                Console.Write($"\t\t {seatBooking[i, j]}");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine($"\t\t\t number of available seats is {TotalSeatCount}  ");

                        break;
                    default:
                        if (UserInput != 5)
                            Console.WriteLine("invalid input ");
                        break;
                }
            }
            while (UserInput != 5);


            // Operations (Avilable Seat - Book - Cancel Booking  - Exit )

        }
    }
}
