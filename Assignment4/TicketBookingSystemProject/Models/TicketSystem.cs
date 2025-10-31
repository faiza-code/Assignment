using MakeenAssignment.Assignment1;
using MakeenAssignment.Assignment4.TicketBookingSystemProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment4.TicketBookingSystemProject.Models
{
    public class TicketSystem
    {
        public List<Ticket> tickets = new List<Ticket>();

        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }
        public Ticket this[int seatNumber]
        {
            get
            {
                foreach (var element in tickets)
                {
                    if (element.SeatNumber == seatNumber)
                        return element;
                }
                return null; 
            }

        }

        public int CountType(TicketType type)
        {
            int count = 0;
            foreach (var element in tickets)
            {
                if (element.TicketType == type)
                    count++;
            }
            return count;
        }
    }
}

