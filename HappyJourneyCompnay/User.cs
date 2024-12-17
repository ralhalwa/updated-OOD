using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyJourneyCompnay
{
    internal class User
    {
        private int contactNumber;
        private String dob;
        private String email;
        private String firstName;
        private String lastName;
        private int password;
        private Role role;
        private String type;
        private int userID;
        private int userName;
        
        public int ContactNumber { get { return contactNumber; } set { contactNumber = value; } }   
        public String Dob { get { return dob; } set { dob = value; } }  
        public String Email { get { return email; }set { email = value; } }   
        public String FirstName { get { return firstName; } set { firstName = value; } }        
        public String LastName { get { return lastName; } set { lastName = value; } }   
        public int Password { get { return password; } set { password = value; } }  
        public Role Role { get { return role; } set { role = value; } } 
        public String Type { get { return type; } set { type = value; } }   
        public int UserID { get { return userID; } set { userID = value; } }    
        public int UserName { get { return userName; } set { userName = value; } }


        public void login() { }
        public void logout() { }
        public void deactivate() { }
        public void updateProfile() { }
        public void viewMassage() { }
    }
}
