using System;
using System.Collections.Generic;
using System.Text;

namespace BangladeshBiman
{
    public class SupremeTicket : Ticket
    {
        public override void confirmingBookingStatus()
        {
            if (checkOutGateNumber > 7 && arrivalTime.Equals("3PM"))
            {
                bookingStatus = "Done";
            }
        }

        public override void setCheckInGateNumber()
        {
            checkInGateNumber = 4;
        }

        public override void setCheckOutGateNumber()
        {
            checkOutGateNumber = 6;
        }
    }
}
