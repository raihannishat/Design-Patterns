using System;
using System.Collections.Generic;

namespace BangladeshBiman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menu = new List<string>()
            {
                "(#) => Please select your type: ",
                "(1) => DeluxTicket",
                "(2) => SupremeTicket",
                "(3) => VIPTicket"
            };

            menu.ForEach(x => Console.WriteLine(x));

            Console.Write("Please ticket type: ");
            TicketFactory ticketFactory = new TicketFactory();
            int type = int.Parse(Console.ReadLine());
            Ticket passenger = ticketFactory.GetTicket(type);

            Console.Write("\nEnter your arrival date: ");
            string date = Console.ReadLine();

            Console.Write("Enter your arrival time: ");
            string time = Console.ReadLine();

            passenger.setCheckInGateNumber();
            passenger.setCheckOutGateNumber();
            passenger.setArrivalDate(date);
            passenger.setArrivalTime(time);
            passenger.confirmingBookingStatus();

            PrintDocument document = PrintDocument.GetPrintDocument();
            document.print(passenger);
        }
    }
}
