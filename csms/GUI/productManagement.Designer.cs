namespace GUI
{
    partial class productManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productManagement));
            mainboard = new Panel();
            btnClear = new Button();
            btnExport = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            grd = new DataGridView();
            gbProd = new GroupBox();
            nPrice = new TextBox();
            cbStatus = new ComboBox();
            nStock = new NumericUpDown();
            cbType = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbProdName = new TextBox();
            label2 = new Label();
            tbProdID = new TextBox();
            ProdIMG = new PictureBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            gbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProdIMG).BeginInit();
            SuspendLayout();
            // 
            // mainboard
            // 
            mainboard.BackColor = Color.FromArgb(242, 239, 229);
            mainboard.Controls.Add(btnClear);
            mainboard.Controls.Add(btnExport);
            mainboard.Controls.Add(btnSave);
            mainboard.Controls.Add(btnEdit);
            mainboard.Controls.Add(btnDel);
            mainboard.Controls.Add(btnAdd);
            mainboard.Controls.Add(grd);
            mainboard.Controls.Add(gbProd);
            mainboard.Controls.Add(label1);
            mainboard.ForeColor = SystemColors.ActiveCaptionText;
            mainboard.Location = new Point(0, -3);
            mainboard.Margin = new Padding(3, 2, 3, 2);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(878, 454);
            mainboard.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(279, 416);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(367, 416);
            btnExport.Margin = new Padding(3, 2, 3, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(82, 22);
            btnExport.TabIndex = 28;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(126, 99, 99);
            btnSave.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(741, 412);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 28);
            btnSave.TabIndex = 24;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(101, 416);
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
            btnDel.Location = new Point(192, 416);
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
            btnAdd.Location = new Point(10, 416);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grd
            // 
            grd.BackgroundColor = SystemColors.ButtonHighlight;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(9, 39);
            grd.Margin = new Padding(3, 2, 3, 2);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(856, 202);
            grd.TabIndex = 18;
            grd.CellClick += grd_CellClick;
            grd.CellContentClick += grd_CellContentClick;
            // 
            // gbProd
            // 
            gbProd.BackColor = Color.FromArgb(227, 225, 217);
            gbProd.Controls.Add(nPrice);
            gbProd.Controls.Add(cbStatus);
            gbProd.Controls.Add(nStock);
            gbProd.Controls.Add(cbType);
            gbProd.Controls.Add(label7);
            gbProd.Controls.Add(label6);
            gbProd.Controls.Add(label5);
            gbProd.Controls.Add(label4);
            gbProd.Controls.Add(label3);
            gbProd.Controls.Add(tbProdName);
            gbProd.Controls.Add(label2);
            gbProd.Controls.Add(tbProdID);
            gbProd.Controls.Add(ProdIMG);
            gbProd.Location = new Point(10, 246);
            gbProd.Margin = new Padding(3, 2, 3, 2);
            gbProd.Name = "gbProd";
            gbProd.Padding = new Padding(3, 2, 3, 2);
            gbProd.Size = new Size(854, 154);
            gbProd.TabIndex = 17;
            gbProd.TabStop = false;
            // 
            // nPrice
            // 
            nPrice.Location = new Point(316, 79);
            nPrice.Margin = new Padding(3, 2, 3, 2);
            nPrice.Name = "nPrice";
            nPrice.Size = new Size(269, 23);
            nPrice.TabIndex = 42;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(316, 118);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(269, 23);
            cbStatus.TabIndex = 41;
            // 
            // nStock
            // 
            nStock.ImeMode = ImeMode.NoControl;
            nStock.Location = new Point(316, 34);
            nStock.Margin = new Padding(3, 2, 3, 2);
            nStock.Name = "nStock";
            nStock.Size = new Size(269, 23);
            nStock.TabIndex = 39;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(22, 118);
            cbType.Margin = new Padding(3, 2, 3, 2);
            cbType.Name = "cbType";
            cbType.Size = new Size(269, 23);
            cbType.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(316, 101);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 37;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(315, 60);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 35;
            label6.Text = "Price";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 16);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 33;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 101);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 31;
            label4.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 60);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 29;
            label3.Text = "Product name";
            // 
            // tbProdName
            // 
            tbProdName.Location = new Point(22, 77);
            tbProdName.Margin = new Padding(3, 2, 3, 2);
            tbProdName.Name = "tbProdName";
            tbProdName.Size = new Size(269, 23);
            tbProdName.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 16);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 27;
            label2.Text = "Product ID";
            // 
            // tbProdID
            // 
            tbProdID.Location = new Point(22, 34);
            tbProdID.Margin = new Padding(3, 2, 3, 2);
            tbProdID.Name = "tbProdID";
            tbProdID.Size = new Size(269, 23);
            tbProdID.TabIndex = 26;
            // 
            // ProdIMG
            // 
            ProdIMG.BackColor = Color.White;
            ProdIMG.InitialImage = (Image)resources.GetObject("ProdIMG.InitialImage");
            ProdIMG.Location = new Point(612, 16);
            ProdIMG.Margin = new Padding(3, 2, 3, 2);
            ProdIMG.Name = "ProdIMG";
            ProdIMG.Size = new Size(221, 126);
            ProdIMG.SizeMode = PictureBoxSizeMode.StretchImage;
            ProdIMG.TabIndex = 17;
            ProdIMG.TabStop = false;
            ProdIMG.Click += ProdIMG_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(191, 22);
            label1.TabIndex = 1;
            label1.Text = "Product information";
            // 
            // productManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(mainboard);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "productManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            mainboard.ResumeLayout(false);
            mainboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            gbProd.ResumeLayout(false);
            gbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProdIMG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainboard;
        private Label label1;
        private TextBox textBox3;
        private TextBox tbProdName;
        private DateTimePicker dateTimePicker1;
        private DataGridView grd;
        private GroupBox gbProd;
        private TextBox textBox7;
        private PictureBox ProdIMG;
        private Button btnSave;
        private ComboBox comboBox2;
        private Button btnExport;
        private Button btnEdit;
        private Button btnDel;
        private Button btnAdd;
        private Button btnClear;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbProdID;
        private ComboBox cbStatus;
        private ComboBox cbType;
        private TextBox nPrice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown nStock;
    }
}