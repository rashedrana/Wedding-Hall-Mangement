
namespace WeddingHall
{
    partial class Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.XCst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteCst = new System.Windows.Forms.Button();
            this.CstReset = new System.Windows.Forms.Button();
            this.AddCst = new System.Windows.Forms.Button();
            this.EditCst = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CstPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CstAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CstBack = new System.Windows.Forms.Button();
            this.CstDGV = new System.Windows.Forms.DataGridView();
            this.CstId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CstDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.XCst);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 56);
            this.panel1.TabIndex = 2;
            // 
            // XCst
            // 
            this.XCst.AutoSize = true;
            this.XCst.Font = new System.Drawing.Font("Poetsen One", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XCst.ForeColor = System.Drawing.SystemColors.Control;
            this.XCst.Location = new System.Drawing.Point(989, 6);
            this.XCst.Name = "XCst";
            this.XCst.Size = new System.Drawing.Size(38, 40);
            this.XCst.TabIndex = 5;
            this.XCst.Text = "X";
            this.XCst.Click += new System.EventHandler(this.XCst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poetsen One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer";
            // 
            // DeleteCst
            // 
            this.DeleteCst.BackColor = System.Drawing.Color.MediumOrchid;
            this.DeleteCst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteCst.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteCst.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteCst.Location = new System.Drawing.Point(548, 158);
            this.DeleteCst.Name = "DeleteCst";
            this.DeleteCst.Size = new System.Drawing.Size(198, 42);
            this.DeleteCst.TabIndex = 61;
            this.DeleteCst.Text = "Delete Customer";
            this.DeleteCst.UseVisualStyleBackColor = false;
            this.DeleteCst.Click += new System.EventHandler(this.DeleteCst_Click);
            // 
            // CstReset
            // 
            this.CstReset.BackColor = System.Drawing.Color.MediumOrchid;
            this.CstReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CstReset.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CstReset.ForeColor = System.Drawing.SystemColors.Control;
            this.CstReset.Location = new System.Drawing.Point(774, 158);
            this.CstReset.Name = "CstReset";
            this.CstReset.Size = new System.Drawing.Size(100, 42);
            this.CstReset.TabIndex = 60;
            this.CstReset.Text = "Reset";
            this.CstReset.UseVisualStyleBackColor = false;
            this.CstReset.Click += new System.EventHandler(this.CstReset_Click);
            // 
            // AddCst
            // 
            this.AddCst.BackColor = System.Drawing.Color.MediumOrchid;
            this.AddCst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCst.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCst.ForeColor = System.Drawing.SystemColors.Control;
            this.AddCst.Location = new System.Drawing.Point(144, 158);
            this.AddCst.Name = "AddCst";
            this.AddCst.Size = new System.Drawing.Size(178, 42);
            this.AddCst.TabIndex = 59;
            this.AddCst.Text = "Add Customer";
            this.AddCst.UseVisualStyleBackColor = false;
            this.AddCst.Click += new System.EventHandler(this.AddCst_Click);
            // 
            // EditCst
            // 
            this.EditCst.BackColor = System.Drawing.Color.MediumOrchid;
            this.EditCst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditCst.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditCst.ForeColor = System.Drawing.SystemColors.Control;
            this.EditCst.Location = new System.Drawing.Point(350, 158);
            this.EditCst.Name = "EditCst";
            this.EditCst.Size = new System.Drawing.Size(175, 42);
            this.EditCst.TabIndex = 58;
            this.EditCst.Text = "Edit Customer";
            this.EditCst.UseVisualStyleBackColor = false;
            this.EditCst.Click += new System.EventHandler(this.EditCst_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poetsen One", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label6.Location = new System.Drawing.Point(409, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 36);
            this.label6.TabIndex = 57;
            this.label6.Text = "Customer List";
            // 
            // CstPhone
            // 
            this.CstPhone.Font = new System.Drawing.Font("Poetsen One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CstPhone.Location = new System.Drawing.Point(766, 96);
            this.CstPhone.Name = "CstPhone";
            this.CstPhone.Size = new System.Drawing.Size(156, 31);
            this.CstPhone.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label5.Location = new System.Drawing.Point(665, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 34);
            this.label5.TabIndex = 55;
            this.label5.Text = "Phone";
            // 
            // CstAdd
            // 
            this.CstAdd.Font = new System.Drawing.Font("Poetsen One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CstAdd.Location = new System.Drawing.Point(435, 95);
            this.CstAdd.Name = "CstAdd";
            this.CstAdd.Size = new System.Drawing.Size(221, 31);
            this.CstAdd.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(311, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 53;
            this.label1.Text = "Address";
            // 
            // CstName
            // 
            this.CstName.Font = new System.Drawing.Font("Poetsen One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CstName.Location = new System.Drawing.Point(128, 94);
            this.CstName.Name = "CstName";
            this.CstName.Size = new System.Drawing.Size(177, 31);
            this.CstName.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label4.Location = new System.Drawing.Point(34, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 34);
            this.label4.TabIndex = 51;
            this.label4.Text = "Name";
            // 
            // CstBack
            // 
            this.CstBack.BackColor = System.Drawing.Color.MediumOrchid;
            this.CstBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CstBack.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CstBack.ForeColor = System.Drawing.SystemColors.Control;
            this.CstBack.Location = new System.Drawing.Point(465, 723);
            this.CstBack.Name = "CstBack";
            this.CstBack.Size = new System.Drawing.Size(103, 42);
            this.CstBack.TabIndex = 63;
            this.CstBack.Text = "Back";
            this.CstBack.UseVisualStyleBackColor = false;
            this.CstBack.Click += new System.EventHandler(this.CstBack_Click);
            // 
            // CstDGV
            // 
            this.CstDGV.AllowUserToAddRows = false;
            this.CstDGV.AllowUserToDeleteRows = false;
            this.CstDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CstDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CstDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CstId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.CstDGV.GridColor = System.Drawing.Color.MediumOrchid;
            this.CstDGV.Location = new System.Drawing.Point(58, 263);
            this.CstDGV.Name = "CstDGV";
            this.CstDGV.ReadOnly = true;
            this.CstDGV.RowHeadersWidth = 51;
            this.CstDGV.RowTemplate.Height = 29;
            this.CstDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CstDGV.Size = new System.Drawing.Size(915, 447);
            this.CstDGV.TabIndex = 62;
            this.CstDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CstDGV_CellContentClick);
            // 
            // CstId
            // 
            this.CstId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CstId.DataPropertyName = "CstId";
            this.CstId.HeaderText = "Customer ID";
            this.CstId.MinimumWidth = 6;
            this.CstId.Name = "CstId";
            this.CstId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CstName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CstAdd";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer Address";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CstPhone";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Phone";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 785);
            this.Controls.Add(this.CstBack);
            this.Controls.Add(this.CstDGV);
            this.Controls.Add(this.DeleteCst);
            this.Controls.Add(this.CstReset);
            this.Controls.Add(this.AddCst);
            this.Controls.Add(this.EditCst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CstPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CstAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CstDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label XCst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteCst;
        private System.Windows.Forms.Button CstReset;
        private System.Windows.Forms.Button AddCst;
        private System.Windows.Forms.Button EditCst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CstPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CstAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CstBack;
        private System.Windows.Forms.DataGridView CstDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CstId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}