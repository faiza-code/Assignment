using MakeenAssignment.Assignment4.TicketBookingSystemProject.Enum;
using MakeenAssignment.Assignment4.TicketBookingSystemProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.TicketBookingSystemProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            TicketSystem system = new TicketSystem();

            
            system.AddTicket(new Ticket("Business trip", 12  , TicketType.VIP));
            system.AddTicket(new Ticket("Tourist trip", 6, TicketType.VIP));
            system.AddTicket(new Ticket("Tourist trip", 10 , TicketType.Backstage));


            Console.WriteLine("Wellcom To Ticket Booking System");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Information about Seats reserved on the flight :");
            Console.WriteLine("Seat 10 " + system[10]?.TicketType);
            Console.WriteLine("Seat 6  " + system[6]?.TicketType);


            Console.WriteLine("---------------------------------");
            Console.WriteLine("Information about Tickets Type  :");
            Console.WriteLine(system.CountType(TicketType.Regular));
            Console.WriteLine(system.CountType(TicketType.VIP));
            Console.WriteLine(system.CountType(TicketType.Backstage));
        }
    }
}
