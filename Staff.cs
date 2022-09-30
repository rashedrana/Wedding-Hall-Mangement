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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rashe\OneDrive\Documents\WeddingDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from Staff";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int EmpKey = 0;
        private void clear()
        {
            EmpName.Text = "";
            EmpPass.Text = "";
            EmpKey = 0;
            EmpPhone.Text = "";
            EmpGender.SelectedIndex = -1;
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpKey == 0)
            {
                MessageBox.Show("Error! Select The Staff.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from Staff where StaffId=" + EmpKey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted Successfully!");
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

        private void XEmp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            if (EmpName.Text == "" || EmpPhone.Text == "" || EmpGender.SelectedIndex == -1 || EmpPass.Text == "")
            {
                MessageBox.Show("Error! Add Staff Details.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Staff values ('" + EmpName.Text + "','" + EmpPhone.Text + "','" + EmpGender.SelectedItem.ToString() + "','" + EmpPass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Added!");
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

        private void EmpReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpName.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpPhone.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpGender.SelectedItem = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPass.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (EmpName.Text == "")
            {
                EmpKey = 0;
            }
            else
            {
                EmpKey = Convert.ToInt32(EmpDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditEmp_Click(object sender, EventArgs e)
        {
            if (EmpName.Text == "" || EmpPhone.Text == "" || EmpGender.SelectedIndex == -1 || EmpPass.Text == "")
            {
                MessageBox.Show("Error! Select The Staff.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Staff set StaffName='" + EmpName.Text + "',StaffPhone='" + EmpPhone.Text + "',StaffGender='" + EmpGender.Text + "',StaffPass='" + EmpPass.Text + "' where StaffId=" + EmpKey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Updated!");
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

        private void EmpBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
