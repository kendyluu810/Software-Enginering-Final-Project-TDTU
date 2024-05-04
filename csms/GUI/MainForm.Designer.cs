namespace GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainboard = new Panel();
            navbar = new Panel();
            button2 = new Button();
            btnDashboard = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            label_username = new Label();
            Logout = new PictureBox();
            label2 = new Label();
            btnMembership = new Button();
            btnProduct = new Button();
            btnStaff = new Button();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logout).BeginInit();
            SuspendLayout();
            // 
            // mainboard
            // 
            mainboard.BackColor = Color.FromArgb(242, 239, 229);
            mainboard.ForeColor = Color.Turquoise;
            mainboard.Location = new Point(0, 63);
            mainboard.Margin = new Padding(3, 2, 3, 2);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(878, 500);
            mainboard.TabIndex = 0;
            mainboard.Paint += mainboard_Paint;
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(227, 225, 217);
            navbar.Controls.Add(button2);
            navbar.Controls.Add(btnDashboard);
            navbar.Controls.Add(button1);
            navbar.Controls.Add(pictureBox1);
            navbar.Controls.Add(btnExit);
            navbar.Controls.Add(label_username);
            navbar.Controls.Add(Logout);
            navbar.Controls.Add(label2);
            navbar.Controls.Add(btnMembership);
            navbar.Controls.Add(btnProduct);
            navbar.Controls.Add(btnStaff);
            navbar.Location = new Point(0, 0);
            navbar.Margin = new Padding(3, 2, 3, 2);
            navbar.Name = "navbar";
            navbar.Size = new Size(878, 66);
            navbar.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(624, 9);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(88, 38);
            button2.TabIndex = 6;
            button2.Text = "Receipt";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(160, 9);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(88, 38);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Home";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // button1
            // 
            button1.Location = new Point(531, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(88, 38);
            button1.TabIndex = 5;
            button1.Text = "Coupon";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(843, 3);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 22);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(790, 44);
            label_username.Name = "label_username";
            label_username.Size = new Size(38, 15);
            label_username.TabIndex = 0;
            label_username.Text = "label1";
            // 
            // Logout
            // 
            Logout.Image = (Image)resources.GetObject("Logout.Image");
            Logout.Location = new Point(842, 35);
            Logout.Margin = new Padding(3, 2, 3, 2);
            Logout.Name = "Logout";
            Logout.Size = new Size(22, 23);
            Logout.SizeMode = PictureBoxSizeMode.Zoom;
            Logout.TabIndex = 1;
            Logout.TabStop = false;
            Logout.Click += Logout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(724, 44);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Welcome, ";
            // 
            // btnMembership
            // 
            btnMembership.Location = new Point(439, 9);
            btnMembership.Margin = new Padding(3, 2, 3, 2);
            btnMembership.Name = "btnMembership";
            btnMembership.Size = new Size(88, 38);
            btnMembership.TabIndex = 4;
            btnMembership.Text = "Membership";
            btnMembership.UseVisualStyleBackColor = true;
            btnMembership.Click += btnMembership_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(346, 9);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(88, 38);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnStaff
            // 
            btnStaff.Location = new Point(253, 9);
            btnStaff.Margin = new Padding(3, 2, 3, 2);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(88, 38);
            btnStaff.TabIndex = 2;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 566);
            Controls.Add(mainboard);
            Controls.Add(navbar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainboard;
        private Panel navbar;
        private PictureBox pictureBox1;
        private Button btnStaff;
        private Button btnDashboard;
        private Label label_username;
        private Label label2;
        private Button btnMembership;
        private Button btnProduct;
        private PictureBox Logout;
        private Button btnExit;
        private Button button1;
        private Button button2;
    }
}