namespace CafeShopManagement
{
    partial class AdminAddProducts
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
            cbStatus = new ComboBox();
            label5 = new Label();
            tbPrice = new TextBox();
            label7 = new Label();
            tbStock = new TextBox();
            label8 = new Label();
            label4 = new Label();
            tbPName = new TextBox();
            label3 = new Label();
            tbPID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            AdminAddProduct_ImageView = new PictureBox();
            cbType = new ComboBox();
            AdminAddProduct_Export = new Button();
            AdminAddProduct_Deletebtn = new Button();
            AdminAddProduct_Clearbtn = new Button();
            AdminAddProduct_Updatebtn = new Button();
            AdminAddProduct_Addbtn = new Button();
            AdminAddProduct_Uploadbtn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)AdminAddProduct_ImageView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Available", "Out of Stock" });
            cbStatus.Location = new Point(587, 218);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(250, 23);
            cbStatus.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(126, 99, 99);
            label5.Location = new Point(587, 187);
            label5.Name = "label5";
            label5.Size = new Size(60, 18);
            label5.TabIndex = 29;
            label5.Text = "Status";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(587, 151);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(250, 23);
            tbPrice.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(126, 99, 99);
            label7.Location = new Point(587, 120);
            label7.Name = "label7";
            label7.Size = new Size(101, 18);
            label7.TabIndex = 27;
            label7.Text = "Price (VND)";
            // 
            // tbStock
            // 
            tbStock.Location = new Point(587, 84);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(250, 23);
            tbStock.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(126, 99, 99);
            label8.Location = new Point(587, 53);
            label8.Name = "label8";
            label8.Size = new Size(54, 18);
            label8.TabIndex = 25;
            label8.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(126, 99, 99);
            label4.Location = new Point(154, 187);
            label4.Name = "label4";
            label4.Size = new Size(47, 18);
            label4.TabIndex = 23;
            label4.Text = "Type";
            // 
            // tbPName
            // 
            tbPName.Location = new Point(154, 151);
            tbPName.Name = "tbPName";
            tbPName.Size = new Size(250, 23);
            tbPName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(126, 99, 99);
            label3.Location = new Point(154, 120);
            label3.Name = "label3";
            label3.Size = new Size(122, 18);
            label3.TabIndex = 21;
            label3.Text = "Product Name";
            // 
            // tbPID
            // 
            tbPID.Location = new Point(154, 84);
            tbPID.Name = "tbPID";
            tbPID.Size = new Size(250, 23);
            tbPID.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(126, 99, 99);
            label2.Location = new Point(154, 53);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 19;
            label2.Text = "Product ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(126, 99, 99);
            label1.Location = new Point(27, 15);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 18;
            label1.Text = "Add Product";
            // 
            // AdminAddProduct_ImageView
            // 
            AdminAddProduct_ImageView.BackColor = Color.Silver;
            AdminAddProduct_ImageView.Dock = DockStyle.Fill;
            AdminAddProduct_ImageView.Location = new Point(0, 0);
            AdminAddProduct_ImageView.Name = "AdminAddProduct_ImageView";
            AdminAddProduct_ImageView.Size = new Size(150, 150);
            AdminAddProduct_ImageView.SizeMode = PictureBoxSizeMode.StretchImage;
            AdminAddProduct_ImageView.TabIndex = 0;
            AdminAddProduct_ImageView.TabStop = false;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Bakes", "Drink" });
            cbType.Location = new Point(154, 218);
            cbType.Name = "cbType";
            cbType.Size = new Size(250, 23);
            cbType.TabIndex = 38;
            // 
            // AdminAddProduct_Export
            // 
            AdminAddProduct_Export.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddProduct_Export.FlatStyle = FlatStyle.Flat;
            AdminAddProduct_Export.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddProduct_Export.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddProduct_Export.Location = new Point(896, 275);
            AdminAddProduct_Export.Name = "AdminAddProduct_Export";
            AdminAddProduct_Export.Size = new Size(130, 35);
            AdminAddProduct_Export.TabIndex = 37;
            AdminAddProduct_Export.Text = "Export to CSV";
            AdminAddProduct_Export.UseVisualStyleBackColor = false;
            AdminAddProduct_Export.Click += AdminAddProduct_Export_Click;
            // 
            // AdminAddProduct_Deletebtn
            // 
            AdminAddProduct_Deletebtn.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddProduct_Deletebtn.FlatStyle = FlatStyle.Flat;
            AdminAddProduct_Deletebtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddProduct_Deletebtn.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddProduct_Deletebtn.Location = new Point(510, 275);
            AdminAddProduct_Deletebtn.Name = "AdminAddProduct_Deletebtn";
            AdminAddProduct_Deletebtn.Size = new Size(109, 35);
            AdminAddProduct_Deletebtn.TabIndex = 36;
            AdminAddProduct_Deletebtn.Text = "Delete";
            AdminAddProduct_Deletebtn.UseVisualStyleBackColor = false;
            AdminAddProduct_Deletebtn.Click += AdminAddProduct_Deletebtn_Click;
            // 
            // AdminAddProduct_Clearbtn
            // 
            AdminAddProduct_Clearbtn.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddProduct_Clearbtn.FlatStyle = FlatStyle.Flat;
            AdminAddProduct_Clearbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddProduct_Clearbtn.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddProduct_Clearbtn.Location = new Point(703, 275);
            AdminAddProduct_Clearbtn.Name = "AdminAddProduct_Clearbtn";
            AdminAddProduct_Clearbtn.Size = new Size(109, 35);
            AdminAddProduct_Clearbtn.TabIndex = 35;
            AdminAddProduct_Clearbtn.Text = "Clear";
            AdminAddProduct_Clearbtn.UseVisualStyleBackColor = false;
            AdminAddProduct_Clearbtn.Click += AdminAddProduct_Clearbtn_Click;
            // 
            // AdminAddProduct_Updatebtn
            // 
            AdminAddProduct_Updatebtn.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddProduct_Updatebtn.FlatStyle = FlatStyle.Flat;
            AdminAddProduct_Updatebtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddProduct_Updatebtn.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddProduct_Updatebtn.Location = new Point(317, 275);
            AdminAddProduct_Updatebtn.Name = "AdminAddProduct_Updatebtn";
            AdminAddProduct_Updatebtn.Size = new Size(109, 35);
            AdminAddProduct_Updatebtn.TabIndex = 34;
            AdminAddProduct_Updatebtn.Text = "Update";
            AdminAddProduct_Updatebtn.UseVisualStyleBackColor = false;
            AdminAddProduct_Updatebtn.Click += AdminAddProduct_Updatebtn_Click;
            // 
            // AdminAddProduct_Addbtn
            // 
            AdminAddProduct_Addbtn.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddProduct_Addbtn.FlatStyle = FlatStyle.Flat;
            AdminAddProduct_Addbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddProduct_Addbtn.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddProduct_Addbtn.Location = new Point(124, 275);
            AdminAddProduct_Addbtn.Name = "AdminAddProduct_Addbtn";
            AdminAddProduct_Addbtn.Size = new Size(109, 35);
            AdminAddProduct_Addbtn.TabIndex = 33;
            AdminAddProduct_Addbtn.Text = "Add";
            AdminAddProduct_Addbtn.UseVisualStyleBackColor = false;
            AdminAddProduct_Addbtn.Click += AdminAddProduct_Addbtn_Click;
            // 
            // AdminAddProduct_Uploadbtn
            // 
            AdminAddProduct_Uploadbtn.BackColor = Color.FromArgb(126, 99, 99);
            AdminAddProduct_Uploadbtn.FlatStyle = FlatStyle.Flat;
            AdminAddProduct_Uploadbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminAddProduct_Uploadbtn.ForeColor = Color.FromArgb(242, 239, 229);
            AdminAddProduct_Uploadbtn.Location = new Point(1115, 171);
            AdminAddProduct_Uploadbtn.Name = "AdminAddProduct_Uploadbtn";
            AdminAddProduct_Uploadbtn.Size = new Size(110, 35);
            AdminAddProduct_Uploadbtn.TabIndex = 32;
            AdminAddProduct_Uploadbtn.Text = "Upload";
            AdminAddProduct_Uploadbtn.UseVisualStyleBackColor = false;
            AdminAddProduct_Uploadbtn.Click += AdminAddProduct_Uploadbtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbType);
            panel2.Controls.Add(AdminAddProduct_Export);
            panel2.Controls.Add(AdminAddProduct_Deletebtn);
            panel2.Controls.Add(AdminAddProduct_Clearbtn);
            panel2.Controls.Add(AdminAddProduct_Updatebtn);
            panel2.Controls.Add(AdminAddProduct_Addbtn);
            panel2.Controls.Add(AdminAddProduct_Uploadbtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(cbStatus);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tbPrice);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(tbStock);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tbPName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tbPID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 345);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 325);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(AdminAddProduct_ImageView);
            panel3.Location = new Point(1094, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 150);
            panel3.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(126, 99, 99);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(242, 239, 229);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(27, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1360, 264);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(126, 99, 99);
            label6.Location = new Point(27, 13);
            label6.Name = "label6";
            label6.Size = new Size(131, 22);
            label6.TabIndex = 16;
            label6.Text = "Product Data";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 325);
            panel1.TabIndex = 2;
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 229);
            ClientSize = new Size(1424, 671);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAddProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminAddProducts";
            ((System.ComponentModel.ISupportInitialize)AdminAddProduct_ImageView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbStatus;
        private Label label5;
        private TextBox tbPrice;
        private Label label7;
        private TextBox tbStock;
        private Label label8;
        private Label label4;
        private TextBox tbPName;
        private Label label3;
        private TextBox tbPID;
        private Label label2;
        private Label label1;
        private PictureBox AdminAddProduct_ImageView;
        private ComboBox cbType;
        private Button AdminAddProduct_Export;
        private Button AdminAddProduct_Deletebtn;
        private Button AdminAddProduct_Clearbtn;
        private Button AdminAddProduct_Updatebtn;
        private Button AdminAddProduct_Addbtn;
        private Button AdminAddProduct_Uploadbtn;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label label6;
        private Panel panel1;
    }
}