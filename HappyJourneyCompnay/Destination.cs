using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyCompnay
{
    internal class Destination
    {
        private String destinationCountry;
        private string destinationDescription;
        private int destinationId;
        private string destinationName;

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set { destinationCountry = value; }
        }

        public string DestinationDescription
        {
            get { return destinationDescription; }
            set { destinationDescription = value; }
        }

        public int DestinationId
        {
            get { return destinationId; }
            set { destinationId = value; }
        }

        public string DestinationName
        {
            get { return destinationName; }
            set { destinationName = value; }
        }

    }
}
