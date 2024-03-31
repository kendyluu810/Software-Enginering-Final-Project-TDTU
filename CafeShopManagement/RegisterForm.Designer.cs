namespace CafeShopManagement
{
    partial class RegisterForm
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
            btnRegister = new Button();
            ckbShowPass = new CheckBox();
            tbPass = new TextBox();
            lbPass = new Label();
            tbUsername = new TextBox();
            lbUser = new Label();
            lbSignUp = new Label();
            btnExit = new Label();
            tbCP = new TextBox();
            lbCP = new Label();
            panel1 = new Panel();
            btnSignIn = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(126, 99, 99);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(242, 239, 229);
            btnRegister.Location = new Point(545, 365);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 42);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // ckbShowPass
            // 
            ckbShowPass.AutoSize = true;
            ckbShowPass.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbShowPass.ForeColor = Color.FromArgb(126, 99, 99);
            ckbShowPass.Location = new Point(438, 320);
            ckbShowPass.Name = "ckbShowPass";
            ckbShowPass.Size = new Size(143, 21);
            ckbShowPass.TabIndex = 16;
            ckbShowPass.Text = "Show Password";
            ckbShowPass.UseVisualStyleBackColor = true;
            ckbShowPass.CheckedChanged += ckbShowPass_CheckedChanged;
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPass.Location = new Point(438, 218);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(325, 26);
            tbPass.TabIndex = 15;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPass.ForeColor = Color.FromArgb(126, 99, 99);
            lbPass.Location = new Point(438, 192);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(80, 17);
            lbPass.TabIndex = 14;
            lbPass.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(438, 157);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(325, 26);
            tbUsername.TabIndex = 13;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUser.ForeColor = Color.FromArgb(126, 99, 99);
            lbUser.Location = new Point(438, 131);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(83, 17);
            lbUser.TabIndex = 12;
            lbUser.Text = "Username";
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignUp.ForeColor = Color.FromArgb(126, 99, 99);
            lbSignUp.Location = new Point(438, 80);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(90, 22);
            lbSignUp.TabIndex = 11;
            lbSignUp.Text = "SIGN UP";
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(754, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(18, 18);
            btnExit.TabIndex = 10;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // tbCP
            // 
            tbCP.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCP.Location = new Point(438, 279);
            tbCP.Name = "tbCP";
            tbCP.PasswordChar = '*';
            tbCP.Size = new Size(325, 26);
            tbCP.TabIndex = 19;
            // 
            // lbCP
            // 
            lbCP.AutoSize = true;
            lbCP.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCP.ForeColor = Color.FromArgb(126, 99, 99);
            lbCP.Location = new Point(438, 253);
            lbCP.Name = "lbCP";
            lbCP.Size = new Size(142, 17);
            lbCP.TabIndex = 18;
            lbCP.Text = "Confirm Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(126, 99, 99);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 461);
            panel1.TabIndex = 20;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(242, 239, 229);
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.FromArgb(126, 99, 99);
            btnSignIn.Location = new Point(145, 396);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(110, 42);
            btnSignIn.TabIndex = 18;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.AUBERT;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 229);
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            Controls.Add(tbCP);
            Controls.Add(lbCP);
            Controls.Add(btnRegister);
            Controls.Add(ckbShowPass);
            Controls.Add(tbPass);
            Controls.Add(lbPass);
            Controls.Add(tbUsername);
            Controls.Add(lbUser);
            Controls.Add(lbSignUp);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnExit;
        private Label lbUser;
        private Label lbPass;
        private Label lbCP;
        private TextBox tbUsername;
        private TextBox tbPass;
        private TextBox tbCP;
        private CheckBox ckbShowPass;
        private Button btnRegister;
        private Label lbSignUp;
        private Panel panel1;
        private Button btnSignIn;
        private PictureBox pictureBox1;
    }
}