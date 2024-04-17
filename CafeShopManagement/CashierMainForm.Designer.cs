﻿namespace CafeShopManagement
{
    partial class CashierMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainForm));
            panel1 = new Panel();
            btnCustomer = new Button();
            btnLogout = new Button();
            btnOrder = new Button();
            CashierMainForm_User = new Label();
            label1 = new Label();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            btnExit = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 239, 229);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(CashierMainForm_User);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 70);
            panel1.TabIndex = 1;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.FromArgb(126, 99, 99);
            btnCustomer.Location = new Point(802, 16);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(129, 38);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(126, 99, 99);
            btnLogout.Location = new Point(1015, 16);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 38);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnOrder
            // 
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.FromArgb(126, 99, 99);
            btnOrder.Location = new Point(562, 16);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(129, 38);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // CashierMainForm_User
            // 
            CashierMainForm_User.AutoSize = true;
            CashierMainForm_User.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierMainForm_User.ForeColor = Color.FromArgb(126, 99, 99);
            CashierMainForm_User.Location = new Point(1289, 27);
            CashierMainForm_User.Name = "CashierMainForm_User";
            CashierMainForm_User.Size = new Size(54, 17);
            CashierMainForm_User.TabIndex = 4;
            CashierMainForm_User.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(126, 99, 99);
            label1.Location = new Point(1188, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 18);
            label1.TabIndex = 3;
            label1.Text = "Welcome,";
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(126, 99, 99);
            btnDashboard.Location = new Point(322, 16);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(129, 38);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AUBERT_Logo;
            pictureBox1.Location = new Point(65, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1405, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(23, 24);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1440, 710);
            panel2.TabIndex = 2;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 229);
            ClientSize = new Size(1440, 780);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CashierMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCustomer;
        private Button btnLogout;
        private Button btnOrder;
        private Label CashierMainForm_User;
        private Label label1;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private Label btnExit;
        private Panel panel2;
    }
}