using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyCompnay
{
    internal class FlightCategory
    {
        private int categoryId;
        private string categoryName;
        private string categoryDescription;
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public string CategoryDescription
        {
            get { return categoryDescription; }
            set { categoryDescription = value; }
        }
    }
}
