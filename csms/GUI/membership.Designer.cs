namespace GUI
{
    partial class membership
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
            label1 = new Label();
            btnClear = new Button();
            btnPDF = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            grd = new DataGridView();
            gb1 = new GroupBox();
            label5 = new Label();
            tbAccu = new TextBox();
            tbDiscount = new TextBox();
            label4 = new Label();
            tbRank = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbPhonenumber = new TextBox();
            label10 = new Label();
            tbID = new TextBox();
            label9 = new Label();
            tbName = new TextBox();
            mainboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // mainboard
            // 
            mainboard.BackColor = Color.FromArgb(242, 239, 229);
            mainboard.Controls.Add(label1);
            mainboard.Controls.Add(btnClear);
            mainboard.Controls.Add(btnPDF);
            mainboard.Controls.Add(btnEdit);
            mainboard.Controls.Add(btnDel);
            mainboard.Controls.Add(btnAdd);
            mainboard.Controls.Add(btnSave);
            mainboard.Controls.Add(grd);
            mainboard.Controls.Add(gb1);
            mainboard.ForeColor = SystemColors.ActiveCaptionText;
            mainboard.Location = new Point(0, -3);
            mainboard.Margin = new Padding(3, 2, 3, 2);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(878, 500);
            mainboard.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(231, 22);
            label1.TabIndex = 30;
            label1.Text = "Membership information";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(279, 171);
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
            btnPDF.Location = new Point(367, 171);
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
            btnEdit.Location = new Point(101, 171);
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
            btnDel.Location = new Point(192, 171);
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
            btnAdd.Location = new Point(10, 171);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(126, 99, 99);
            btnSave.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(762, 167);
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
            grd.Location = new Point(11, 210);
            grd.Margin = new Padding(3, 2, 3, 2);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(854, 270);
            grd.TabIndex = 18;
            grd.CellClick += grd_CellClick;
            // 
            // gb1
            // 
            gb1.BackColor = Color.FromArgb(227, 225, 217);
            gb1.Controls.Add(label5);
            gb1.Controls.Add(tbAccu);
            gb1.Controls.Add(tbDiscount);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(tbRank);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(tbPhonenumber);
            gb1.Controls.Add(label10);
            gb1.Controls.Add(tbID);
            gb1.Controls.Add(label9);
            gb1.Controls.Add(tbName);
            gb1.Location = new Point(11, 39);
            gb1.Margin = new Padding(3, 2, 3, 2);
            gb1.Name = "gb1";
            gb1.Padding = new Padding(3, 2, 3, 2);
            gb1.Size = new Size(854, 124);
            gb1.TabIndex = 17;
            gb1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 64);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 29;
            label5.Text = "Accumutated money";
            // 
            // tbAccu
            // 
            tbAccu.Location = new Point(446, 81);
            tbAccu.Margin = new Padding(3, 2, 3, 2);
            tbAccu.Name = "tbAccu";
            tbAccu.Size = new Size(392, 23);
            tbAccu.TabIndex = 28;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(699, 28);
            tbDiscount.Margin = new Padding(3, 2, 3, 2);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(140, 23);
            tbDiscount.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(699, 11);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 27;
            label4.Text = "Discount";
            // 
            // tbRank
            // 
            tbRank.Location = new Point(446, 28);
            tbRank.Margin = new Padding(3, 2, 3, 2);
            tbRank.Name = "tbRank";
            tbRank.Size = new Size(248, 23);
            tbRank.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 11);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 25;
            label3.Text = "Rank";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 64);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 23;
            label2.Text = "Phone number";
            // 
            // tbPhonenumber
            // 
            tbPhonenumber.Location = new Point(16, 81);
            tbPhonenumber.Margin = new Padding(3, 2, 3, 2);
            tbPhonenumber.Name = "tbPhonenumber";
            tbPhonenumber.Size = new Size(385, 23);
            tbPhonenumber.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(115, 11);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 21;
            label10.Text = "Name";
            // 
            // tbID
            // 
            tbID.Location = new Point(16, 28);
            tbID.Margin = new Padding(3, 2, 3, 2);
            tbID.Name = "tbID";
            tbID.Size = new Size(94, 23);
            tbID.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 11);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 19;
            label9.Text = "ID";
            // 
            // tbName
            // 
            tbName.Location = new Point(115, 28);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(286, 23);
            tbName.TabIndex = 20;
            // 
            // membership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 500);
            Controls.Add(mainboard);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "membership";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            Load += membership_Load;
            mainboard.ResumeLayout(false);
            mainboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainboard;
        private TextBox textBox3;
        private TextBox tbRank;
        private DateTimePicker dateTimePicker1;
        private DataGridView grd;
        private GroupBox gb1;
        private Label label10;
        private TextBox tbName;
        private TextBox textBox7;
        private Label label9;
        private TextBox tbID;
        private Button btnSave;
        private ComboBox comboBox2;
        private Button btnPDF;
        private Button btnEdit;
        private Button btnDel;
        private Button btnAdd;
        private Button btnClear;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox tbPhonenumber;
        private TextBox tbDiscount;
        private Label label4;
        private Label label5;
        private TextBox tbAccu;
    }
}