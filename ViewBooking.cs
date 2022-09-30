using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WeddingHall
{
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rashe\OneDrive\Documents\WeddingDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Con.Open();
            string query = "select * from Booking";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewBookingDGV.DataSource = ds.Tables[0];
            Con.Close();
            string BookDate = ViewBookingDGV.SelectedRows[0].Cells[1].Value.ToString();
            if (BookDate == "")
            {
                Bookkey = 0;
            }
            else
            {
                Bookkey = Convert.ToInt32(ViewBookingDGV.SelectedRows[0].Cells[0].Value.ToString());
                if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from Booking";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewBookingDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        int Bookkey = 0;
        /*private void DeleteBooking_Click(object sender, EventArgs e)
        {
            if (Bookkey == 0)
            {
                MessageBox.Show("Error! Select The Customer.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from Booking where BookId=" + Bookkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Deleted Successfully!");
                    Con.Close();
                    populate();
                    //clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }*/
        private void ViewBooking_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void XViewBooking_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewBooking_Load_1(object sender, EventArgs e)
        {

        }

        private void ViewBookingBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string BookId = ViewBookingDGV.SelectedRows[0].Cells[0].Value.ToString();
            string BookDate = ViewBookingDGV.SelectedRows[0].Cells[1].Value.ToString();
            string BookTime = ViewBookingDGV.SelectedRows[0].Cells[2].Value.ToString();
            string CstName = ViewBookingDGV.SelectedRows[0].Cells[3].Value.ToString();
            string Guest = ViewBookingDGV.SelectedRows[0].Cells[4].Value.ToString();
            string ChnFood = ViewBookingDGV.SelectedRows[0].Cells[5].Value.ToString();
            string BdFood = ViewBookingDGV.SelectedRows[0].Cells[6].Value.ToString();
            string BdFoodCost = ViewBookingDGV.SelectedRows[0].Cells[7].Value.ToString();
            string ChnFoodCost = ViewBookingDGV.SelectedRows[0].Cells[8].Value.ToString();
            string BookCharge = ViewBookingDGV.SelectedRows[0].Cells[9].Value.ToString();
            string GrdTotal = ViewBookingDGV.SelectedRows[0].Cells[10].Value.ToString();
            string Advance = ViewBookingDGV.SelectedRows[0].Cells[11].Value.ToString();
            string Balance = ViewBookingDGV.SelectedRows[0].Cells[12].Value.ToString();

            e.Graphics.DrawString("Booking Summary", new Font("Poetsen One", 28, FontStyle.Regular), Brushes.MediumOrchid, new Point(230, 70));
            e.Graphics.DrawString("Booking Id: " + BookId, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 150));
            e.Graphics.DrawString("Booking Date: " + BookDate, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 190));
            e.Graphics.DrawString("Booking Time: " + BookTime, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 230));
            e.Graphics.DrawString("Customer Name: " + CstName, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 270));
            e.Graphics.DrawString("No Guest: " + Guest, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 310));
            e.Graphics.DrawString("Chinese Food: " + ChnFood, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 350));
            e.Graphics.DrawString("Bangladeshi Food: " + BdFood, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 390));
            e.Graphics.DrawString("Food Cost: ", new Font("Poetsen One", 24, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 450));
            e.Graphics.DrawString("Bangladeshi Food Cost: " + BdFoodCost, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 500));
            e.Graphics.DrawString("Chinese Food Cost: " + ChnFoodCost, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 540));
            e.Graphics.DrawString("Booking Charge: " + BookCharge, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 580));
            e.Graphics.DrawString("Grand Total: " + GrdTotal, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 620));
            e.Graphics.DrawString("Advance : " + Advance, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 660));
            e.Graphics.DrawString("Balance : " + Balance, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.MediumOrchid, new Point(100, 700));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
