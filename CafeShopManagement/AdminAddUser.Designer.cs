namespace CafeShopManagement
{
    partial class AdminAddUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            panelRight = new Panel();
            label1 = new Label();
            AdminAddUser_Addbtn = new Button();
            AdminAddUser_Updatebtn = new Button();
            AdminAddUser_Clearbtn = new Button();
            AdminAddUser_Deletebtn = new Button();
            AdminAddUser_Export = new Button();
            panel1 = new Panel();
            cbStatus = new ComboBox();
            cbRole = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            tbPass = new TextBox();
            label3 = new Label();
            tbUsername = new TextBox();
            label2 = new Label();
            AdminAddUser_Uploadbtn = new Button();
            panel2 = new Panel();
            AdminAddUser_ImageView = new PictureBox();
            panelLeft = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelRight.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminAddUser_ImageView).BeginInit();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(126, 99, 99);
            label6.Location = new Point(45, 15);
            label6.Name = "label6";
            label6.Size = new Size(101, 22);
            label6.TabIndex = 15;
            label6.Text = "User Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(126, 99, 99);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(242, 239, 229);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(50, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(879, 500);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(dataGridView1);
            panelRight.Controls.Add(label6);
            panelRight.Dock = DockStyle.Right;
            panelRight.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelRight.Location = new Point(500, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(940, 710);
            panelRight.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(126, 99, 99);
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 0;
            label1.Text = "Add Users";
            // 
            // AdminAddUser_Addbtn
            // 
            AdminAddUser_Addbtn.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddUser_Addbtn.FlatStyle = FlatStyle.Flat;
            AdminAddUser_Addbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddUser_Addbtn.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddUser_Addbtn.Location = new Point(20, 572);
            AdminAddUser_Addbtn.Name = "AdminAddUser_Addbtn";
            AdminAddUser_Addbtn.Size = new Size(109, 35);
            AdminAddUser_Addbtn.TabIndex = 10;
            AdminAddUser_Addbtn.Text = "Add";
            AdminAddUser_Addbtn.UseVisualStyleBackColor = false;
            AdminAddUser_Addbtn.Click += AdminAddUser_Addbtn_Click;
            // 
            // AdminAddUser_Updatebtn
            // 
            AdminAddUser_Updatebtn.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddUser_Updatebtn.FlatStyle = FlatStyle.Flat;
            AdminAddUser_Updatebtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddUser_Updatebtn.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddUser_Updatebtn.Location = new Point(195, 572);
            AdminAddUser_Updatebtn.Name = "AdminAddUser_Updatebtn";
            AdminAddUser_Updatebtn.Size = new Size(109, 35);
            AdminAddUser_Updatebtn.TabIndex = 11;
            AdminAddUser_Updatebtn.Text = "Update";
            AdminAddUser_Updatebtn.UseVisualStyleBackColor = false;
            AdminAddUser_Updatebtn.Click += AdminAddUser_Updatebtn_Click;
            // 
            // AdminAddUser_Clearbtn
            // 
            AdminAddUser_Clearbtn.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddUser_Clearbtn.FlatStyle = FlatStyle.Flat;
            AdminAddUser_Clearbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddUser_Clearbtn.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddUser_Clearbtn.Location = new Point(370, 572);
            AdminAddUser_Clearbtn.Name = "AdminAddUser_Clearbtn";
            AdminAddUser_Clearbtn.Size = new Size(109, 35);
            AdminAddUser_Clearbtn.TabIndex = 12;
            AdminAddUser_Clearbtn.Text = "Clear";
            AdminAddUser_Clearbtn.UseVisualStyleBackColor = false;
            AdminAddUser_Clearbtn.Click += AdminAddUser_Clearbtn_Click;
            // 
            // AdminAddUser_Deletebtn
            // 
            AdminAddUser_Deletebtn.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddUser_Deletebtn.FlatStyle = FlatStyle.Flat;
            AdminAddUser_Deletebtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddUser_Deletebtn.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddUser_Deletebtn.Location = new Point(20, 624);
            AdminAddUser_Deletebtn.Name = "AdminAddUser_Deletebtn";
            AdminAddUser_Deletebtn.Size = new Size(109, 35);
            AdminAddUser_Deletebtn.TabIndex = 13;
            AdminAddUser_Deletebtn.Text = "Delete";
            AdminAddUser_Deletebtn.UseVisualStyleBackColor = false;
            AdminAddUser_Deletebtn.Click += AdminAddUser_Deletebtn_Click;
            // 
            // AdminAddUser_Export
            // 
            AdminAddUser_Export.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddUser_Export.FlatStyle = FlatStyle.Flat;
            AdminAddUser_Export.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddUser_Export.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddUser_Export.Location = new Point(195, 624);
            AdminAddUser_Export.Name = "AdminAddUser_Export";
            AdminAddUser_Export.Size = new Size(130, 35);
            AdminAddUser_Export.TabIndex = 14;
            AdminAddUser_Export.Text = "Export to CSV";
            AdminAddUser_Export.UseVisualStyleBackColor = false;
            AdminAddUser_Export.Click += AdminAddUser_Export_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(cbRole);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AdminAddUser_Uploadbtn);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(20, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 500);
            panel1.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Arial Rounded MT Bold", 12F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Active", "Inactive", "Approval" });
            cbStatus.Location = new Point(270, 423);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(153, 26);
            cbStatus.TabIndex = 9;
            // 
            // cbRole
            // 
            cbRole.Font = new Font("Arial Rounded MT Bold", 12F);
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Cashier" });
            cbRole.Location = new Point(49, 423);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(153, 26);
            cbRole.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(126, 99, 99);
            label5.Location = new Point(270, 390);
            label5.Name = "label5";
            label5.Size = new Size(60, 18);
            label5.TabIndex = 7;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(126, 99, 99);
            label4.Location = new Point(49, 390);
            label4.Name = "label4";
            label4.Size = new Size(44, 18);
            label4.TabIndex = 6;
            label4.Text = "Role";
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Arial Rounded MT Bold", 12F);
            tbPass.Location = new Point(49, 352);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(374, 26);
            tbPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(126, 99, 99);
            label3.Location = new Point(49, 320);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Arial Rounded MT Bold", 12F);
            tbUsername.Location = new Point(49, 287);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(374, 26);
            tbUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(126, 99, 99);
            label2.Location = new Point(49, 255);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // AdminAddUser_Uploadbtn
            // 
            AdminAddUser_Uploadbtn.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddUser_Uploadbtn.FlatStyle = FlatStyle.Flat;
            AdminAddUser_Uploadbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddUser_Uploadbtn.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddUser_Uploadbtn.Location = new Point(176, 191);
            AdminAddUser_Uploadbtn.Name = "AdminAddUser_Uploadbtn";
            AdminAddUser_Uploadbtn.Size = new Size(109, 35);
            AdminAddUser_Uploadbtn.TabIndex = 1;
            AdminAddUser_Uploadbtn.Text = "Upload";
            AdminAddUser_Uploadbtn.UseVisualStyleBackColor = false;
            AdminAddUser_Uploadbtn.Click += AdminAddUser_Uploadbtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(AdminAddUser_ImageView);
            panel2.Location = new Point(155, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 150);
            panel2.TabIndex = 0;
            // 
            // AdminAddUser_ImageView
            // 
            AdminAddUser_ImageView.BackColor = Color.Silver;
            AdminAddUser_ImageView.Dock = DockStyle.Fill;
            AdminAddUser_ImageView.Location = new Point(0, 0);
            AdminAddUser_ImageView.Name = "AdminAddUser_ImageView";
            AdminAddUser_ImageView.Size = new Size(150, 150);
            AdminAddUser_ImageView.SizeMode = PictureBoxSizeMode.StretchImage;
            AdminAddUser_ImageView.TabIndex = 0;
            AdminAddUser_ImageView.TabStop = false;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(panel1);
            panelLeft.Controls.Add(AdminAddUser_Export);
            panelLeft.Controls.Add(AdminAddUser_Deletebtn);
            panelLeft.Controls.Add(AdminAddUser_Clearbtn);
            panelLeft.Controls.Add(AdminAddUser_Updatebtn);
            panelLeft.Controls.Add(AdminAddUser_Addbtn);
            panelLeft.Controls.Add(label1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(500, 710);
            panelLeft.TabIndex = 2;
            // 
            // AdminAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 229);
            ClientSize = new Size(1440, 710);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminAddUser";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdminAddUser_ImageView).EndInit();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private DataGridView dataGridView1;
        private Panel panelRight;
        private Label label1;
        private Button AdminAddUser_Addbtn;
        private Button AdminAddUser_Updatebtn;
        private Button AdminAddUser_Clearbtn;
        private Button AdminAddUser_Deletebtn;
        private Button AdminAddUser_Export;
        private Panel panel1;
        private ComboBox cbStatus;
        private ComboBox cbRole;
        private Label label5;
        private Label label4;
        private TextBox tbPass;
        private Label label3;
        private TextBox tbUsername;
        private Label label2;
        private Button AdminAddUser_Uploadbtn;
        private Panel panel2;
        private PictureBox AdminAddUser_ImageView;
        private Panel panelLeft;
    }
}