using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HappyJourneyCompnay
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Retrieve the data from the text fields (TextBox.Text)
            string firstNameInput = fName.Text.Trim();
            string lastNameInput = lName.Text.Trim();
            string emailInput = email.Text.Trim();
            string passwordInput = password.Text.Trim();
            string userNameInput = userName.Text.Trim();

            // Validate that all fields are filled
            if (string.IsNullOrEmpty(firstNameInput) ||
                string.IsNullOrEmpty(lastNameInput) ||
                string.IsNullOrEmpty(emailInput) ||
                string.IsNullOrEmpty(passwordInput) ||
                string.IsNullOrEmpty(userNameInput))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            string userType = "Traveller";
            int userTypeId = 1;

            // Connection string with absolute path

            try
            {
                // Check if SQL LocalDB instance is running
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Documents\\updated-OOD\\HappyJourneyCompnay\\Database1.mdf;Integrated Security=True"))
                {
                    connection.Open(); // Attempt to open the connection

                    string query = @"INSERT INTO [dbo].[User] 
                            (user_Type, userName, firstName, LastName, Email, password, user_Type_Id)
                            VALUES (@userType, @userName, @firstName, @lastName, @Email, @password, @userTypeId)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@userType", userType);
                        cmd.Parameters.AddWithValue("@userName", userNameInput);
                        cmd.Parameters.AddWithValue("@firstName", firstNameInput);
                        cmd.Parameters.AddWithValue("@lastName", lastNameInput);
                        cmd.Parameters.AddWithValue("@Email", emailInput);
                        cmd.Parameters.AddWithValue("@password", passwordInput);
                        cmd.Parameters.AddWithValue("@userTypeId", userTypeId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User registered successfully!");
                        }
                        else
                        {
                            MessageBox.Show("User registration failed. No rows affected.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Specific SQL error handling
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (InvalidOperationException invOpEx)
            {
                // Handling invalid operation error (e.g., connection issues)
                MessageBox.Show("Connection Error: " + invOpEx.Message);
            }
            catch (Exception ex)
            {
                // General error handling
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}