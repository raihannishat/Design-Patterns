using System;
using System.Collections.Generic;
using System.Text;

namespace BangladeshBiman
{
    public class TicketFactory
    {
        public Ticket GetTicket(int ticketType)
        {
            Ticket ticket = null;

            ticket = ticketType switch
            {
                1 => GetDeluxTicket(),
                2 => GetSupremeTicket(),
                3 => GetVIPTicket(),
                _ => null
            };

            return ticket;
        }

        private DeluxTicket GetDeluxTicket()
        {
            return new DeluxTicket();
        }

        private SupremeTicket GetSupremeTicket()
        {
            return new SupremeTicket();
        }

        private VIPTicket GetVIPTicket()
        {
            return new VIPTicket();
        }
    }
}
