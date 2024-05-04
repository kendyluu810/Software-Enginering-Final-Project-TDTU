namespace GUI
{
    partial class coupon
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
            grdCoupon = new DataGridView();
            button1 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            grdProd = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            btnEdit = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            gb1 = new GroupBox();
            tbDiscount = new TextBox();
            label3 = new Label();
            label10 = new Label();
            tbID = new TextBox();
            label9 = new Label();
            tbName = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            mainboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCoupon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdProd).BeginInit();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // mainboard
            // 
            mainboard.BackColor = Color.FromArgb(242, 239, 229);
            mainboard.Controls.Add(grdCoupon);
            mainboard.Controls.Add(button1);
            mainboard.Controls.Add(label6);
            mainboard.Controls.Add(comboBox1);
            mainboard.Controls.Add(label4);
            mainboard.Controls.Add(grdProd);
            mainboard.Controls.Add(label2);
            mainboard.Controls.Add(label1);
            mainboard.Controls.Add(btnEdit);
            mainboard.Controls.Add(btnDel);
            mainboard.Controls.Add(btnAdd);
            mainboard.Controls.Add(btnSave);
            mainboard.Controls.Add(gb1);
            mainboard.ForeColor = SystemColors.ActiveCaptionText;
            mainboard.Location = new Point(0, -4);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(1003, 605);
            mainboard.TabIndex = 0;
            // 
            // grdCoupon
            // 
            grdCoupon.BackgroundColor = SystemColors.ButtonHighlight;
            grdCoupon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCoupon.Location = new Point(12, 278);
            grdCoupon.Name = "grdCoupon";
            grdCoupon.RowHeadersWidth = 51;
            grdCoupon.Size = new Size(501, 314);
            grdCoupon.TabIndex = 35;
            grdCoupon.CellClick += grdCoupon_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(543, 52);
            button1.Name = "button1";
            button1.Size = new Size(101, 29);
            button1.TabIndex = 34;
            button1.Text = "Show all";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(801, 56);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 27;
            label6.Text = "Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(847, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 28);
            comboBox1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(887, 13);
            label4.Name = "label4";
            label4.Size = new Size(101, 27);
            label4.TabIndex = 33;
            label4.Text = "Product";
            // 
            // grdProd
            // 
            grdProd.BackgroundColor = SystemColors.ButtonHighlight;
            grdProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProd.Location = new Point(543, 86);
            grdProd.Name = "grdProd";
            grdProd.RowHeadersWidth = 51;
            grdProd.Size = new Size(445, 506);
            grdProd.TabIndex = 32;
            grdProd.CellClick += grdProd_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 248);
            label2.Name = "label2";
            label2.Size = new Size(111, 27);
            label2.TabIndex = 31;
            label2.Text = "Coupons";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(233, 27);
            label1.TabIndex = 30;
            label1.Text = "Coupon information";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(121, 199);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(225, 199);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 26;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 199);
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
            btnSave.Location = new Point(396, 199);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 29);
            btnSave.TabIndex = 24;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // gb1
            // 
            gb1.BackColor = Color.FromArgb(227, 225, 217);
            gb1.Controls.Add(tbDiscount);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(label10);
            gb1.Controls.Add(tbID);
            gb1.Controls.Add(label9);
            gb1.Controls.Add(tbName);
            gb1.Location = new Point(13, 52);
            gb1.Name = "gb1";
            gb1.Size = new Size(500, 126);
            gb1.TabIndex = 17;
            gb1.TabStop = false;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(6, 79);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(475, 27);
            tbDiscount.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 25;
            label3.Text = "Discount percentage";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(131, 3);
            label10.Name = "label10";
            label10.Size = new Size(101, 20);
            label10.TabIndex = 21;
            label10.Text = "Product name";
            // 
            // tbID
            // 
            tbID.Location = new Point(6, 26);
            tbID.Name = "tbID";
            tbID.Size = new Size(119, 27);
            tbID.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 3);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 19;
            label9.Text = "Coupon ID";
            // 
            // tbName
            // 
            tbName.Location = new Point(131, 26);
            tbName.Name = "tbName";
            tbName.Size = new Size(350, 27);
            tbName.TabIndex = 20;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // coupon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(mainboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "coupon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            mainboard.ResumeLayout(false);
            mainboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdCoupon).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdProd).EndInit();
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainboard;
        private TextBox textBox3;
        private TextBox tbDiscount;
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
        private Button btnEdit;
        private Button btnDel;
        private Button btnAdd;
        private Label label1;
        private Label label3;
        private Label label4;
        private DataGridView grdProd;
        private Label label2;
        private FileSystemWatcher fileSystemWatcher1;
        private Button button1;
        private Label label6;
        private ComboBox comboBox1;
        private DataGridView grdCoupon;
    }
}