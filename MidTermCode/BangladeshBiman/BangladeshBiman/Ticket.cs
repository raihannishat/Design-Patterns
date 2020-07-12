using System;
using System.Collections.Generic;
using System.Text;

namespace BangladeshBiman
{
    public abstract class Ticket
    {
        protected string arrivalDate { get; set; }
        protected string arrivalTime { get; set; }
        protected double checkInGateNumber { get; set; }
        protected double checkOutGateNumber { get; set; }
        protected string bookingStatus { get; set; }

        public void setArrivalTime(string arrivalTime)
        {
            this.arrivalTime = arrivalTime;
        }

        public string getArrivalTime()
        {
            return arrivalTime;
        }

        public void setArrivalDate(string arrivalDate)
        {
            this.arrivalDate = arrivalDate;
        }

        public string getArrivalDate()
        {
            return arrivalDate;
        }

        public string getBillDone()
        {
            return bookingStatus;
        }

        public double getCheckInGateNumber()
        {
            return checkInGateNumber;
        }

        public double getCheckOutGateNumber()
        {
            return checkOutGateNumber;
        }

        public string getBookingStatus()
        {
            return bookingStatus;
        }

        public abstract void setCheckInGateNumber();
        public abstract void setCheckOutGateNumber();
        public abstract void confirmingBookingStatus();
    }
}
