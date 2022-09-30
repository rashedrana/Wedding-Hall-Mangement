using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WeddingHall
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.Show();
            this.Hide();
        }

        private void ViewBooking_Click(object sender, EventArgs e)
        {
            ViewBooking viewbook = new ViewBooking();
            viewbook.Show();
            this.Hide();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void XHome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
