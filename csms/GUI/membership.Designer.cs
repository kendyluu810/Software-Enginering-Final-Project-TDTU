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
            mainboard.Location = new Point(0, -4);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(1003, 605);
            mainboard.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(283, 27);
            label1.TabIndex = 30;
            label1.Text = "Membership information";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(319, 228);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(419, 228);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(94, 29);
            btnPDF.TabIndex = 28;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(115, 228);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(219, 228);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 26;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 228);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
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
            btnSave.Location = new Point(871, 223);
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
            grd.Location = new Point(13, 267);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(976, 325);
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
            gb1.Location = new Point(13, 52);
            gb1.Name = "gb1";
            gb1.Size = new Size(976, 165);
            gb1.TabIndex = 17;
            gb1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(510, 85);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 29;
            label5.Text = "Accumutated money";
            // 
            // tbAccu
            // 
            tbAccu.Location = new Point(510, 108);
            tbAccu.Name = "tbAccu";
            tbAccu.Size = new Size(448, 27);
            tbAccu.TabIndex = 28;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(799, 38);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(159, 27);
            tbDiscount.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(799, 15);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 27;
            label4.Text = "Discount";
            // 
            // tbRank
            // 
            tbRank.Location = new Point(510, 38);
            tbRank.Name = "tbRank";
            tbRank.Size = new Size(283, 27);
            tbRank.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 15);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 25;
            label3.Text = "Rank";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 85);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 23;
            label2.Text = "Phone number";
            // 
            // tbPhonenumber
            // 
            tbPhonenumber.Location = new Point(18, 108);
            tbPhonenumber.Name = "tbPhonenumber";
            tbPhonenumber.Size = new Size(439, 27);
            tbPhonenumber.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(131, 15);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 21;
            label10.Text = "Name";
            // 
            // tbID
            // 
            tbID.Location = new Point(18, 38);
            tbID.Name = "tbID";
            tbID.Size = new Size(107, 27);
            tbID.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 15);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 19;
            label9.Text = "ID";
            // 
            // tbName
            // 
            tbName.Location = new Point(131, 38);
            tbName.Name = "tbName";
            tbName.Size = new Size(326, 27);
            tbName.TabIndex = 20;
            // 
            // membership
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(mainboard);
            FormBorderStyle = FormBorderStyle.None;
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