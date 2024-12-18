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
            string firstNameInput = fName.Text.Trim();  // first name from fName TextBox
            string lastNameInput = lName.Text.Trim();   // last name from lName TextBox
            string emailInput = email.Text.Trim();      // email from email TextBox
            string passwordInput = password.Text.Trim(); // password from password TextBox
            string userNameInput = userName.Text.Trim(); // username from userName TextBox

            // Validate that all fields are filled
            if (string.IsNullOrEmpty(firstNameInput) ||
                string.IsNullOrEmpty(lastNameInput) ||
                string.IsNullOrEmpty(emailInput) ||
                string.IsNullOrEmpty(passwordInput) ||
                string.IsNullOrEmpty(userNameInput))
            {
                MessageBox.Show("Please fill all the fields.");
                return; // Exit the method if any field is empty
            }

            // Hardcoded user type "Traveller"
            string userType = "Traveller";

            // Assuming user_Type_Id for "Traveller" is 1 (this needs to match your reference table for user types)
            int userTypeId = 1;

            // Set the connection string (update with your actual database details)

            // Insert the user data into the User table
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    string query = @"INSERT INTO [dbo].[User] (user_Type, userName, firstName, LastName, Email, password, user_Type_Id)
                                   VALUES (@userType, @userName, @firstName, @lastName, @Email, @password, @userTypeId)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection and pass values from the TextBox.Text
                        cmd.Parameters.AddWithValue("@userType", userType);
                        cmd.Parameters.AddWithValue("@userName", userNameInput);  // Ensure userNameInput is from TextBox.Text
                        cmd.Parameters.AddWithValue("@firstName", firstNameInput);  // Ensure firstNameInput is from TextBox.Text
                        cmd.Parameters.AddWithValue("@lastName", lastNameInput);  // Ensure lastNameInput is from TextBox.Text
                        cmd.Parameters.AddWithValue("@Email", emailInput);  // Ensure emailInput is from TextBox.Text
                        cmd.Parameters.AddWithValue("@password", passwordInput);  // Ensure passwordInput is from TextBox.Text
                        cmd.Parameters.AddWithValue("@userTypeId", userTypeId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User registered successfully!");
                        }
                        else
                        {
                            MessageBox.Show("User registration failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
