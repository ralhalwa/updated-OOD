using Microsoft.Win32;
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
    public partial class Form1 : Form
    {

        public static Form1 Instance;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPg loginPg = new LoginPg();
            loginPg.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
           Register register = new Register();
           register.Show();
           //AdminManPage adminManPage = new AdminManPage();
          // TravelerMainPage travelerMainPage = new TravelerMainPage();
         // EmployerMainPage page = new EmployerMainPage();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
