namespace GUI
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
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
            label1 = new Label();
            label2 = new Label();
            label = new Label();
            cbGender = new ComboBox();
            cbRole = new ComboBox();
            tbPhoneNumber = new TextBox();
            label3 = new Label();
            dob = new DateTimePicker();
            label5 = new Label();
            tbFullname = new TextBox();
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
            btnRegister.Location = new Point(625, 528);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(126, 56);
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
            ckbShowPass.Location = new Point(495, 495);
            ckbShowPass.Margin = new Padding(3, 4, 3, 4);
            ckbShowPass.Name = "ckbShowPass";
            ckbShowPass.Size = new Size(177, 26);
            ckbShowPass.TabIndex = 16;
            ckbShowPass.Text = "Show Password";
            ckbShowPass.UseVisualStyleBackColor = true;
            ckbShowPass.CheckedChanged += ckbShowPass_CheckedChanged;
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPass.Location = new Point(492, 385);
            tbPass.Margin = new Padding(3, 4, 3, 4);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(371, 30);
            tbPass.TabIndex = 15;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPass.ForeColor = Color.FromArgb(126, 99, 99);
            lbPass.Location = new Point(495, 359);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(100, 22);
            lbPass.TabIndex = 14;
            lbPass.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(492, 315);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(371, 30);
            tbUsername.TabIndex = 13;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUser.ForeColor = Color.FromArgb(126, 99, 99);
            lbUser.Location = new Point(492, 289);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(103, 22);
            lbUser.TabIndex = 12;
            lbUser.Text = "Username";
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignUp.ForeColor = Color.FromArgb(126, 99, 99);
            lbSignUp.Location = new Point(638, 27);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(113, 28);
            lbSignUp.TabIndex = 11;
            lbSignUp.Text = "SIGN UP";
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(862, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(22, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // tbCP
            // 
            tbCP.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCP.Location = new Point(492, 457);
            tbCP.Margin = new Padding(3, 4, 3, 4);
            tbCP.Name = "tbCP";
            tbCP.PasswordChar = '*';
            tbCP.Size = new Size(371, 30);
            tbCP.TabIndex = 19;
            // 
            // lbCP
            // 
            lbCP.AutoSize = true;
            lbCP.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCP.ForeColor = Color.FromArgb(126, 99, 99);
            lbCP.Location = new Point(492, 431);
            lbCP.Name = "lbCP";
            lbCP.Size = new Size(177, 22);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 615);
            panel1.TabIndex = 20;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(242, 239, 229);
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.FromArgb(126, 99, 99);
            btnSignIn.Location = new Point(89, 528);
            btnSignIn.Margin = new Padding(3, 4, 3, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(257, 56);
            btnSignIn.TabIndex = 18;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(457, 615);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(126, 99, 99);
            label1.Location = new Point(495, 54);
            label1.Name = "label1";
            label1.Size = new Size(97, 22);
            label1.TabIndex = 21;
            label1.Text = "Full name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(126, 99, 99);
            label2.Location = new Point(492, 169);
            label2.Name = "label2";
            label2.Size = new Size(51, 22);
            label2.TabIndex = 23;
            label2.Text = "Role";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(126, 99, 99);
            label.Location = new Point(683, 169);
            label.Name = "label";
            label.Size = new Size(78, 22);
            label.TabIndex = 25;
            label.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(683, 194);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(180, 28);
            cbGender.TabIndex = 27;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(495, 194);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(180, 28);
            cbRole.TabIndex = 28;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhoneNumber.Location = new Point(492, 255);
            tbPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(371, 30);
            tbPhoneNumber.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(126, 99, 99);
            label3.Location = new Point(492, 229);
            label3.Name = "label3";
            label3.Size = new Size(142, 22);
            label3.TabIndex = 30;
            label3.Text = "Phone number";
            // 
            // dob
            // 
            dob.Location = new Point(495, 139);
            dob.Name = "dob";
            dob.Size = new Size(368, 27);
            dob.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(126, 99, 99);
            label5.Location = new Point(492, 114);
            label5.Name = "label5";
            label5.Size = new Size(123, 22);
            label5.TabIndex = 33;
            label5.Text = "Date of birth";
            // 
            // tbFullname
            // 
            tbFullname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFullname.Location = new Point(492, 80);
            tbFullname.Margin = new Padding(3, 4, 3, 4);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new Size(371, 30);
            tbFullname.TabIndex = 22;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 229);
            ClientSize = new Size(896, 615);
            Controls.Add(label5);
            Controls.Add(dob);
            Controls.Add(label3);
            Controls.Add(tbPhoneNumber);
            Controls.Add(cbRole);
            Controls.Add(cbGender);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(tbFullname);
            Controls.Add(label1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += SignUp_Load;
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
        private Label label1;
        private Label label2;
        private Label label;
        private ComboBox cbGender;
        private ComboBox cbRole;
        private TextBox tbPhoneNumber;
        private Label label3;
        private DateTimePicker dob;
        private Label label5;
        private TextBox tbFullname;
        private Label label4;
    }
}