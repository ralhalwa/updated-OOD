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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate the card number
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Length != 16 || !textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 16-digit card number.");
                return;
            }

            // Validate the expiration date
            if (!DateTime.TryParse(textBox2.Text, out DateTime expirationDate) || expirationDate < DateTime.Today)
            {
                MessageBox.Show("Please enter a valid expiration date.");
                return;
            }

            // Validate the CVV
            if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text.Length != 3 || !textBox3.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 3-digit CVV.");
                return;
            }

            // Validate the cardholder name
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter the cardholder's name.");
                return;
            }

            // If all input is valid, proceed with the payment process
            MessageBox.Show("Payment confirmed. Thank you for your purchase!");
            
            TravelerMainPage travelerMainPage = new TravelerMainPage();
            travelerMainPage.Show();
            this.Hide();
        }


    }
}
