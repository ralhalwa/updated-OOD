using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyCompnay
{
    internal class Company
    {
        private int companyId;
        private string companyName;
        private List<int> employee;
        private string location;

        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public List<int> Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
