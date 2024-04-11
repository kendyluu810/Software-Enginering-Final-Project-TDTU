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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnExit = new Label();
            lbLogin = new Label();
            lbUser = new Label();
            tbUser = new TextBox();
            tbPass = new TextBox();
            lbPass = new Label();
            ckbShowPass = new CheckBox();
            btnLogin = new Button();
            panel1 = new Panel();
            btnSignUp = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            lbLogin.ForeColor = Color.FromArgb(126, 99, 99);
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
            lbUser.ForeColor = Color.FromArgb(126, 99, 99);
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
            lbPass.ForeColor = Color.FromArgb(126, 99, 99);
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
            ckbShowPass.ForeColor = Color.FromArgb(126, 99, 99);
            ckbShowPass.Location = new Point(440, 301);
            ckbShowPass.Name = "ckbShowPass";
            ckbShowPass.Size = new Size(143, 21);
            ckbShowPass.TabIndex = 7;
            ckbShowPass.Text = "Show Password";
            ckbShowPass.UseVisualStyleBackColor = true;
            ckbShowPass.CheckedChanged += ckbShowPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(242, 239, 229);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(126, 99, 99);
            btnLogin.Location = new Point(547, 346);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 42);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(126, 99, 99);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 500);
            panel1.TabIndex = 9;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(242, 239, 229);
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.FromArgb(126, 99, 99);
            btnSignUp.Location = new Point(104, 427);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(192, 42);
            btnSignUp.TabIndex = 10;
            btnSignUp.Text = "Create An Account";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.AUBERT;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 229);
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(ckbShowPass);
            Controls.Add(tbPass);
            Controls.Add(lbPass);
            Controls.Add(tbUser);
            Controls.Add(lbUser);
            Controls.Add(lbLogin);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnExit;
        private Label lbLogin;
        private Label lbUser;
        private TextBox tbUser;
        private TextBox tbPass;
        private Label lbPass;
        private CheckBox ckbShowPass;
        private Button btnLogin;
        private Panel panel1;
        private Button btnSignUp;
        private PictureBox pictureBox1;
    }
}