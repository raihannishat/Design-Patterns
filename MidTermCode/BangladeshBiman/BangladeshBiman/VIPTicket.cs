using System;
using System.Collections.Generic;
using System.Text;

namespace BangladeshBiman
{
    public class VIPTicket : Ticket
    {
        public override void confirmingBookingStatus()
        {
            if (checkOutGateNumber > 11 && arrivalTime.Equals("9PM"))
            {
                bookingStatus = "Done";
            }
        }

        public override void setCheckInGateNumber()
        {
            checkInGateNumber = 23;
        }

        public override void setCheckOutGateNumber()
        {
            checkOutGateNumber = 22;
        }
    }
}
