using System;
using System.Windows.Forms;

namespace HappyJourneyCompnay
{
    internal class User
    {
        private int contactNumber;
        private string dob; // Changed to string
        private string email;
        private string firstName;
        private string lastName;
        private string password; // Changed to string for better security practices
        private Role role;
        private string userType; // Renamed to avoid confusion with User class name
        private int userID;
        private string userName; // Changed from int to string

        public int ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Role Role
        {
            get { return role; }
            set { role = value; }
        }

        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

       
    }
}