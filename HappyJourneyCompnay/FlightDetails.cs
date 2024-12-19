using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HappyJourneyCompnay
{
    public partial class FlightDetails : Form
    {
        public FlightDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dalal\\Desktop\\updated-OOD\\HappyJourneyCompnay\\Database1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(con))
            {
                int flightId = 0;
                if (!int.TryParse(textBox1.Text, out flightId))
                {
                    MessageBox.Show("Please enter a valid flight ID.");
                    return;
                }

                string query = @"
                    SELECT 
                        f.departure_Time, 
                        f.arrival_Time, 
                        f.price, 
                        d1.destination_Country AS DepartureDestination, 
                        d2.destination_Country AS ArrivalDestination
                    FROM Flight f
                    JOIN Destination d1 ON f.departure_Destination_Id = d1.destination_Id
                    JOIN Destination d2 ON f.arrival_Destination_Id = d2.destination_Id
                    WHERE f.flight_Id = @FlightId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FlightId", flightId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        richTextBox1.Text = $"Departure Time: {reader["departure_Time"].ToString()}\n" +
                                            $"Arrival Time: {reader["arrival_Time"].ToString()}\n" +
                                            $"Price: {reader["price"].ToString()}\n" +
                                            $"Departure Destination: {reader["DepartureDestination"].ToString()}\n" +
                                            $"Arrival Destination: {reader["ArrivalDestination"].ToString()}";
                    }
                    else
                    {
                        richTextBox1.Text = "Flight not found.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}