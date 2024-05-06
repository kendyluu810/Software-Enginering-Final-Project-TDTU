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
            btnShowAll = new Button();
            label6 = new Label();
            SearchCbType = new ComboBox();
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
            mainboard.Controls.Add(btnShowAll);
            mainboard.Controls.Add(label6);
            mainboard.Controls.Add(SearchCbType);
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
            mainboard.Location = new Point(0, -3);
            mainboard.Margin = new Padding(3, 2, 3, 2);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(878, 454);
            mainboard.TabIndex = 0;
            // 
            // grdCoupon
            // 
            grdCoupon.BackgroundColor = SystemColors.ButtonHighlight;
            grdCoupon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCoupon.Location = new Point(10, 208);
            grdCoupon.Margin = new Padding(3, 2, 3, 2);
            grdCoupon.Name = "grdCoupon";
            grdCoupon.RowHeadersWidth = 51;
            grdCoupon.Size = new Size(438, 236);
            grdCoupon.TabIndex = 35;
            grdCoupon.CellClick += grdCoupon_CellClick;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(475, 39);
            btnShowAll.Margin = new Padding(3, 2, 3, 2);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(88, 22);
            btnShowAll.TabIndex = 34;
            btnShowAll.Text = "Show all";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(701, 42);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 27;
            label6.Text = "Type";
            // 
            // SearchCbType
            // 
            SearchCbType.FormattingEnabled = true;
            SearchCbType.Location = new Point(741, 39);
            SearchCbType.Margin = new Padding(3, 2, 3, 2);
            SearchCbType.Name = "SearchCbType";
            SearchCbType.Size = new Size(124, 23);
            SearchCbType.TabIndex = 0;
            SearchCbType.SelectedIndexChanged += SearchCbType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(776, 10);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 33;
            label4.Text = "Product";
            // 
            // grdProd
            // 
            grdProd.BackgroundColor = SystemColors.ButtonHighlight;
            grdProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProd.Location = new Point(475, 64);
            grdProd.Margin = new Padding(3, 2, 3, 2);
            grdProd.Name = "grdProd";
            grdProd.RowHeadersWidth = 51;
            grdProd.Size = new Size(389, 380);
            grdProd.TabIndex = 32;
            grdProd.CellClick += grdProd_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 186);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 31;
            label2.Text = "Coupons";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(188, 22);
            label1.TabIndex = 30;
            label1.Text = "Coupon information";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(106, 149);
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
            btnDel.Location = new Point(197, 149);
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
            btnAdd.Location = new Point(16, 149);
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
            btnSave.Location = new Point(346, 149);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 22);
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
            gb1.Location = new Point(11, 39);
            gb1.Margin = new Padding(3, 2, 3, 2);
            gb1.Name = "gb1";
            gb1.Padding = new Padding(3, 2, 3, 2);
            gb1.Size = new Size(438, 94);
            gb1.TabIndex = 17;
            gb1.TabStop = false;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(5, 59);
            tbDiscount.Margin = new Padding(3, 2, 3, 2);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(416, 23);
            tbDiscount.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 42);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 25;
            label3.Text = "Discount percentage";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(115, 2);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 21;
            label10.Text = "Product name";
            // 
            // tbID
            // 
            tbID.Location = new Point(5, 20);
            tbID.Margin = new Padding(3, 2, 3, 2);
            tbID.Name = "tbID";
            tbID.Size = new Size(105, 23);
            tbID.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 2);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 19;
            label9.Text = "Coupon ID";
            // 
            // tbName
            // 
            tbName.Location = new Point(115, 20);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(307, 23);
            tbName.TabIndex = 20;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // coupon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(mainboard);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnShowAll;
        private Label label6;
        private ComboBox SearchCbType;
        private DataGridView grdCoupon;
    }
}