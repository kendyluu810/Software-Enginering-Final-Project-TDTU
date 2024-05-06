namespace GUI
{
    partial class staffManagement
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
            mainboard = new Panel();
            btnClear = new Button();
            btnPDF = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            grd = new DataGridView();
            gbStaffInfo = new GroupBox();
            cbGender = new ComboBox();
            btnUpload = new Button();
            cbRole = new ComboBox();
            cbStatus = new ComboBox();
            label10 = new Label();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            label9 = new Label();
            userIMG = new PictureBox();
            tbFullname = new TextBox();
            label8 = new Label();
            label4 = new Label();
            tbStaffID = new TextBox();
            tbPhonenumber = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            dob = new DateTimePicker();
            label6 = new Label();
            label1 = new Label();
            mainboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            gbStaffInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userIMG).BeginInit();
            SuspendLayout();
            // 
            // mainboard
            // 
            mainboard.BackColor = Color.FromArgb(242, 239, 229);
            mainboard.Controls.Add(btnClear);
            mainboard.Controls.Add(btnPDF);
            mainboard.Controls.Add(btnEdit);
            mainboard.Controls.Add(btnDel);
            mainboard.Controls.Add(btnAdd);
            mainboard.Controls.Add(btnSave);
            mainboard.Controls.Add(grd);
            mainboard.Controls.Add(gbStaffInfo);
            mainboard.Controls.Add(label1);
            mainboard.ForeColor = SystemColors.ActiveCaptionText;
            mainboard.Location = new Point(0, -4);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(1003, 605);
            mainboard.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(320, 553);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(420, 553);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(94, 29);
            btnPDF.TabIndex = 28;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(116, 553);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(220, 553);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 26;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 553);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(126, 99, 99);
            btnSave.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(872, 548);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 38);
            btnSave.TabIndex = 24;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // grd
            // 
            grd.BackgroundColor = SystemColors.ButtonHighlight;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(437, 52);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(551, 482);
            grd.TabIndex = 18;
            grd.CellClick += grd_CellClick;
            grd.CellContentClick += grd_CellContentClick;
            // 
            // gbStaffInfo
            // 
            gbStaffInfo.BackColor = Color.FromArgb(227, 225, 217);
            gbStaffInfo.Controls.Add(cbGender);
            gbStaffInfo.Controls.Add(btnUpload);
            gbStaffInfo.Controls.Add(cbRole);
            gbStaffInfo.Controls.Add(cbStatus);
            gbStaffInfo.Controls.Add(label10);
            gbStaffInfo.Controls.Add(tbPassword);
            gbStaffInfo.Controls.Add(tbUsername);
            gbStaffInfo.Controls.Add(label9);
            gbStaffInfo.Controls.Add(userIMG);
            gbStaffInfo.Controls.Add(tbFullname);
            gbStaffInfo.Controls.Add(label8);
            gbStaffInfo.Controls.Add(label4);
            gbStaffInfo.Controls.Add(tbStaffID);
            gbStaffInfo.Controls.Add(tbPhonenumber);
            gbStaffInfo.Controls.Add(label3);
            gbStaffInfo.Controls.Add(label7);
            gbStaffInfo.Controls.Add(label5);
            gbStaffInfo.Controls.Add(label2);
            gbStaffInfo.Controls.Add(dob);
            gbStaffInfo.Controls.Add(label6);
            gbStaffInfo.Location = new Point(12, 52);
            gbStaffInfo.Name = "gbStaffInfo";
            gbStaffInfo.Size = new Size(419, 482);
            gbStaffInfo.TabIndex = 17;
            gbStaffInfo.TabStop = false;
            gbStaffInfo.Enter += gbStaffInfo_Enter;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(24, 249);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(157, 28);
            cbGender.TabIndex = 26;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(126, 99, 99);
            btnUpload.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.Transparent;
            btnUpload.Location = new Point(151, 124);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(86, 38);
            btnUpload.TabIndex = 25;
            btnUpload.Text = "upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(22, 372);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(176, 28);
            cbRole.TabIndex = 23;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(208, 372);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(169, 28);
            cbStatus.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(208, 410);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 21;
            label10.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(208, 433);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(170, 27);
            tbPassword.TabIndex = 20;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(22, 433);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(179, 27);
            tbUsername.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 410);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 19;
            label9.Text = "username";
            // 
            // userIMG
            // 
            userIMG.BackColor = Color.White;
            userIMG.Location = new Point(140, 14);
            userIMG.Name = "userIMG";
            userIMG.Size = new Size(106, 104);
            userIMG.SizeMode = PictureBoxSizeMode.StretchImage;
            userIMG.TabIndex = 17;
            userIMG.TabStop = false;
            // 
            // tbFullname
            // 
            tbFullname.Location = new Point(22, 189);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new Size(257, 27);
            tbFullname.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(286, 166);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 16;
            label8.Text = "Staff ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 227);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 8;
            label4.Text = "DOB";
            // 
            // tbStaffID
            // 
            tbStaffID.Location = new Point(286, 189);
            tbStaffID.Name = "tbStaffID";
            tbStaffID.Size = new Size(91, 27);
            tbStaffID.TabIndex = 15;
            // 
            // tbPhonenumber
            // 
            tbPhonenumber.Location = new Point(22, 314);
            tbPhonenumber.Name = "tbPhonenumber";
            tbPhonenumber.Size = new Size(356, 27);
            tbPhonenumber.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 227);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(207, 349);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 14;
            label7.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 291);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 10;
            label5.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 166);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Full name";
            // 
            // dob
            // 
            dob.Location = new Point(187, 250);
            dob.Name = "dob";
            dob.Size = new Size(191, 27);
            dob.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 349);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 12;
            label6.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(199, 27);
            label1.TabIndex = 1;
            label1.Text = "Staff information";
            // 
            // staffManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(mainboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "staffManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            mainboard.ResumeLayout(false);
            mainboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            gbStaffInfo.ResumeLayout(false);
            gbStaffInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userIMG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainboard;
        private Label label1;
        private TextBox tbFullname;
        private Label label5;
        private TextBox tbPhonenumber;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private DateTimePicker dob;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label8;
        private TextBox tbStaffID;
        private Label label7;
        private Label label6;
        private DataGridView grd;
        private GroupBox gbStaffInfo;
        private Label label10;
        private TextBox tbPassword;
        private TextBox textBox7;
        private Label label9;
        private PictureBox userIMG;
        private TextBox tbUsername;
        private Button btnSave;
        private ComboBox comboBox2;
        private ComboBox cbStatus;
        private ComboBox cbRole;
        private Button btnPDF;
        private Button btnEdit;
        private Button btnDel;
        private Button btnAdd;
        private Button btnUpload;
        private ComboBox cbGender;
        private Button btnClear;
    }
}