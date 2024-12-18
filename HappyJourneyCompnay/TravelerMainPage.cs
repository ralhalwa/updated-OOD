﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyJourneyCompnay
{
    public partial class TravelerMainPage : Form
    {
        public TravelerMainPage()
        {
            InitializeComponent();
        }

        // This method loads the destinations into the ComboBox when the form is loaded
        private void TravelerMainPage_Load(object sender, EventArgs e)
        {
            // Ensure that the ComboBoxes and Labels are always visible
            comboBox1.Visible = true;
            label1.Visible = true;
            comboBox2.Visible = true;
            label2.Visible = true;
            startLabel.Visible = true;
            endLabel.Visible = true;
            startDatePicker2.Visible = true;
            endDateTimePicker1.Visible = true;

            // Create a connection string to connect to your SQL Server
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            try
            {
                // Open the connection
                con.Open();

                // Query to get destination countries
                string query = "SELECT destination_Country FROM [dbo].[Destination]";

                // Create the command
                SqlCommand cmd = new SqlCommand(query, con);

                // Execute the command and retrieve data
                SqlDataReader reader = cmd.ExecuteReader();

                // Clear the ComboBoxes before adding new data
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();

                // Check if the reader has rows
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string destinationCountry = reader["destination_Country"].ToString();
                        comboBox1.Items.Add(destinationCountry);
                        comboBox2.Items.Add(destinationCountry); // Add to both ComboBoxes
                    }
                }
                else
                {
                    MessageBox.Show("No destinations found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always close the connection
                con.Close();
            }
        }

        // This method will handle the behavior when the "One Way" radio button is selected
        private void OneWayRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (OneWayRadiobtn.Checked) // When "One Way" is selected
            {
                // Clear the selected values in the ComboBoxes (optional)
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
            }
        }

        // This method will handle the behavior when the "Two Way" radio button is selected
        private void TwoWaybtn_CheckedChanged(object sender, EventArgs e)
        {
            if (TwoWaybtn.Checked) // When "Two Way" is selected
            {
                // Clear the selected values in the ComboBoxes (optional)
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can handle any logic here if you need to process when the selection changes in comboBox1
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can handle any logic here if you need to process when the selection changes in comboBox2
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            // Implement any text change logic for search if necessary
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Implement search button functionality if necessary
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void startDatePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void bookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure input validation
                if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select valid departure and arrival destinations.", "Input Error");
                    return;
                }

                string departureCountry = comboBox1.SelectedItem.ToString();
                string arrivalCountry = comboBox2.SelectedItem.ToString();
                DateTime startDate = startDatePicker2.Value.Date;
                DateTime endDate = endDateTimePicker1.Value.Date;

                if (departureCountry == arrivalCountry)
                {
                    MessageBox.Show("Departure and arrival destinations cannot be the same.", "Input Error");
                    return;
                }

                // Debugging messages
                MessageBox.Show($"Departure: {departureCountry}, Arrival: {arrivalCountry}, Start Date: {startDate}, End Date: {endDate}", "Debug Info");

                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
                {
                    con.Open();
                    MessageBox.Show("Database connection successful.", "Debug Info");

                    string query = @"SELECT COUNT(*) 
                             FROM [dbo].[Flight] f
                             INNER JOIN [dbo].[Destination] d1 ON f.departure_Destination_Id = d1.destination_Id
                             INNER JOIN [dbo].[Destination] d2 ON f.arrival_Destination_Id = d2.destination_Id
                             WHERE d1.destination_Country = @departureCountry 
                               AND d2.destination_Country = @arrivalCountry
                               AND f.departure_Time >= @startDate 
                               AND f.arrival_Time <= @endDate";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@departureCountry", departureCountry);
                        cmd.Parameters.AddWithValue("@arrivalCountry", arrivalCountry);
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);

                        int flightCount = (int)cmd.ExecuteScalar();
                        MessageBox.Show($"Flights found: {flightCount}", "Debug Info");

                        if (flightCount > 0)
                        {
                            MessageBox.Show("Flight is available. Booking successful!", "Success");
                        }
                        else
                        {
                            MessageBox.Show("No matching flight found.", "Not Found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }



        private void BookFlight_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchFlight searchFlight = new searchFlight();
            searchFlight.Show();
            this.Hide();
        }
    }
}
