
namespace WeddingHall
{
    partial class AdminLogin
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
            this.XAdmin = new System.Windows.Forms.Label();
            this.XCst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.BackAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.XAdmin);
            this.panel1.Controls.Add(this.XCst);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 56);
            this.panel1.TabIndex = 3;
            // 
            // XAdmin
            // 
            this.XAdmin.AutoSize = true;
            this.XAdmin.Font = new System.Drawing.Font("Poetsen One", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.XAdmin.Location = new System.Drawing.Point(419, 8);
            this.XAdmin.Name = "XAdmin";
            this.XAdmin.Size = new System.Drawing.Size(38, 40);
            this.XAdmin.TabIndex = 6;
            this.XAdmin.Text = "X";
            this.XAdmin.Click += new System.EventHandler(this.XAdmin_Click);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poetsen One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin";
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.MediumOrchid;
            this.Log.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Log.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Log.ForeColor = System.Drawing.Color.Transparent;
            this.Log.Location = new System.Drawing.Point(186, 225);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(99, 40);
            this.Log.TabIndex = 8;
            this.Log.Text = "Login";
            this.Log.UseVisualStyleBackColor = false;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label3.Location = new System.Drawing.Point(61, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(186, 161);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(222, 30);
            this.Password.TabIndex = 6;
            // 
            // BackAdmin
            // 
            this.BackAdmin.BackColor = System.Drawing.Color.MediumOrchid;
            this.BackAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackAdmin.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackAdmin.ForeColor = System.Drawing.Color.White;
            this.BackAdmin.Location = new System.Drawing.Point(309, 225);
            this.BackAdmin.Name = "BackAdmin";
            this.BackAdmin.Size = new System.Drawing.Size(99, 40);
            this.BackAdmin.TabIndex = 9;
            this.BackAdmin.Text = "Back";
            this.BackAdmin.UseVisualStyleBackColor = false;
            this.BackAdmin.Click += new System.EventHandler(this.BackAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poetsen One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(61, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User.Location = new System.Drawing.Point(186, 98);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(222, 30);
            this.User.TabIndex = 10;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.BackAdmin);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label XCst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label XAdmin;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button BackAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User;
    }
}