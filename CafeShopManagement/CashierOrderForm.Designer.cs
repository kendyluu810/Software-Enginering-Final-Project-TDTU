namespace CafeShopManagement
{
    partial class CashierOrderForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrderForm));
            panelLU = new Panel();
            CashierOrderForm_menuTable = new DataGridView();
            label1 = new Label();
            panelLD = new Panel();
            CashierOrderForm_ProductName = new ComboBox();
            CashierOrderForm_Clearbtn = new Button();
            CashierOrderForm_Removebtn = new Button();
            CashierOrderForm_Addbtn = new Button();
            CashierOrderForm_Price = new Label();
            label8 = new Label();
            label6 = new Label();
            CashierOrderForm_Quantity = new NumericUpDown();
            CashierOrderForm_productID = new Label();
            label3 = new Label();
            label2 = new Label();
            CashierOrderForm_Type = new ComboBox();
            label4 = new Label();
            panelR = new Panel();
            CashierOrderForm_Receiptbtn = new Button();
            CashierOrderForm_Paybtn = new Button();
            CashierOrderForm_change = new Label();
            label13 = new Label();
            CashierOrderForm_Total = new TextBox();
            label11 = new Label();
            CashierOrderForm_orderPrice = new Label();
            label10 = new Label();
            CashierOrderForm_orderTable = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panelLU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CashierOrderForm_menuTable).BeginInit();
            panelLD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CashierOrderForm_Quantity).BeginInit();
            panelR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CashierOrderForm_orderTable).BeginInit();
            SuspendLayout();
            // 
            // panelLU
            // 
            panelLU.Controls.Add(CashierOrderForm_menuTable);
            panelLU.Controls.Add(label1);
            panelLU.Location = new Point(20, 20);
            panelLU.Name = "panelLU";
            panelLU.Size = new Size(900, 325);
            panelLU.TabIndex = 0;
            // 
            // CashierOrderForm_menuTable
            // 
            CashierOrderForm_menuTable.AllowUserToAddRows = false;
            CashierOrderForm_menuTable.AllowUserToDeleteRows = false;
            CashierOrderForm_menuTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CashierOrderForm_menuTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(126, 99, 99);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(242, 239, 229);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CashierOrderForm_menuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CashierOrderForm_menuTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CashierOrderForm_menuTable.EnableHeadersVisualStyles = false;
            CashierOrderForm_menuTable.Location = new Point(30, 62);
            CashierOrderForm_menuTable.Name = "CashierOrderForm_menuTable";
            CashierOrderForm_menuTable.ReadOnly = true;
            CashierOrderForm_menuTable.RowHeadersVisible = false;
            CashierOrderForm_menuTable.Size = new Size(851, 233);
            CashierOrderForm_menuTable.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(126, 99, 99);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 22);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // panelLD
            // 
            panelLD.Controls.Add(CashierOrderForm_ProductName);
            panelLD.Controls.Add(CashierOrderForm_Clearbtn);
            panelLD.Controls.Add(CashierOrderForm_Removebtn);
            panelLD.Controls.Add(CashierOrderForm_Addbtn);
            panelLD.Controls.Add(CashierOrderForm_Price);
            panelLD.Controls.Add(label8);
            panelLD.Controls.Add(label6);
            panelLD.Controls.Add(CashierOrderForm_Quantity);
            panelLD.Controls.Add(CashierOrderForm_productID);
            panelLD.Controls.Add(label3);
            panelLD.Controls.Add(label2);
            panelLD.Controls.Add(CashierOrderForm_Type);
            panelLD.Controls.Add(label4);
            panelLD.Location = new Point(20, 365);
            panelLD.Name = "panelLD";
            panelLD.Size = new Size(900, 325);
            panelLD.TabIndex = 1;
            // 
            // CashierOrderForm_ProductName
            // 
            CashierOrderForm_ProductName.Font = new Font("Arial Rounded MT Bold", 12F);
            CashierOrderForm_ProductName.FormattingEnabled = true;
            CashierOrderForm_ProductName.Location = new Point(204, 97);
            CashierOrderForm_ProductName.Name = "CashierOrderForm_ProductName";
            CashierOrderForm_ProductName.Size = new Size(192, 26);
            CashierOrderForm_ProductName.TabIndex = 22;
            CashierOrderForm_ProductName.SelectedIndexChanged += CashierOrderForm_ProductName_SelectedIndexChanged;
            // 
            // CashierOrderForm_Clearbtn
            // 
            CashierOrderForm_Clearbtn.BackColor = Color.FromArgb(126, 99, 99);
            CashierOrderForm_Clearbtn.FlatStyle = FlatStyle.Flat;
            CashierOrderForm_Clearbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierOrderForm_Clearbtn.ForeColor = Color.FromArgb(242, 239, 229);
            CashierOrderForm_Clearbtn.Location = new Point(548, 218);
            CashierOrderForm_Clearbtn.Name = "CashierOrderForm_Clearbtn";
            CashierOrderForm_Clearbtn.Size = new Size(109, 35);
            CashierOrderForm_Clearbtn.TabIndex = 21;
            CashierOrderForm_Clearbtn.Text = "Clear";
            CashierOrderForm_Clearbtn.UseVisualStyleBackColor = false;
            CashierOrderForm_Clearbtn.Click += CashierOrderForm_Clearbtn_Click;
            // 
            // CashierOrderForm_Removebtn
            // 
            CashierOrderForm_Removebtn.BackColor = Color.FromArgb(126, 99, 99);
            CashierOrderForm_Removebtn.FlatStyle = FlatStyle.Flat;
            CashierOrderForm_Removebtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierOrderForm_Removebtn.ForeColor = Color.FromArgb(242, 239, 229);
            CashierOrderForm_Removebtn.Location = new Point(373, 218);
            CashierOrderForm_Removebtn.Name = "CashierOrderForm_Removebtn";
            CashierOrderForm_Removebtn.Size = new Size(109, 35);
            CashierOrderForm_Removebtn.TabIndex = 20;
            CashierOrderForm_Removebtn.Text = "Remove";
            CashierOrderForm_Removebtn.UseVisualStyleBackColor = false;
            CashierOrderForm_Removebtn.Click += CashierOrderForm_Removebtn_Click;
            // 
            // CashierOrderForm_Addbtn
            // 
            CashierOrderForm_Addbtn.BackColor = Color.FromArgb(126, 99, 99);
            CashierOrderForm_Addbtn.FlatStyle = FlatStyle.Flat;
            CashierOrderForm_Addbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierOrderForm_Addbtn.ForeColor = Color.FromArgb(242, 239, 229);
            CashierOrderForm_Addbtn.Location = new Point(198, 218);
            CashierOrderForm_Addbtn.Name = "CashierOrderForm_Addbtn";
            CashierOrderForm_Addbtn.Size = new Size(109, 35);
            CashierOrderForm_Addbtn.TabIndex = 19;
            CashierOrderForm_Addbtn.Text = "Add";
            CashierOrderForm_Addbtn.UseVisualStyleBackColor = false;
            CashierOrderForm_Addbtn.Click += CashierOrderForm_Addbtn_Click;
            // 
            // CashierOrderForm_Price
            // 
            CashierOrderForm_Price.AutoSize = true;
            CashierOrderForm_Price.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierOrderForm_Price.ForeColor = Color.FromArgb(126, 99, 99);
            CashierOrderForm_Price.Location = new Point(204, 153);
            CashierOrderForm_Price.Name = "CashierOrderForm_Price";
            CashierOrderForm_Price.Size = new Size(12, 18);
            CashierOrderForm_Price.TabIndex = 18;
            CashierOrderForm_Price.Text = " ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(126, 99, 99);
            label8.Location = new Point(44, 153);
            label8.Name = "label8";
            label8.Size = new Size(106, 18);
            label8.TabIndex = 17;
            label8.Text = "Price (VND):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(126, 99, 99);
            label6.Location = new Point(503, 97);
            label6.Name = "label6";
            label6.Size = new Size(81, 18);
            label6.TabIndex = 16;
            label6.Text = "Quantity:";
            // 
            // CashierOrderForm_Quantity
            // 
            CashierOrderForm_Quantity.Font = new Font("Arial Rounded MT Bold", 12F);
            CashierOrderForm_Quantity.Location = new Point(638, 95);
            CashierOrderForm_Quantity.Name = "CashierOrderForm_Quantity";
            CashierOrderForm_Quantity.Size = new Size(192, 26);
            CashierOrderForm_Quantity.TabIndex = 15;
            // 
            // CashierOrderForm_productID
            // 
            CashierOrderForm_productID.AutoSize = true;
            CashierOrderForm_productID.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierOrderForm_productID.ForeColor = Color.FromArgb(126, 99, 99);
            CashierOrderForm_productID.Location = new Point(638, 52);
            CashierOrderForm_productID.Name = "CashierOrderForm_productID";
            CashierOrderForm_productID.Size = new Size(12, 18);
            CashierOrderForm_productID.TabIndex = 14;
            CashierOrderForm_productID.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(126, 99, 99);
            label3.Location = new Point(23, 97);
            label3.Name = "label3";
            label3.Size = new Size(127, 18);
            label3.TabIndex = 13;
            label3.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(126, 99, 99);
            label2.Location = new Point(486, 46);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 11;
            label2.Text = "Product ID:";
            // 
            // CashierOrderForm_Type
            // 
            CashierOrderForm_Type.Font = new Font("Arial Rounded MT Bold", 12F);
            CashierOrderForm_Type.FormattingEnabled = true;
            CashierOrderForm_Type.Items.AddRange(new object[] { "Bakes", "Drink" });
            CashierOrderForm_Type.Location = new Point(204, 44);
            CashierOrderForm_Type.Name = "CashierOrderForm_Type";
            CashierOrderForm_Type.Size = new Size(192, 26);
            CashierOrderForm_Type.TabIndex = 10;
            CashierOrderForm_Type.SelectedIndexChanged += CashierOrderForm_Type_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(126, 99, 99);
            label4.Location = new Point(98, 46);
            label4.Name = "label4";
            label4.Size = new Size(52, 18);
            label4.TabIndex = 9;
            label4.Text = "Type:";
            // 
            // panelR
            // 
            panelR.Controls.Add(CashierOrderForm_Receiptbtn);
            panelR.Controls.Add(CashierOrderForm_Paybtn);
            panelR.Controls.Add(CashierOrderForm_change);
            panelR.Controls.Add(label13);
            panelR.Controls.Add(CashierOrderForm_Total);
            panelR.Controls.Add(label11);
            panelR.Controls.Add(CashierOrderForm_orderPrice);
            panelR.Controls.Add(label10);
            panelR.Controls.Add(CashierOrderForm_orderTable);
            panelR.Location = new Point(940, 20);
            panelR.Name = "panelR";
            panelR.Size = new Size(480, 670);
            panelR.TabIndex = 1;
            // 
            // CashierOrderForm_Receiptbtn
            // 
            CashierOrderForm_Receiptbtn.BackColor = Color.FromArgb(126, 99, 99);
            CashierOrderForm_Receiptbtn.FlatStyle = FlatStyle.Flat;
            CashierOrderForm_Receiptbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierOrderForm_Receiptbtn.ForeColor = Color.FromArgb(242, 239, 229);
            CashierOrderForm_Receiptbtn.Location = new Point(126, 572);
            CashierOrderForm_Receiptbtn.Name = "CashierOrderForm_Receiptbtn";
            CashierOrderForm_Receiptbtn.Size = new Size(229, 35);
            CashierOrderForm_Receiptbtn.TabIndex = 26;
            CashierOrderForm_Receiptbtn.Text = "Receipt";
            CashierOrderForm_Receiptbtn.UseVisualStyleBackColor = false;
            CashierOrderForm_Receiptbtn.Click += CashierOrderForm_Receiptbtn_Click;
            // 
            // CashierOrderForm_Paybtn
            // 
            CashierOrderForm_Paybtn.BackColor = Color.FromArgb(126, 99, 99);
            CashierOrderForm_Paybtn.FlatStyle = FlatStyle.Flat;
            CashierOrderForm_Paybtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierOrderForm_Paybtn.ForeColor = Color.FromArgb(242, 239, 229);
            CashierOrderForm_Paybtn.Location = new Point(126, 516);
            CashierOrderForm_Paybtn.Name = "CashierOrderForm_Paybtn";
            CashierOrderForm_Paybtn.Size = new Size(229, 35);
            CashierOrderForm_Paybtn.TabIndex = 22;
            CashierOrderForm_Paybtn.Text = "Pay";
            CashierOrderForm_Paybtn.UseVisualStyleBackColor = false;
            CashierOrderForm_Paybtn.Click += CashierOrderForm_Paybtn_Click;
            // 
            // CashierOrderForm_change
            // 
            CashierOrderForm_change.AutoSize = true;
            CashierOrderForm_change.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierOrderForm_change.ForeColor = Color.FromArgb(126, 99, 99);
            CashierOrderForm_change.Location = new Point(357, 458);
            CashierOrderForm_change.Name = "CashierOrderForm_change";
            CashierOrderForm_change.Size = new Size(18, 18);
            CashierOrderForm_change.TabIndex = 23;
            CashierOrderForm_change.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(126, 99, 99);
            label13.Location = new Point(206, 458);
            label13.Name = "label13";
            label13.Size = new Size(126, 18);
            label13.TabIndex = 22;
            label13.Text = "Change (VND):";
            // 
            // CashierOrderForm_Total
            // 
            CashierOrderForm_Total.Font = new Font("Arial Rounded MT Bold", 12F);
            CashierOrderForm_Total.Location = new Point(357, 404);
            CashierOrderForm_Total.Name = "CashierOrderForm_Total";
            CashierOrderForm_Total.Size = new Size(109, 26);
            CashierOrderForm_Total.TabIndex = 25;
            CashierOrderForm_Total.KeyDown += CashierOrderForm_Total_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(126, 99, 99);
            label11.Location = new Point(228, 408);
            label11.Name = "label11";
            label11.Size = new Size(104, 18);
            label11.TabIndex = 24;
            label11.Text = "Total (VND):";
            // 
            // CashierOrderForm_orderPrice
            // 
            CashierOrderForm_orderPrice.AutoSize = true;
            CashierOrderForm_orderPrice.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierOrderForm_orderPrice.ForeColor = Color.FromArgb(126, 99, 99);
            CashierOrderForm_orderPrice.Location = new Point(357, 356);
            CashierOrderForm_orderPrice.Name = "CashierOrderForm_orderPrice";
            CashierOrderForm_orderPrice.Size = new Size(18, 18);
            CashierOrderForm_orderPrice.TabIndex = 23;
            CashierOrderForm_orderPrice.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(126, 99, 99);
            label10.Location = new Point(226, 356);
            label10.Name = "label10";
            label10.Size = new Size(106, 18);
            label10.TabIndex = 22;
            label10.Text = "Price (VND):";
            // 
            // CashierOrderForm_orderTable
            // 
            CashierOrderForm_orderTable.AllowUserToAddRows = false;
            CashierOrderForm_orderTable.AllowUserToDeleteRows = false;
            CashierOrderForm_orderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CashierOrderForm_orderTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(126, 99, 99);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(242, 239, 229);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CashierOrderForm_orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CashierOrderForm_orderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CashierOrderForm_orderTable.EnableHeadersVisualStyles = false;
            CashierOrderForm_orderTable.Location = new Point(6, 25);
            CashierOrderForm_orderTable.Name = "CashierOrderForm_orderTable";
            CashierOrderForm_orderTable.ReadOnly = true;
            CashierOrderForm_orderTable.RowHeadersVisible = false;
            CashierOrderForm_orderTable.Size = new Size(468, 313);
            CashierOrderForm_orderTable.TabIndex = 3;
            CashierOrderForm_orderTable.CellClick += CashierOrderForm_orderTable_CellClick;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // CashierOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 229);
            ClientSize = new Size(1440, 710);
            Controls.Add(panelR);
            Controls.Add(panelLD);
            Controls.Add(panelLU);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierOrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CashierOrderForm";
            panelLU.ResumeLayout(false);
            panelLU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CashierOrderForm_menuTable).EndInit();
            panelLD.ResumeLayout(false);
            panelLD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CashierOrderForm_Quantity).EndInit();
            panelR.ResumeLayout(false);
            panelR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CashierOrderForm_orderTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLU;
        private Panel panelLD;
        private Panel panelR;
        private Label label1;
        private DataGridView CashierOrderForm_menuTable;
        private Label label6;
        private NumericUpDown CashierOrderForm_Quantity;
        private Label CashierOrderForm_productID;
        private Label label3;
        private Label label2;
        private ComboBox CashierOrderForm_Type;
        private Label label4;
        private Label CashierOrderForm_Price;
        private Label label8;
        private Button CashierOrderForm_Clearbtn;
        private Button CashierOrderForm_Removebtn;
        private Button CashierOrderForm_Addbtn;
        private Label CashierOrderForm_orderPrice;
        private Label label10;
        private DataGridView CashierOrderForm_orderTable;
        private Button CashierOrderForm_Receiptbtn;
        private Button CashierOrderForm_Paybtn;
        private Label CashierOrderForm_change;
        private Label label13;
        private TextBox CashierOrderForm_Total;
        private Label label11;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private ComboBox CashierOrderForm_ProductName;
    }
}