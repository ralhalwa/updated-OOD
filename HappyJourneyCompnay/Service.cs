using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyCompnay
{
    internal class Service
    {
        private string serviceName;
        private int serviceId;
        private string serviceDescription;

        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        public int ServiceId
        {
            get { return serviceId; }
            set { serviceId = value; }
        }

        public string ServiceDescription
        {
            get { return serviceDescription; }
            set { serviceDescription = value; }
        }
    }
}

