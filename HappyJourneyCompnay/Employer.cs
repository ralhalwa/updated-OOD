using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyCompnay
{
    internal class Employer
    {
        private List<int> assignedTravelers;
        private int employerId;

        public int EmployerId
        {
            get { return employerId; }
            set { employerId = value; }

        }
        public List<int> AssignedTravelers
        {
            get { return assignedTravelers; }
            set { assignedTravelers = value; }
        }
    }
}
