using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WeddingHall
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                MessageBox.Show("Enter the Admin Password");
            }
            else if (Password.Text == "Admin123")
            {
                Staff staff = new Staff();
                staff.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void XAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackAdmin_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            if (User.Text == "WeddingAdmin")
            {
                MessageBox.Show("Enter the Admin Password");
            }
         
        }
    }
}
