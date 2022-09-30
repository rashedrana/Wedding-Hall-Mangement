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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rashe\OneDrive\Documents\WeddingDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddCst_Click(object sender, EventArgs e)
        {
            if(CstName.Text == "" || CstAdd.Text == "" || CstPhone.Text == "")
            {
                MessageBox.Show("Error! Add Customer Details.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Customer values ('" + CstName.Text + "','" + CstAdd.Text + "','" + CstPhone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added!");
                    Con.Close();
                    populate();
                    clear();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from Customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CstDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }
        int custkey = 0;
        private void CstDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CstName.Text = CstDGV.SelectedRows[0].Cells[1].Value.ToString();
            CstAdd.Text = CstDGV.SelectedRows[0].Cells[2].Value.ToString();
            CstPhone.Text = CstDGV.SelectedRows[0].Cells[3].Value.ToString();
            if(CstPhone.Text == "")
            {
                custkey = 0;
            }
            else
            {
                custkey = Convert.ToInt32(CstDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
        private void clear()
        {
            CstPhone.Text = "";
            CstAdd.Text = "";
            custkey = 0;
            CstName.Text = "";
        }
        private void CstReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DeleteCst_Click(object sender, EventArgs e)
        {
            if (custkey == 0)
            {
                MessageBox.Show("Error! Select The Customer.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from Customer where CstId=" + custkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully!");
                    Con.Close();
                    populate();
                    clear();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditCst_Click(object sender, EventArgs e)
        {
            if (CstName.Text == "" || CstAdd.Text == "" || CstPhone.Text == "")
            {
                MessageBox.Show("Error! Select The Customer.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Customer set CstName='"+ CstName.Text + "',CstAdd='"+CstAdd.Text+ "',CstPhone='"+CstPhone.Text+ "' where CstId=" + custkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Updated!");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void XCst_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CstBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
