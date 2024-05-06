namespace GUI
{
    partial class takeOrder
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
            btnCancel = new Button();
            tbMem = new TextBox();
            panel_totalMoney = new Panel();
            totalmoney = new Label();
            label4 = new Label();
            btnCreate_order = new Button();
            label7 = new Label();
            tbDiscount = new TextBox();
            gbSearch = new GroupBox();
            btnShowAll = new Button();
            label10 = new Label();
            SearchCbType = new ComboBox();
            label9 = new Label();
            SearchTbName = new TextBox();
            label8 = new Label();
            label11 = new Label();
            label14 = new Label();
            btnClear = new Button();
            cbPayment = new ComboBox();
            btnPDF = new Button();
            btnPay = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            grdProd = new DataGridView();
            gbProd = new GroupBox();
            tbQuantity = new NumericUpDown();
            label6 = new Label();
            label2 = new Label();
            tbPrice = new TextBox();
            label3 = new Label();
            tbProdName = new TextBox();
            ProdIMG = new PictureBox();
            label1 = new Label();
            grdOrder = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainboard.SuspendLayout();
            panel_totalMoney.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdProd).BeginInit();
            gbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProdIMG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdOrder).BeginInit();
            SuspendLayout();
            // 
            // mainboard
            // 
            mainboard.BackColor = Color.FromArgb(242, 239, 229);
            mainboard.Controls.Add(btnCancel);
            mainboard.Controls.Add(tbMem);
            mainboard.Controls.Add(panel_totalMoney);
            mainboard.Controls.Add(btnCreate_order);
            mainboard.Controls.Add(label7);
            mainboard.Controls.Add(tbDiscount);
            mainboard.Controls.Add(gbSearch);
            mainboard.Controls.Add(label8);
            mainboard.Controls.Add(label11);
            mainboard.Controls.Add(label14);
            mainboard.Controls.Add(btnClear);
            mainboard.Controls.Add(cbPayment);
            mainboard.Controls.Add(btnPDF);
            mainboard.Controls.Add(btnPay);
            mainboard.Controls.Add(btnDel);
            mainboard.Controls.Add(btnAdd);
            mainboard.Controls.Add(grdProd);
            mainboard.Controls.Add(gbProd);
            mainboard.Controls.Add(label1);
            mainboard.Controls.Add(grdOrder);
            mainboard.ForeColor = SystemColors.ActiveCaptionText;
            mainboard.Location = new Point(0, -3);
            mainboard.Margin = new Padding(3, 2, 3, 2);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(878, 454);
            mainboard.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(186, 416);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 56;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbMem
            // 
            tbMem.Location = new Point(600, 376);
            tbMem.Margin = new Padding(3, 2, 3, 2);
            tbMem.Name = "tbMem";
            tbMem.Size = new Size(190, 23);
            tbMem.TabIndex = 55;
            // 
            // panel_totalMoney
            // 
            panel_totalMoney.BackColor = Color.White;
            panel_totalMoney.Controls.Add(totalmoney);
            panel_totalMoney.Controls.Add(label4);
            panel_totalMoney.Location = new Point(600, 297);
            panel_totalMoney.Margin = new Padding(3, 2, 3, 2);
            panel_totalMoney.Name = "panel_totalMoney";
            panel_totalMoney.Size = new Size(264, 52);
            panel_totalMoney.TabIndex = 48;
            // 
            // totalmoney
            // 
            totalmoney.AutoSize = true;
            totalmoney.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalmoney.Location = new Point(9, 8);
            totalmoney.Name = "totalmoney";
            totalmoney.Size = new Size(55, 37);
            totalmoney.TabIndex = 1;
            totalmoney.Text = "$0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F);
            label4.Location = new Point(223, 2);
            label4.Name = "label4";
            label4.Size = new Size(36, 14);
            label4.TabIndex = 0;
            label4.Text = "Total";
            // 
            // btnCreate_order
            // 
            btnCreate_order.Location = new Point(741, 15);
            btnCreate_order.Margin = new Padding(3, 2, 3, 2);
            btnCreate_order.Name = "btnCreate_order";
            btnCreate_order.Size = new Size(123, 22);
            btnCreate_order.TabIndex = 47;
            btnCreate_order.Text = "Create new order";
            btnCreate_order.UseVisualStyleBackColor = true;
            btnCreate_order.Click += btnCreate_order_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(795, 361);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 54;
            label7.Text = "Discount";
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(795, 376);
            tbDiscount.Margin = new Padding(3, 2, 3, 2);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(70, 23);
            tbDiscount.TabIndex = 53;
            // 
            // gbSearch
            // 
            gbSearch.BackColor = Color.FromArgb(227, 225, 217);
            gbSearch.Controls.Add(btnShowAll);
            gbSearch.Controls.Add(label10);
            gbSearch.Controls.Add(SearchCbType);
            gbSearch.Controls.Add(label9);
            gbSearch.Controls.Add(SearchTbName);
            gbSearch.Font = new Font("Arial Rounded MT Bold", 9F);
            gbSearch.Location = new Point(10, 44);
            gbSearch.Margin = new Padding(3, 2, 3, 2);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(3, 2, 3, 2);
            gbSearch.Size = new Size(584, 50);
            gbSearch.TabIndex = 32;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(497, 16);
            btnShowAll.Margin = new Padding(3, 2, 3, 2);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(82, 22);
            btnShowAll.TabIndex = 50;
            btnShowAll.Text = "Show all";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(296, 20);
            label10.Name = "label10";
            label10.Size = new Size(37, 14);
            label10.TabIndex = 44;
            label10.Text = "Type";
            // 
            // SearchCbType
            // 
            SearchCbType.FormattingEnabled = true;
            SearchCbType.Location = new Point(339, 18);
            SearchCbType.Margin = new Padding(3, 2, 3, 2);
            SearchCbType.Name = "SearchCbType";
            SearchCbType.Size = new Size(154, 22);
            SearchCbType.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 20);
            label9.Name = "label9";
            label9.Size = new Size(41, 14);
            label9.TabIndex = 43;
            label9.Text = "Name";
            // 
            // SearchTbName
            // 
            SearchTbName.Location = new Point(58, 18);
            SearchTbName.Margin = new Padding(3, 2, 3, 2);
            SearchTbName.Name = "SearchTbName";
            SearchTbName.Size = new Size(233, 21);
            SearchTbName.TabIndex = 43;
            SearchTbName.KeyDown += SearchTbName_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(600, 16);
            label8.Name = "label8";
            label8.Size = new Size(64, 22);
            label8.TabIndex = 31;
            label8.Text = "Order";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F);
            label11.Location = new Point(432, 407);
            label11.Name = "label11";
            label11.Size = new Size(105, 14);
            label11.TabIndex = 46;
            label11.Text = "Payment method";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F);
            label14.Location = new Point(600, 361);
            label14.Name = "label14";
            label14.Size = new Size(164, 14);
            label14.TabIndex = 49;
            label14.Text = "Membership phonenumber";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(684, 257);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cbPayment
            // 
            cbPayment.FormattingEnabled = true;
            cbPayment.Location = new Point(432, 422);
            cbPayment.Margin = new Padding(3, 2, 3, 2);
            cbPayment.Name = "cbPayment";
            cbPayment.Size = new Size(154, 23);
            cbPayment.TabIndex = 33;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(98, 416);
            btnPDF.Margin = new Padding(3, 2, 3, 2);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(82, 22);
            btnPDF.TabIndex = 28;
            btnPDF.Text = "Print";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(126, 99, 99);
            btnPay.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.Transparent;
            btnPay.Location = new Point(600, 407);
            btnPay.Margin = new Padding(3, 2, 3, 2);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(264, 37);
            btnPay.TabIndex = 24;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(772, 257);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(82, 22);
            btnDel.TabIndex = 26;
            btnDel.Text = "Remove";
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
            // grdProd
            // 
            grdProd.BackgroundColor = SystemColors.ButtonHighlight;
            grdProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProd.Location = new Point(9, 98);
            grdProd.Margin = new Padding(3, 2, 3, 2);
            grdProd.Name = "grdProd";
            grdProd.RowHeadersWidth = 51;
            grdProd.Size = new Size(586, 144);
            grdProd.TabIndex = 18;
            grdProd.CellClick += grdProd_CellClick;
            // 
            // gbProd
            // 
            gbProd.BackColor = Color.FromArgb(227, 225, 217);
            gbProd.Controls.Add(tbQuantity);
            gbProd.Controls.Add(label6);
            gbProd.Controls.Add(label2);
            gbProd.Controls.Add(tbPrice);
            gbProd.Controls.Add(label3);
            gbProd.Controls.Add(tbProdName);
            gbProd.Controls.Add(ProdIMG);
            gbProd.Font = new Font("Arial Rounded MT Bold", 9F);
            gbProd.Location = new Point(10, 246);
            gbProd.Margin = new Padding(3, 2, 3, 2);
            gbProd.Name = "gbProd";
            gbProd.Padding = new Padding(3, 2, 3, 2);
            gbProd.Size = new Size(584, 154);
            gbProd.TabIndex = 17;
            gbProd.TabStop = false;
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(13, 109);
            tbQuantity.Margin = new Padding(3, 2, 3, 2);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(312, 21);
            tbQuantity.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 90);
            label6.Name = "label6";
            label6.Size = new Size(56, 14);
            label6.TabIndex = 58;
            label6.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 34);
            label2.Name = "label2";
            label2.Size = new Size(37, 14);
            label2.TabIndex = 56;
            label2.Text = "Price";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(210, 51);
            tbPrice.Margin = new Padding(3, 2, 3, 2);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(115, 21);
            tbPrice.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 34);
            label3.Name = "label3";
            label3.Size = new Size(88, 14);
            label3.TabIndex = 29;
            label3.Text = "Product name";
            // 
            // tbProdName
            // 
            tbProdName.Location = new Point(13, 51);
            tbProdName.Margin = new Padding(3, 2, 3, 2);
            tbProdName.Name = "tbProdName";
            tbProdName.Size = new Size(191, 21);
            tbProdName.TabIndex = 28;
            // 
            // ProdIMG
            // 
            ProdIMG.BackColor = Color.White;
            ProdIMG.InitialImage = null;
            ProdIMG.Location = new Point(346, 18);
            ProdIMG.Margin = new Padding(3, 2, 3, 2);
            ProdIMG.Name = "ProdIMG";
            ProdIMG.Size = new Size(221, 126);
            ProdIMG.SizeMode = PictureBoxSizeMode.StretchImage;
            ProdIMG.TabIndex = 17;
            ProdIMG.TabStop = false;
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
            // grdOrder
            // 
            grdOrder.BackgroundColor = SystemColors.ButtonHighlight;
            grdOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOrder.Location = new Point(600, 44);
            grdOrder.Margin = new Padding(3, 2, 3, 2);
            grdOrder.Name = "grdOrder";
            grdOrder.RowHeadersWidth = 51;
            grdOrder.Size = new Size(264, 249);
            grdOrder.TabIndex = 30;
            grdOrder.CellClick += grdOrder_CellClick;
            // 
            // takeOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(mainboard);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "takeOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            mainboard.ResumeLayout(false);
            mainboard.PerformLayout();
            panel_totalMoney.ResumeLayout(false);
            panel_totalMoney.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdProd).EndInit();
            gbProd.ResumeLayout(false);
            gbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProdIMG).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainboard;
        private Label label1;
        private TextBox tbProdName;
        private DateTimePicker dateTimePicker1;
        private DataGridView grdProd;
        private GroupBox gbProd;
        private TextBox textBox7;
        private PictureBox ProdIMG;
        private Button btnPay;
        private ComboBox cbPayment;
        private Button btnPDF;
        private Button btnDel;
        private Button btnAdd;
        private Button btnClear;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label8;
        private DataGridView grdOrder;
        private GroupBox gbSearch;
        private Label label10;
        private ComboBox SearchCbType;
        private Label label9;
        private TextBox SearchTbName;
        private Label label11;
        private NumericUpDown tbQuantity;
        private Label label12;
        private NumericUpDown numericUpDown2;
        private Label label14;
        private Button btnCreate_order;
        private Button btnShowAll;
        private Label label13;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox tbDiscount;
        private Label label2;
        private TextBox tbPrice;
        private Panel panel_totalMoney;
        private Label totalmoney;
        private Label label4;
        private Label label6;
        private TextBox tbMem;
        private Button btnCancel;
    }
}