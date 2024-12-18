using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HappyJourneyCompnay
{
    public partial class searchFlight : Form
    {
        public searchFlight()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
            {
                con.Open(); // Open connection

                SqlCommand cmd = new SqlCommand("SELECT * FROM Flight WHERE flight_Id = @flight_id", con);
                cmd.Parameters.AddWithValue("@flight_id", Convert.ToInt32(textBox1.Text));

                SqlDataReader reader = cmd.ExecuteReader();

                richTextBox1.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        richTextBox1.AppendText("Flight ID: " + reader["flight_Id"].ToString() + "\n");
                        richTextBox1.AppendText("Departure Time: " + reader["departure_Time"].ToString() + "\n");
                        richTextBox1.AppendText("Arrival Time: " + reader["arrival_Time"].ToString() + "\n");
                        richTextBox1.AppendText("Price: " + reader["price"].ToString() + "\n");
                        richTextBox1.AppendText("Destination ID: " + reader["destination_Id"].ToString() + "\n\n");
                    }
                }
                else
                {
                    richTextBox1.AppendText("No flight information avilable for this flight ID.");
                }

                reader.Close();
            }
        }

        private void searchFlight_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
