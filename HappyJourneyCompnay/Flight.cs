using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyCompnay
{
    internal class Flight
    {
        private DateTime arrivalTime;
        private FlightCategory category;
        private DateTime departureTime;
        private string destination;
        private int flightId;
        private decimal price;
         

        public DateTime ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }

        public FlightCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int FlightId
        {
            get { return flightId; }
            set { flightId = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
