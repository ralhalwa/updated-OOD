using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyCompnay
{
    internal class Booking
    {
        private int bookingId;
        private Flight flight;
        private bool paymentStatus;
        private Traveler traveler;

        public int BookingId
        {
            get { return bookingId; }
            set { bookingId = value; }
        }

        public Flight Flight
        {
            get { return flight; }
            set { flight = value; }
        }

        public bool PaymentStatus
        {
            get { return paymentStatus; }
            set { paymentStatus = value; }
        }

        public Traveler Traveler
        {
            get { return traveler; }
            set { traveler = value; }
        }
    }
}
