using System;
using System.Collections.Generic;
using System.Text;

namespace BangladeshBiman
{
    public class DeluxTicket : Ticket
    {
        public override void confirmingBookingStatus()
        {
            if (checkInGateNumber > 3 && arrivalDate.Equals("30 June"))
            {
                bookingStatus = "Done";
            }
        }

        public override void setCheckInGateNumber()
        {
            checkInGateNumber = 5;
        }

        public override void setCheckOutGateNumber()
        {
            checkOutGateNumber = 33;
        }
    }
}
