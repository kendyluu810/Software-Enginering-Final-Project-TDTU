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
            mainboard.Location = new Point(0, -3);
            mainboard.Margin = new Padding(3, 2, 3, 2);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(878, 500);
            mainboard.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(280, 451);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(368, 451);
            btnPDF.Margin = new Padding(3, 2, 3, 2);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(82, 22);
            btnPDF.TabIndex = 28;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(102, 451);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(192, 451);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(82, 22);
            btnDel.TabIndex = 26;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(11, 451);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
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
            btnSave.Location = new Point(763, 447);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 28);
            btnSave.TabIndex = 24;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // grd
            // 
            grd.BackgroundColor = SystemColors.ButtonHighlight;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(382, 39);
            grd.Margin = new Padding(3, 2, 3, 2);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(482, 385);
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
            gbStaffInfo.Location = new Point(10, 39);
            gbStaffInfo.Margin = new Padding(3, 2, 3, 2);
            gbStaffInfo.Name = "gbStaffInfo";
            gbStaffInfo.Padding = new Padding(3, 2, 3, 2);
            gbStaffInfo.Size = new Size(367, 385);
            gbStaffInfo.TabIndex = 17;
            gbStaffInfo.TabStop = false;
            gbStaffInfo.Enter += gbStaffInfo_Enter;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(21, 193);
            cbGender.Margin = new Padding(3, 2, 3, 2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(138, 23);
            cbGender.TabIndex = 26;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(126, 99, 99);
            btnUpload.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.Transparent;
            btnUpload.Location = new Point(132, 93);
            btnUpload.Margin = new Padding(3, 2, 3, 2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 28);
            btnUpload.TabIndex = 25;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(19, 290);
            cbRole.Margin = new Padding(3, 2, 3, 2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(154, 23);
            cbRole.TabIndex = 23;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(182, 290);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(148, 23);
            cbStatus.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(182, 322);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 21;
            label10.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(182, 339);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(149, 23);
            tbPassword.TabIndex = 20;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(19, 339);
            tbUsername.Margin = new Padding(3, 2, 3, 2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(157, 23);
            tbUsername.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 322);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 19;
            label9.Text = "username";
            // 
            // userIMG
            // 
            userIMG.BackColor = Color.White;
            userIMG.Location = new Point(122, 10);
            userIMG.Margin = new Padding(3, 2, 3, 2);
            userIMG.Name = "userIMG";
            userIMG.Size = new Size(93, 78);
            userIMG.SizeMode = PictureBoxSizeMode.StretchImage;
            userIMG.TabIndex = 17;
            userIMG.TabStop = false;
            // 
            // tbFullname
            // 
            tbFullname.Location = new Point(19, 153);
            tbFullname.Margin = new Padding(3, 2, 3, 2);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new Size(225, 23);
            tbFullname.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(250, 135);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 16;
            label8.Text = "Staff ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 176);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "DOB";
            // 
            // tbStaffID
            // 
            tbStaffID.Location = new Point(250, 153);
            tbStaffID.Margin = new Padding(3, 2, 3, 2);
            tbStaffID.Name = "tbStaffID";
            tbStaffID.Size = new Size(80, 23);
            tbStaffID.TabIndex = 15;
            // 
            // tbPhonenumber
            // 
            tbPhonenumber.Location = new Point(19, 242);
            tbPhonenumber.Margin = new Padding(3, 2, 3, 2);
            tbPhonenumber.Name = "tbPhonenumber";
            tbPhonenumber.Size = new Size(312, 23);
            tbPhonenumber.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 176);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(181, 273);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 14;
            label7.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 224);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 10;
            label5.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 135);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Full name";
            // 
            // dob
            // 
            dob.Location = new Point(164, 194);
            dob.Margin = new Padding(3, 2, 3, 2);
            dob.Name = "dob";
            dob.Size = new Size(168, 23);
            dob.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 273);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 12;
            label6.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(161, 22);
            label1.TabIndex = 1;
            label1.Text = "Staff information";
            // 
            // staffManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 500);
            Controls.Add(mainboard);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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