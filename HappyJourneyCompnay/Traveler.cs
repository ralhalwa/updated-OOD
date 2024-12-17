using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyCompnay
{
    internal class Traveler : User
    {
        private int passportNumber;
        private int travelerId;

        public int PassportNumber { get { return passportNumber; } set { passportNumber = value; } }    
        public int TravelerId { get { return travelerId; } set { travelerId = value; } }        
    }
}
