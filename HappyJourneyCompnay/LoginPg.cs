using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyJourneyCompnay
{
    public partial class LoginPg : Form
    {
        public static LoginPg instance;
        public LoginPg()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            // Check if username or password is empty
            if (string.IsNullOrEmpty(userNametxt.Text) || string.IsNullOrEmpty(Passwordtxt.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create a connection string to connect to your SQL Server
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

                // Query to get user credentials
                string query = "SELECT user_Type, password FROM [dbo].[User] WHERE userName = @userName";

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userName", userNametxt.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string dbPassword = reader["password"].ToString();
                        string userType = reader["user_Type"].ToString();

                        // Check if the entered password matches the password in the database
                        if (Passwordtxt.Text == dbPassword)
                        {
                            // Check the user type and open the appropriate page
                            if (userType == "Admin")
                            {
                                this.Close();
                                AdminManPage admin = new AdminManPage();
                                admin.Show();
                            }
                            else if (userType == "Traveller")
                            {
                                this.Close();
                                TravelerMainPage traveler = new TravelerMainPage();
                                traveler.Show();
                            }
                            else
                            {
                                MessageBox.Show("Unknown user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void userNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPg_Load(object sender, EventArgs e)
        {

        }
    }
}
