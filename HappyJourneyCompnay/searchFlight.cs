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
            // Get the country input from the user
            string countryInput = textBox1.Text.Trim();

            // Check if the user entered a valid country name
            if (string.IsNullOrEmpty(countryInput))
            {
                MessageBox.Show("Please enter a valid destination country.");
                return; // Exit if the input is empty
            }

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dalal\\Desktop\\updated-OOD\\HappyJourneyCompnay\\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    con.Open(); // Open the connection

                    // SQL query to search flights by departure or arrival destination country
                    string query = @"
                SELECT 
                    f.flight_Id,
                    f.departure_Time,
                    f.arrival_Time,
                    f.price,
                    dep.destination_Country AS Departure_Country,
                    arr.destination_Country AS Arrival_Country
                FROM 
                    Flight f
                LEFT JOIN 
                    Destination dep ON f.departure_Destination_Id = dep.destination_Id
                LEFT JOIN 
                    Destination arr ON f.arrival_Destination_Id = arr.destination_Id
                WHERE 
                    dep.destination_Country = @country OR arr.destination_Country = @country";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@country", countryInput);

                    SqlDataReader reader = cmd.ExecuteReader();

                    richTextBox1.Clear(); // Clear the previous results

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            richTextBox1.AppendText("Flight ID: " + reader["flight_Id"].ToString() + "\n");
                            richTextBox1.AppendText("Departure Time: " + reader["departure_Time"].ToString() + "\n");
                            richTextBox1.AppendText("Arrival Time: " + reader["arrival_Time"].ToString() + "\n");
                            richTextBox1.AppendText("Price: " + reader["price"].ToString() + "\n");
                            richTextBox1.AppendText("Departure Country: " + reader["Departure_Country"].ToString() + "\n");
                            richTextBox1.AppendText("Arrival Country: " + reader["Arrival_Country"].ToString() + "\n\n");
                        }
                    }
                    else
                    {
                        richTextBox1.AppendText("No flights available for the specified destination country.");
                    }

                    reader.Close();
                }
                catch (SqlException sqlEx)
                {
                    // Handle SQL errors
                    MessageBox.Show("Database Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    // Handle general errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void searchFlight_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flightBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
