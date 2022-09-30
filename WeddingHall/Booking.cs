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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rashe\OneDrive\Documents\WeddingDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            GetCstID();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Polao_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Polao_CheckStateChanged(object sender, EventArgs e)
        {
            if(Polao.Checked == true)
                {
                    PolaoPrice.Enabled = true;
                    PolaoQuantity.Enabled = true;
                }
            else
                {
                    PolaoPrice.Enabled = false;
                    PolaoQuantity.Enabled = false;
                    PolaoPrice.Text = "";
                    PolaoQuantity.Text = "";
                }
            
        }

        private void Beef_CheckStateChanged(object sender, EventArgs e)
        {
            if (Beef.Checked == true)
            {
                BeefPrice.Enabled = true;
                BeefQuantity.Enabled = true;
            }
            else
            {
                BeefPrice.Enabled = false;
                BeefQuantity.Enabled = false;
                BeefPrice.Text = "";
                BeefQuantity.Text = "";
            }
        }

        private void Mutton_CheckStateChanged(object sender, EventArgs e)
        {
            if (Mutton.Checked == true)
            {
                MuttonPrice.Enabled = true;
                MuttonQuantity.Enabled = true;
            }
            else
            {
                MuttonPrice.Enabled = false;
                MuttonQuantity.Enabled = false;
                MuttonPrice.Text = "";
                MuttonQuantity.Text = "";
            }
        }

        private void Roast_CheckStateChanged(object sender, EventArgs e)
        {
            if (Roast.Checked == true)
            {
                RoastPrice.Enabled = true;
                RoastQuantity.Enabled = true;
            }
            else
            {
                RoastPrice.Enabled = false;
                RoastQuantity.Enabled = false;
                RoastPrice.Text = "";
                RoastQuantity.Text = "";
            }
        }

        private void Zorda_CheckStateChanged(object sender, EventArgs e)
        {
            if (Zorda.Checked == true)
            {
                ZordaPrice.Enabled = true;
                ZordaQuantity.Enabled = true;
            }
            else
            {
                ZordaPrice.Enabled = false;
                ZordaQuantity.Enabled = false;
                ZordaPrice.Text = "";
                ZordaQuantity.Text = "";
            }
        }

        private void Borhani_CheckStateChanged(object sender, EventArgs e)
        {
            if (Borhani.Checked == true)
            {
                BorhaniPrice.Enabled = true;
                BorhaniQuantity.Enabled = true;
            }
            else
            {
                BorhaniPrice.Enabled = false;
                BorhaniQuantity.Enabled = false;
                BorhaniPrice.Text = "";
                BorhaniQuantity.Text = "";
            }
        }

        private void Water_CheckStateChanged(object sender, EventArgs e)
        {
            if (Water.Checked == true)
            {
                WaterPrice.Enabled = true;
                WaterQuantity.Enabled = true;
            }
            else
            {
                WaterPrice.Enabled = false;
                WaterQuantity.Enabled = false;
                WaterPrice.Text = "";
                WaterQuantity.Text = "";
            }
        }

        private void FriedRice_CheckStateChanged(object sender, EventArgs e)
        {
            if (FriedRice.Checked == true)
            {
                FriedRicePrice.Enabled = true;
                FriedRiceQuantity.Enabled = true;
            }
            else
            {
                FriedRicePrice.Enabled = false;
                FriedRiceQuantity.Enabled = false;
                FriedRicePrice.Text = "";
                FriedRiceQuantity.Text = "";
            }
        }

        private void BeefCurry_CheckStateChanged(object sender, EventArgs e)
        {
            if (BeefCurry.Checked == true)
            {
                BeefCurryPrice.Enabled = true;
                BeefCurryQuantity.Enabled = true;
            }
            else
            {
                BeefCurryPrice.Enabled = false;
                BeefCurryQuantity.Enabled = false;
                BeefCurryPrice.Text = "";
                BeefCurryQuantity.Text = "";
            }
        }

        private void FriedChicken_CheckStateChanged(object sender, EventArgs e)
        {
            if (FriedChicken.Checked == true)
            {
                FriedChickenPrice.Enabled = true;
                FriedChickenQuantity.Enabled = true;
            }
            else
            {
                FriedChickenPrice.Enabled = false;
                FriedChickenQuantity.Enabled = false;
                FriedChickenPrice.Text = "";
                FriedChickenQuantity.Text = "";
            }
        }

        private void PrawnCurry_CheckStateChanged(object sender, EventArgs e)
        {
            if (PrawnCurry.Checked == true)
            {
                PrawnCurryPrice.Enabled = true;
                PrawnCurryQuantity.Enabled = true;
            }
            else
            {
                PrawnCurryPrice.Enabled = false;
                PrawnCurryQuantity.Enabled = false;
                PrawnCurryPrice.Text = "";
                PrawnCurryQuantity.Text = "";
            }
        }

        private void Wonton_CheckStateChanged(object sender, EventArgs e)
        {
            if (Wonton.Checked == true)
            {
                WontonPrice.Enabled = true;
                WontonQuantity.Enabled = true;
            }
            else
            {
                WontonPrice.Enabled = false;
                WontonQuantity.Enabled = false;
                WontonPrice.Text = "";
                WontonQuantity.Text = "";
            }
        }

        private void ThaiSoup_CheckStateChanged(object sender, EventArgs e)
        {
            if (ThaiSoup.Checked == true)
            {
                ThaiSoupPrice.Enabled = true;
                ThaiSoupQuantity.Enabled = true;
            }
            else
            {
                ThaiSoupPrice.Enabled = false;
                ThaiSoupQuantity.Enabled = false;
                ThaiSoupPrice.Text = "";
                ThaiSoupQuantity.Text = "";
            }
        }

        private void SoftDrinks_CheckStateChanged(object sender, EventArgs e)
        {
            if (SoftDrinks.Checked == true)
            {
                SoftDrinksPrice.Enabled = true;
                SoftDrinksQuantity.Enabled = true;
            }
            else
            {
                SoftDrinksPrice.Enabled = false;
                SoftDrinksQuantity.Enabled = false;
                SoftDrinksPrice.Text = "";
                SoftDrinksQuantity.Text = "";
            }
        }
        int bdFoodCost = 0;
        private void BdFoodButton_Click(object sender, EventArgs e)
        {
            int polao=0, beef=0, mutton=0, roast=0, zorda=0, borhani=0, water=0;
            if(Polao.Checked == true && PolaoPrice.Text == "" && PolaoQuantity.Text == "")
            {
                MessageBox.Show("Enter Polao Quantity");
            }
            else
            {
                polao = Convert.ToInt32(PolaoPrice.Text) * Convert.ToInt32(PolaoQuantity.Text);
            }
            if (Beef.Checked == true && BeefPrice.Text == "" && BeefQuantity.Text == "")
            {
                MessageBox.Show("Enter Beef Quantity");
            }
            else
            {
                beef = Convert.ToInt32(BeefPrice.Text) * Convert.ToInt32(BeefQuantity.Text);
            }
            if (Mutton.Checked == true && MuttonPrice.Text == "" && MuttonQuantity.Text == "")
            {
                MessageBox.Show("Enter Mutton Quantity");
            }
            else
            {
                mutton = Convert.ToInt32(MuttonPrice.Text) * Convert.ToInt32(MuttonQuantity.Text);
            }
            if (Roast.Checked == true && RoastPrice.Text == "" && RoastPrice.Text == "")
            {
                MessageBox.Show("Enter Roast Quantity");
            }
            else
            {
                roast = Convert.ToInt32(RoastPrice.Text) * Convert.ToInt32(RoastQuantity.Text);
            }
            if (Zorda.Checked == true && ZordaPrice.Text == "" && ZordaQuantity.Text == "")
            {
                MessageBox.Show("Enter Zorda Quantity");
            }
            else
            {
                zorda = Convert.ToInt32(ZordaPrice.Text) * Convert.ToInt32(ZordaQuantity.Text);
            }
            if (Borhani.Checked == true && BorhaniPrice.Text == "" && BorhaniQuantity.Text == "")
            {
                MessageBox.Show("Enter Borhani Quantity");
            }
            else
            {
                borhani = Convert.ToInt32(BorhaniPrice.Text) * Convert.ToInt32(BorhaniQuantity.Text);
            }
            if (Water.Checked == true && WaterPrice.Text == "" && WaterQuantity.Text == "")
            {
                MessageBox.Show("Enter Water Quantity");
            }
            else
            {
                water = Convert.ToInt32(WaterPrice.Text) * Convert.ToInt32(WaterQuantity.Text);
            }
            bdFoodCost = polao + beef + mutton + roast + zorda + borhani + water;
            BdFoodCost.Text = "" + bdFoodCost;
        }

        int chnFoodCost = 0;
        private void ChnFoodButton_Click(object sender, EventArgs e)
        {
            int friedRice = 0, beefCurry = 0, friedChicken = 0, prawnCurry = 0, wonton = 0, thaiSoup = 0, softDrinks = 0;
            if (FriedRice.Checked == true && FriedRicePrice.Text == "" && FriedRiceQuantity.Text == "")
            {
                MessageBox.Show("Enter Fried Rice Quantity");
            }
            else
            {
                friedRice = Convert.ToInt32(FriedRicePrice.Text) * Convert.ToInt32(FriedRiceQuantity.Text);
            }
            if (BeefCurry.Checked == true && BeefCurryPrice.Text == "" && BeefCurryQuantity.Text == "")
            {
                MessageBox.Show("Enter Beef Curry Quantity");
            }
            else
            {
                beefCurry = Convert.ToInt32(BeefCurryPrice.Text) * Convert.ToInt32(BeefCurryQuantity.Text);
            }
            if (FriedChicken.Checked == true && FriedChickenPrice.Text == "" && FriedChickenQuantity.Text == "")
            {
                MessageBox.Show("Enter Fried Chicken Quantity");
            }
            else
            {
                friedChicken = Convert.ToInt32(FriedChickenPrice.Text) * Convert.ToInt32(FriedChickenQuantity.Text);
            }
            if (PrawnCurry.Checked == true && PrawnCurryPrice.Text == "" && PrawnCurryQuantity.Text == "")
            {
                MessageBox.Show("Enter Prawn Curry Quantity");
            }
            else
            {
                prawnCurry = Convert.ToInt32(PrawnCurryPrice.Text) * Convert.ToInt32(PrawnCurryQuantity.Text);
            }
            if (Wonton.Checked == true && WontonPrice.Text == "" && WontonQuantity.Text == "")
            {
                MessageBox.Show("Enter Wonton Quantity");
            }
            else
            {
                wonton = Convert.ToInt32(WontonPrice.Text) * Convert.ToInt32(WontonQuantity.Text);
            }
            if (ThaiSoup.Checked == true && ThaiSoupPrice.Text == "" && ThaiSoupQuantity.Text == "")
            {
                MessageBox.Show("Enter Thai Soup Quantity");
            }
            else
            {
                thaiSoup = Convert.ToInt32(ThaiSoupPrice.Text) * Convert.ToInt32(ThaiSoupQuantity.Text);
            }
            if (SoftDrinks.Checked == true && SoftDrinksPrice.Text == "" && SoftDrinksQuantity.Text == "")
            {
                MessageBox.Show("Enter Soft Drinks Quantity");
            }
            else
            {
                softDrinks = Convert.ToInt32(SoftDrinksPrice.Text) * Convert.ToInt32(SoftDrinksQuantity.Text);
            }
            chnFoodCost = friedRice + beefCurry + friedChicken + prawnCurry + wonton + thaiSoup + softDrinks;
            ChnFoodCost.Text = "" + chnFoodCost;
        }
        
        private void GetCstID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CstId from Customer", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CstId", typeof(string));
            dt.Load(rdr);
            CstIdCB.ValueMember = "CstId";
            CstIdCB.DataSource = dt;
            Con.Close();
        }
        private void fetchCstName()
        {
            Con.Open();
            string sql = "select * from Customer where CstId=" + CstIdCB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                CstNameBooking.Text = "" + dr["CstName"].ToString();
            }
            Con.Close();
        }
        private void CstIdCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCstName();
        }

        private void GrdTotal_TextChanged(object sender, EventArgs e)
        {
            GrdTotal.Text = (float.Parse(BookCharge.Text) + bdFoodCost + chnFoodCost).ToString();
        }

        private void Advance_TextChanged(object sender, EventArgs e)
        {
            Balance.Text = (float.Parse(GrdTotal.Text) - float.Parse(Advance.Text)).ToString();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from Booking";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            //ViewBookingDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void clear()
        {
            BookDate.Text = "";
            BookTime.Text = "";
            Guest.Text = "";
            CstIdCB.Text = "";
            BookCharge.Text = "";
            GrdTotal.Text = "";
            Advance.Text = "";
            Balance.Text = "";
        }
        private void AddBooking_Click(object sender, EventArgs e)
        {
            if (BookDate.Text == "" || BookTime.SelectedIndex == -1 || Guest.Text == "" || CstIdCB.SelectedIndex == -1 || BdFood.Text == "" || ChnFood.Text == "" || BdFoodCost.Text == "" || ChnFoodCost.Text == "" || BookCharge.Text == "" || GrdTotal.Text == "" || Advance.Text == "" || Balance.Text == "")
            {
                MessageBox.Show("Error! Add Booking Details.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Booking values ('" + BookDate.Text + "','" + BookTime.SelectedItem.ToString() + "','" + Guest.Text + "','" + CstIdCB.SelectedItem.ToString() + "','" + BdFood.Text + "','" + ChnFood.Text + "','" + BdFoodCost.Text + "','" + ChnFoodCost + "','" + BookCharge.Text + "','" + GrdTotal.Text + "','" + Advance.Text + "','" + Balance.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Successfully Added!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            ViewBooking view = new ViewBooking();
            view.Show();
            this.Hide();
        }
    }
}
