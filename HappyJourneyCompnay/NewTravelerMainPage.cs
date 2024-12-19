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
    public partial class NewTravelerMainPage : Form
    {
        public NewTravelerMainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchFlight searchFlight = new searchFlight();
            searchFlight.Show();
            this.Hide();
        }

        private void BookFlight_Click(object sender, EventArgs e)
        {
            TravelerMainPage travelerMainPage = new TravelerMainPage();
            travelerMainPage.Show();
            this.Hide();
        }
    }
}
