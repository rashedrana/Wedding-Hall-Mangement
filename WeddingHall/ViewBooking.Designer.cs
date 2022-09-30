
namespace WeddingHall
{
    partial class ViewBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.XViewBooking = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewBookingDGV = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BdFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChnFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostBdFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostChnFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Advance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBookingBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBookingDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.XViewBooking);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 56);
            this.panel1.TabIndex = 1;
            // 
            // XViewBooking
            // 
            this.XViewBooking.AutoSize = true;
            this.XViewBooking.Font = new System.Drawing.Font("Poetsen One", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XViewBooking.ForeColor = System.Drawing.SystemColors.Control;
            this.XViewBooking.Location = new System.Drawing.Point(989, 6);
            this.XViewBooking.Name = "XViewBooking";
            this.XViewBooking.Size = new System.Drawing.Size(38, 40);
            this.XViewBooking.TabIndex = 5;
            this.XViewBooking.Text = "X";
            this.XViewBooking.Click += new System.EventHandler(this.XViewBooking_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poetsen One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "View Booking";
            // 
            // ViewBookingDGV
            // 
            this.ViewBookingDGV.AllowUserToAddRows = false;
            this.ViewBookingDGV.AllowUserToDeleteRows = false;
            this.ViewBookingDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ViewBookingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewBookingDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.BookDate,
            this.BookTime,
            this.CstName,
            this.Guest,
            this.BdFood,
            this.ChnFood,
            this.CostBdFood,
            this.CostChnFood,
            this.BookCharge,
            this.GrdTotal,
            this.Advance,
            this.Balance});
            this.ViewBookingDGV.GridColor = System.Drawing.Color.MediumOrchid;
            this.ViewBookingDGV.Location = new System.Drawing.Point(0, 141);
            this.ViewBookingDGV.Name = "ViewBookingDGV";
            this.ViewBookingDGV.ReadOnly = true;
            this.ViewBookingDGV.RowHeadersWidth = 51;
            this.ViewBookingDGV.RowTemplate.Height = 29;
            this.ViewBookingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewBookingDGV.Size = new System.Drawing.Size(1031, 570);
            this.ViewBookingDGV.TabIndex = 2;
            this.ViewBookingDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "Book ID";
            this.BookId.MinimumWidth = 6;
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Width = 125;
            // 
            // BookDate
            // 
            this.BookDate.DataPropertyName = "BookDate";
            this.BookDate.HeaderText = "Book Date";
            this.BookDate.MinimumWidth = 6;
            this.BookDate.Name = "BookDate";
            this.BookDate.ReadOnly = true;
            this.BookDate.Width = 125;
            // 
            // BookTime
            // 
            this.BookTime.DataPropertyName = "BookTime";
            this.BookTime.HeaderText = "Book Time";
            this.BookTime.MinimumWidth = 6;
            this.BookTime.Name = "BookTime";
            this.BookTime.ReadOnly = true;
            this.BookTime.Width = 125;
            // 
            // CstName
            // 
            this.CstName.DataPropertyName = "CstName";
            this.CstName.HeaderText = "Customer Name";
            this.CstName.MinimumWidth = 6;
            this.CstName.Name = "CstName";
            this.CstName.ReadOnly = true;
            this.CstName.Width = 125;
            // 
            // Guest
            // 
            this.Guest.DataPropertyName = "Guest";
            this.Guest.HeaderText = "No. of Guests";
            this.Guest.MinimumWidth = 6;
            this.Guest.Name = "Guest";
            this.Guest.ReadOnly = true;
            this.Guest.Width = 125;
            // 
            // BdFood
            // 
            this.BdFood.DataPropertyName = "BdFood";
            this.BdFood.HeaderText = "Bangladeshi Food";
            this.BdFood.MinimumWidth = 6;
            this.BdFood.Name = "BdFood";
            this.BdFood.ReadOnly = true;
            this.BdFood.Width = 125;
            // 
            // ChnFood
            // 
            this.ChnFood.DataPropertyName = "ChnFood";
            this.ChnFood.HeaderText = "Chinese Food";
            this.ChnFood.MinimumWidth = 6;
            this.ChnFood.Name = "ChnFood";
            this.ChnFood.ReadOnly = true;
            this.ChnFood.Width = 125;
            // 
            // CostBdFood
            // 
            this.CostBdFood.DataPropertyName = "CostBdFood";
            this.CostBdFood.HeaderText = "Cost of Bangladeshi Food";
            this.CostBdFood.MinimumWidth = 6;
            this.CostBdFood.Name = "CostBdFood";
            this.CostBdFood.ReadOnly = true;
            this.CostBdFood.Width = 125;
            // 
            // CostChnFood
            // 
            this.CostChnFood.DataPropertyName = "CostChnFood";
            this.CostChnFood.HeaderText = "Cost of Chinese Food";
            this.CostChnFood.MinimumWidth = 6;
            this.CostChnFood.Name = "CostChnFood";
            this.CostChnFood.ReadOnly = true;
            this.CostChnFood.Width = 125;
            // 
            // BookCharge
            // 
            this.BookCharge.DataPropertyName = "BookCharge";
            this.BookCharge.HeaderText = "Booking Charge";
            this.BookCharge.MinimumWidth = 6;
            this.BookCharge.Name = "BookCharge";
            this.BookCharge.ReadOnly = true;
            this.BookCharge.Width = 125;
            // 
            // GrdTotal
            // 
            this.GrdTotal.DataPropertyName = "GrdTotal";
            this.GrdTotal.HeaderText = "Grand Total";
            this.GrdTotal.MinimumWidth = 6;
            this.GrdTotal.Name = "GrdTotal";
            this.GrdTotal.ReadOnly = true;
            this.GrdTotal.Width = 125;
            // 
            // Advance
            // 
            this.Advance.DataPropertyName = "Advance";
            this.Advance.HeaderText = "Advance";
            this.Advance.MinimumWidth = 6;
            this.Advance.Name = "Advance";
            this.Advance.ReadOnly = true;
            this.Advance.Width = 125;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.MinimumWidth = 6;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 125;
            // 
            // ViewBookingBack
            // 
            this.ViewBookingBack.BackColor = System.Drawing.Color.MediumOrchid;
            this.ViewBookingBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewBookingBack.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewBookingBack.ForeColor = System.Drawing.SystemColors.Control;
            this.ViewBookingBack.Location = new System.Drawing.Point(472, 731);
            this.ViewBookingBack.Name = "ViewBookingBack";
            this.ViewBookingBack.Size = new System.Drawing.Size(91, 42);
            this.ViewBookingBack.TabIndex = 40;
            this.ViewBookingBack.Text = "Back";
            this.ViewBookingBack.UseVisualStyleBackColor = false;
            this.ViewBookingBack.Click += new System.EventHandler(this.ViewBookingBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poetsen One", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label4.Location = new System.Drawing.Point(390, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 40);
            this.label4.TabIndex = 42;
            this.label4.Text = "Booking List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 785);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ViewBookingBack);
            this.Controls.Add(this.ViewBookingDGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ViewBooking_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBookingDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label XViewBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ViewBookingDGV;
        private System.Windows.Forms.Button ViewBookingBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guest;
        private System.Windows.Forms.DataGridViewTextBoxColumn BdFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChnFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostBdFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostChnFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrdTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Advance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}