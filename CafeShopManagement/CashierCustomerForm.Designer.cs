namespace CafeShopManagement
{
    partial class CashierCustomerForm
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
            panelLU = new Panel();
            CashierCustomersForm_Exportbtn = new Button();
            CashierCustomerForm_menuTable = new DataGridView();
            label1 = new Label();
            panelLU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CashierCustomerForm_menuTable).BeginInit();
            SuspendLayout();
            // 
            // panelLU
            // 
            panelLU.BackColor = Color.White;
            panelLU.Controls.Add(CashierCustomersForm_Exportbtn);
            panelLU.Controls.Add(CashierCustomerForm_menuTable);
            panelLU.Controls.Add(label1);
            panelLU.Location = new Point(12, 12);
            panelLU.Name = "panelLU";
            panelLU.Size = new Size(1416, 686);
            panelLU.TabIndex = 1;
            // 
            // CashierCustomersForm_Exportbtn
            // 
            CashierCustomersForm_Exportbtn.BackColor = Color.FromArgb(126, 99, 99);
            CashierCustomersForm_Exportbtn.FlatStyle = FlatStyle.Flat;
            CashierCustomersForm_Exportbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierCustomersForm_Exportbtn.ForeColor = Color.FromArgb(242, 239, 229);
            CashierCustomersForm_Exportbtn.Location = new Point(1267, 633);
            CashierCustomersForm_Exportbtn.Name = "CashierCustomersForm_Exportbtn";
            CashierCustomersForm_Exportbtn.Size = new Size(109, 35);
            CashierCustomersForm_Exportbtn.TabIndex = 20;
            CashierCustomersForm_Exportbtn.Text = "Export";
            CashierCustomersForm_Exportbtn.UseVisualStyleBackColor = false;
            CashierCustomersForm_Exportbtn.Click += CashierCustomersForm_Exportbtn_Click;
            // 
            // CashierCustomerForm_menuTable
            // 
            CashierCustomerForm_menuTable.AllowUserToAddRows = false;
            CashierCustomerForm_menuTable.AllowUserToDeleteRows = false;
            CashierCustomerForm_menuTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CashierCustomerForm_menuTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(126, 99, 99);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(242, 239, 229);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CashierCustomerForm_menuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CashierCustomerForm_menuTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CashierCustomerForm_menuTable.EnableHeadersVisualStyles = false;
            CashierCustomerForm_menuTable.Location = new Point(30, 62);
            CashierCustomerForm_menuTable.Name = "CashierCustomerForm_menuTable";
            CashierCustomerForm_menuTable.ReadOnly = true;
            CashierCustomerForm_menuTable.RowHeadersVisible = false;
            CashierCustomerForm_menuTable.Size = new Size(1346, 550);
            CashierCustomerForm_menuTable.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(126, 99, 99);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 22);
            label1.TabIndex = 0;
            label1.Text = "All Customers";
            // 
            // CashierCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 229);
            ClientSize = new Size(1440, 710);
            Controls.Add(panelLU);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierCustomerForm";
            panelLU.ResumeLayout(false);
            panelLU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CashierCustomerForm_menuTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLU;
        private DataGridView CashierCustomerForm_menuTable;
        private Label label1;
        private Button CashierCustomersForm_Exportbtn;
    }
}