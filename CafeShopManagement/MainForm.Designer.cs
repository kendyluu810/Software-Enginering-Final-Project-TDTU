namespace CafeShopManagement
{
    partial class MainForm
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
            panel1 = new Panel();
            label1 = new Label();
            btnExit = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnEmployee = new Button();
            btnProducts = new Button();
            btnCashier = new Button();
            btnDashboard = new Button();
            tbUser = new Label();
            lbUser = new Label();
            lbAP = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(319, 18);
            label1.TabIndex = 3;
            label1.Text = "The Coffee House Management System";
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1410, 19);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(18, 18);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 122, 33);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnEmployee);
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnCashier);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(tbUser);
            panel2.Controls.Add(lbUser);
            panel2.Controls.Add(lbAP);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 730);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(25, 664);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 40);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Location = new Point(25, 445);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(200, 40);
            btnEmployee.TabIndex = 17;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(25, 385);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(200, 40);
            btnProducts.TabIndex = 16;
            btnProducts.Text = "Add Products";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnCashier
            // 
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCashier.ForeColor = Color.White;
            btnCashier.Location = new Point(25, 325);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(200, 40);
            btnCashier.TabIndex = 15;
            btnCashier.Text = "Add Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(25, 265);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 40);
            btnDashboard.TabIndex = 14;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // tbUser
            // 
            tbUser.AutoSize = true;
            tbUser.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUser.Location = new Point(136, 226);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(54, 17);
            tbUser.TabIndex = 13;
            tbUser.Text = "Admin";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUser.Location = new Point(30, 225);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(95, 18);
            lbUser.TabIndex = 12;
            lbUser.Text = "Username:";
            // 
            // lbAP
            // 
            lbAP.AutoSize = true;
            lbAP.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAP.Location = new Point(61, 180);
            lbAP.Name = "lbAP";
            lbAP.Size = new Size(129, 22);
            lbAP.TabIndex = 4;
            lbAP.Text = "Admin Portal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icon_the_coffee_house;
            pictureBox1.Location = new Point(65, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(1190, 730);
            panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 780);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label btnExit;
        private Label tbUser;
        private Label lbUser;
        private Label lbAP;
        private Button btnLogout;
        private Button btnEmployee;
        private Button btnProducts;
        private Button btnCashier;
        private Button btnDashboard;
        private Panel panel3;
    }
}