namespace CafeShopManagement
{
    partial class LoginForm
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
            label4 = new Label();
            pictureBox1 = new PictureBox();
            lbDHA = new Label();
            btnSignUp = new Button();
            btnExit = new Label();
            lbLogin = new Label();
            lbUser = new Label();
            tbUser = new TextBox();
            tbPass = new TextBox();
            lbPass = new Label();
            ckbShowPass = new CheckBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 122, 33);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbDHA);
            panel1.Controls.Add(btnSignUp);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 500);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(87, 223);
            label4.Name = "label4";
            label4.Size = new Size(227, 22);
            label4.TabIndex = 9;
            label4.Text = "Cafe Shop Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icon_the_coffee_house;
            pictureBox1.Location = new Point(140, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lbDHA
            // 
            lbDHA.AutoSize = true;
            lbDHA.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDHA.ForeColor = Color.White;
            lbDHA.Location = new Point(121, 403);
            lbDHA.Name = "lbDHA";
            lbDHA.Size = new Size(157, 17);
            lbDHA.TabIndex = 9;
            lbDHA.Text = "Don't have account?";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(224, 122, 33);
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(84, 433);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(230, 42);
            btnSignUp.TabIndex = 9;
            btnSignUp.Text = "Register";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(770, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(18, 18);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(440, 100);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(83, 22);
            lbLogin.TabIndex = 2;
            lbLogin.Text = "SIGN IN";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUser.Location = new Point(440, 151);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(83, 17);
            lbUser.TabIndex = 3;
            lbUser.Text = "Username";
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUser.Location = new Point(440, 171);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(325, 26);
            tbUser.TabIndex = 4;
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPass.Location = new Point(440, 243);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(325, 26);
            tbPass.TabIndex = 6;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPass.Location = new Point(440, 223);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(80, 17);
            lbPass.TabIndex = 5;
            lbPass.Text = "Password";
            // 
            // ckbShowPass
            // 
            ckbShowPass.AutoSize = true;
            ckbShowPass.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbShowPass.Location = new Point(440, 301);
            ckbShowPass.Name = "ckbShowPass";
            ckbShowPass.Size = new Size(143, 21);
            ckbShowPass.TabIndex = 7;
            ckbShowPass.Text = "Show Password";
            ckbShowPass.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(224, 122, 33);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(547, 346);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 42);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(btnLogin);
            Controls.Add(ckbShowPass);
            Controls.Add(tbPass);
            Controls.Add(lbPass);
            Controls.Add(tbUser);
            Controls.Add(lbUser);
            Controls.Add(lbLogin);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label btnExit;
        private Label lbLogin;
        private Label lbUser;
        private TextBox tbUser;
        private TextBox tbPass;
        private Label lbPass;
        private CheckBox ckbShowPass;
        private Button btnLogin;
        private Button btnSignUp;
        private Label lbDHA;
        private Label label4;
        private PictureBox pictureBox1;
    }
}