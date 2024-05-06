namespace GUI
{
    partial class receipt
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
            label4 = new Label();
            label3 = new Label();
            date_cb = new ComboBox();
            staff_cb = new ComboBox();
            label2 = new Label();
            grdReceipt = new DataGridView();
            grdOrder = new DataGridView();
            label1 = new Label();
            mainboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdReceipt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdOrder).BeginInit();
            SuspendLayout();
            // 
            // mainboard
            // 
            mainboard.BackColor = Color.FromArgb(242, 239, 229);
            mainboard.Controls.Add(label4);
            mainboard.Controls.Add(label3);
            mainboard.Controls.Add(date_cb);
            mainboard.Controls.Add(staff_cb);
            mainboard.Controls.Add(label2);
            mainboard.Controls.Add(grdReceipt);
            mainboard.Controls.Add(grdOrder);
            mainboard.Controls.Add(label1);
            mainboard.ForeColor = SystemColors.ActiveCaptionText;
            mainboard.Location = new Point(0, -3);
            mainboard.Margin = new Padding(3, 2, 3, 2);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(878, 454);
            mainboard.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(292, 406);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 35;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 406);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 34;
            label3.Text = "Staff";
            // 
            // date_cb
            // 
            date_cb.FormattingEnabled = true;
            date_cb.Location = new Point(292, 423);
            date_cb.Margin = new Padding(3, 2, 3, 2);
            date_cb.Name = "date_cb";
            date_cb.Size = new Size(244, 23);
            date_cb.TabIndex = 33;
            date_cb.SelectedIndexChanged += date_cb_SelectedIndexChanged;
            // 
            // staff_cb
            // 
            staff_cb.FormattingEnabled = true;
            staff_cb.Location = new Point(14, 423);
            staff_cb.Margin = new Padding(3, 2, 3, 2);
            staff_cb.Name = "staff_cb";
            staff_cb.Size = new Size(274, 23);
            staff_cb.TabIndex = 32;
            staff_cb.SelectedIndexChanged += staff_cb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(541, 10);
            label2.Name = "label2";
            label2.Size = new Size(147, 22);
            label2.TabIndex = 31;
            label2.Text = "Receipt details";
            // 
            // grdReceipt
            // 
            grdReceipt.BackgroundColor = SystemColors.ButtonHighlight;
            grdReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdReceipt.Location = new Point(11, 39);
            grdReceipt.Margin = new Padding(3, 2, 3, 2);
            grdReceipt.Name = "grdReceipt";
            grdReceipt.RowHeadersWidth = 51;
            grdReceipt.Size = new Size(524, 362);
            grdReceipt.TabIndex = 30;
            grdReceipt.CellClick += grdReceipt_CellClick;
            // 
            // grdOrder
            // 
            grdOrder.BackgroundColor = SystemColors.ButtonHighlight;
            grdOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOrder.Location = new Point(541, 39);
            grdOrder.Margin = new Padding(3, 2, 3, 2);
            grdOrder.Name = "grdOrder";
            grdOrder.RowHeadersWidth = 51;
            grdOrder.Size = new Size(324, 362);
            grdOrder.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(189, 22);
            label1.TabIndex = 1;
            label1.Text = "Receipt information";
            // 
            // receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(mainboard);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            mainboard.ResumeLayout(false);
            mainboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdReceipt).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainboard;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private DataGridView grdOrder;
        private TextBox textBox7;
        private ComboBox comboBox2;
        private DataGridView grdReceipt;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox date_cb;
        private ComboBox staff_cb;
    }
}