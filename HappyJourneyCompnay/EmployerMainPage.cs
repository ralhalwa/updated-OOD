using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyJourneyCompnay
{
    public partial class EmployerMainPage : Form
    {
        public EmployerMainPage()
        {
            InitializeComponent();
        }

        private void flightDetailsButton_Click(object sender, EventArgs e)
        {
            FlightDetails details = new FlightDetails();
            details.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchFlight searchFlight = new searchFlight();
            searchFlight.Show();
            this.Hide();   
        }

        private void EmployerMainPage_Load(object sender, EventArgs e)
        {

        }

        private void BookFlight_Click(object sender, EventArgs e)
        {
            TravelerMainPage travelerMainPage = new TravelerMainPage();
            travelerMainPage.Show();
        }
    }
}
