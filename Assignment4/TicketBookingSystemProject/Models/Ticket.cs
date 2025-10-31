using MakeenAssignment.Assignment4.TicketBookingSystemProject.Enum;
using MakeenAssignment.Assignment4.TicketBookingSystemProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.TicketBookingSystemProject.Models
{
    public class Ticket
    {
        public string EventName { get; set; }
        public int SeatNumber { get; set; }
        public TicketType TicketType { get; set; }

        public Ticket(string eventName, int seatNumber, TicketType type)
        {
            this.EventName = eventName;
            this.SeatNumber = seatNumber;
            this.TicketType = type;
        }


    }
}
