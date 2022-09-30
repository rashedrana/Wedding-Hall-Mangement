
namespace WeddingHall
{
    partial class Staff
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
            this.XEmp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpDGV = new System.Windows.Forms.DataGridView();
            this.StaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddEmp = new System.Windows.Forms.Button();
            this.EditEmp = new System.Windows.Forms.Button();
            this.DeleteEmp = new System.Windows.Forms.Button();
            this.EmpReset = new System.Windows.Forms.Button();
            this.EmpBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.XEmp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 56);
            this.panel1.TabIndex = 1;
            // 
            // XEmp
            // 
            this.XEmp.AutoSize = true;
            this.XEmp.Font = new System.Drawing.Font("Poetsen One", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.XEmp.Location = new System.Drawing.Point(989, 6);
            this.XEmp.Name = "XEmp";
            this.XEmp.Size = new System.Drawing.Size(38, 40);
            this.XEmp.TabIndex = 5;
            this.XEmp.Text = "X";
            this.XEmp.Click += new System.EventHandler(this.XEmp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poetsen One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Staff";
            // 
            // EmpName
            // 
            this.EmpName.Font = new System.Drawing.Font("Poetsen One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmpName.Location = new System.Drawing.Point(102, 92);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(156, 31);
            this.EmpName.TabIndex = 13;
            this.EmpName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // EmpGender
            // 
            this.EmpGender.Font = new System.Drawing.Font("Poetsen One", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpGender.FormattingEnabled = true;
            this.EmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGender.Location = new System.Drawing.Point(650, 95);
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.Size = new System.Drawing.Size(97, 30);
            this.EmpGender.TabIndex = 11;
            this.EmpGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label3.Location = new System.Drawing.Point(534, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gender";
            // 
            // EmpPhone
            // 
            this.EmpPhone.Font = new System.Drawing.Font("Poetsen One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmpPhone.Location = new System.Drawing.Point(367, 93);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.Size = new System.Drawing.Size(161, 31);
            this.EmpPhone.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(264, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phone";
            // 
            // EmpPass
            // 
            this.EmpPass.Font = new System.Drawing.Font("Poetsen One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmpPass.Location = new System.Drawing.Point(909, 95);
            this.EmpPass.Name = "EmpPass";
            this.EmpPass.PasswordChar = '*';
            this.EmpPass.Size = new System.Drawing.Size(103, 31);
            this.EmpPass.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label5.Location = new System.Drawing.Point(760, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poetsen One", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label6.Location = new System.Drawing.Point(443, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 36);
            this.label6.TabIndex = 44;
            this.label6.Text = "Staff List";
            // 
            // EmpDGV
            // 
            this.EmpDGV.AllowUserToAddRows = false;
            this.EmpDGV.AllowUserToDeleteRows = false;
            this.EmpDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffId,
            this.StaffName,
            this.StaffPhone,
            this.StaffGender,
            this.StaffPass});
            this.EmpDGV.GridColor = System.Drawing.Color.MediumOrchid;
            this.EmpDGV.Location = new System.Drawing.Point(54, 273);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.ReadOnly = true;
            this.EmpDGV.RowHeadersWidth = 51;
            this.EmpDGV.RowTemplate.Height = 29;
            this.EmpDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpDGV.Size = new System.Drawing.Size(923, 447);
            this.EmpDGV.TabIndex = 43;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // StaffId
            // 
            this.StaffId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffId.DataPropertyName = "StaffId";
            this.StaffId.HeaderText = "Staff ID";
            this.StaffId.MinimumWidth = 6;
            this.StaffId.Name = "StaffId";
            this.StaffId.ReadOnly = true;
            // 
            // StaffName
            // 
            this.StaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "Staff Name";
            this.StaffName.MinimumWidth = 6;
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // StaffPhone
            // 
            this.StaffPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffPhone.DataPropertyName = "StaffPhone";
            this.StaffPhone.HeaderText = "Staff Phone";
            this.StaffPhone.MinimumWidth = 6;
            this.StaffPhone.Name = "StaffPhone";
            this.StaffPhone.ReadOnly = true;
            // 
            // StaffGender
            // 
            this.StaffGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffGender.DataPropertyName = "StaffGender";
            this.StaffGender.HeaderText = "Staff Gender";
            this.StaffGender.MinimumWidth = 6;
            this.StaffGender.Name = "StaffGender";
            this.StaffGender.ReadOnly = true;
            // 
            // StaffPass
            // 
            this.StaffPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffPass.DataPropertyName = "StaffPass";
            this.StaffPass.HeaderText = "Staff Password";
            this.StaffPass.MinimumWidth = 6;
            this.StaffPass.Name = "StaffPass";
            this.StaffPass.ReadOnly = true;
            // 
            // AddEmp
            // 
            this.AddEmp.BackColor = System.Drawing.Color.MediumOrchid;
            this.AddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddEmp.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.AddEmp.Location = new System.Drawing.Point(170, 156);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(144, 42);
            this.AddEmp.TabIndex = 46;
            this.AddEmp.Text = "Add Staff";
            this.AddEmp.UseVisualStyleBackColor = false;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // EditEmp
            // 
            this.EditEmp.BackColor = System.Drawing.Color.MediumOrchid;
            this.EditEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditEmp.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.EditEmp.Location = new System.Drawing.Point(354, 156);
            this.EditEmp.Name = "EditEmp";
            this.EditEmp.Size = new System.Drawing.Size(137, 42);
            this.EditEmp.TabIndex = 45;
            this.EditEmp.Text = "Edit Staff";
            this.EditEmp.UseVisualStyleBackColor = false;
            this.EditEmp.Click += new System.EventHandler(this.EditEmp_Click);
            // 
            // DeleteEmp
            // 
            this.DeleteEmp.BackColor = System.Drawing.Color.MediumOrchid;
            this.DeleteEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteEmp.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteEmp.Location = new System.Drawing.Point(535, 156);
            this.DeleteEmp.Name = "DeleteEmp";
            this.DeleteEmp.Size = new System.Drawing.Size(145, 42);
            this.DeleteEmp.TabIndex = 48;
            this.DeleteEmp.Text = "Delete Staff";
            this.DeleteEmp.UseVisualStyleBackColor = false;
            this.DeleteEmp.Click += new System.EventHandler(this.button3_Click);
            // 
            // EmpReset
            // 
            this.EmpReset.BackColor = System.Drawing.Color.MediumOrchid;
            this.EmpReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmpReset.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpReset.ForeColor = System.Drawing.SystemColors.Control;
            this.EmpReset.Location = new System.Drawing.Point(724, 156);
            this.EmpReset.Name = "EmpReset";
            this.EmpReset.Size = new System.Drawing.Size(144, 42);
            this.EmpReset.TabIndex = 47;
            this.EmpReset.Text = "Reset";
            this.EmpReset.UseVisualStyleBackColor = false;
            this.EmpReset.Click += new System.EventHandler(this.EmpReset_Click);
            // 
            // EmpBack
            // 
            this.EmpBack.BackColor = System.Drawing.Color.MediumOrchid;
            this.EmpBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmpBack.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpBack.ForeColor = System.Drawing.SystemColors.Control;
            this.EmpBack.Location = new System.Drawing.Point(469, 731);
            this.EmpBack.Name = "EmpBack";
            this.EmpBack.Size = new System.Drawing.Size(103, 42);
            this.EmpBack.TabIndex = 51;
            this.EmpBack.Text = "Back";
            this.EmpBack.UseVisualStyleBackColor = false;
            this.EmpBack.Click += new System.EventHandler(this.EmpBack_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 785);
            this.Controls.Add(this.EmpBack);
            this.Controls.Add(this.DeleteEmp);
            this.Controls.Add(this.EmpReset);
            this.Controls.Add(this.AddEmp);
            this.Controls.Add(this.EditEmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmpDGV);
            this.Controls.Add(this.EmpPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmpPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmpGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label XEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EmpGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView EmpDGV;
        private System.Windows.Forms.Button AddEmp;
        private System.Windows.Forms.Button EditEmp;
        private System.Windows.Forms.Button DeleteEmp;
        private System.Windows.Forms.Button EmpReset;
        private System.Windows.Forms.Button EmpBack;
        private System.Windows.Forms.TextBox EmpPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPass;
    }
}