using System;
using System.Collections.Generic;
using System.Text;

namespace BangladeshBiman
{
    public class PrintDocument
    {
        private static volatile PrintDocument _printDocument;
        private static readonly object _lock = new object();

        private PrintDocument() { }

        public static PrintDocument GetPrintDocument()
        {
            if (_printDocument == null)
            {
                lock (_lock)
                {
                    if (_printDocument == null)
                    {
                        _printDocument = new PrintDocument();
                    }
                }
            }

            return _printDocument;
        }

        public void print(Ticket info)
        {
            Console.WriteLine("\nPrinting Information: ");
            Console.WriteLine($"Arrival Date: {info.getArrivalDate()}");
            Console.WriteLine($"Arrival Time: {info.getArrivalTime()}");
            Console.WriteLine($"Check In Gate Number: {info.getCheckInGateNumber()}");
            Console.WriteLine($"Check Out Gate Number: {info.getCheckOutGateNumber()}");
            Console.WriteLine($"Booking Status: {info.getBookingStatus()}");
        }
    }
}
