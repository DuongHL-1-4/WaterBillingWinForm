namespace BD00535_HoDucDuong_ASM_Part2
{
    partial class frmListCustomerFound
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
            this.lblWaterBill = new System.Windows.Forms.Label();
            this.lvwSearchListCustomerFound = new System.Windows.Forms.ListView();
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastMonthReading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThisMonthReading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Consumption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaterBill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblWaterBill
            // 
            this.lblWaterBill.AutoSize = true;
            this.lblWaterBill.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterBill.Location = new System.Drawing.Point(282, 9);
            this.lblWaterBill.Name = "lblWaterBill";
            this.lblWaterBill.Size = new System.Drawing.Size(493, 57);
            this.lblWaterBill.TabIndex = 1;
            this.lblWaterBill.Text = "Search of Customer Found";
            // 
            // lvwSearchListCustomerFound
            // 
            this.lvwSearchListCustomerFound.AllowColumnReorder = true;
            this.lvwSearchListCustomerFound.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerName,
            this.LastMonthReading,
            this.ThisMonthReading,
            this.Consumption,
            this.CustomerType,
            this.WaterBill});
            this.lvwSearchListCustomerFound.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSearchListCustomerFound.FullRowSelect = true;
            this.lvwSearchListCustomerFound.GridLines = true;
            this.lvwSearchListCustomerFound.HideSelection = false;
            this.lvwSearchListCustomerFound.LabelEdit = true;
            this.lvwSearchListCustomerFound.Location = new System.Drawing.Point(32, 82);
            this.lvwSearchListCustomerFound.Name = "lvwSearchListCustomerFound";
            this.lvwSearchListCustomerFound.Size = new System.Drawing.Size(907, 335);
            this.lvwSearchListCustomerFound.TabIndex = 5;
            this.lvwSearchListCustomerFound.UseCompatibleStateImageBehavior = false;
            this.lvwSearchListCustomerFound.View = System.Windows.Forms.View.Details;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "Customer Name";
            this.CustomerName.Width = 150;
            // 
            // LastMonthReading
            // 
            this.LastMonthReading.Text = "Last Month\'s Reading";
            this.LastMonthReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastMonthReading.Width = 150;
            // 
            // ThisMonthReading
            // 
            this.ThisMonthReading.Text = "This Month\'s Reading";
            this.ThisMonthReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThisMonthReading.Width = 150;
            // 
            // Consumption
            // 
            this.Consumption.Text = "Consumption (m3)";
            this.Consumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Consumption.Width = 155;
            // 
            // CustomerType
            // 
            this.CustomerType.Text = "Customer Type";
            this.CustomerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerType.Width = 150;
            // 
            // WaterBill
            // 
            this.WaterBill.Text = "Water Bill (VND + 10% VAT)";
            this.WaterBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WaterBill.Width = 196;
            // 
            // frmListCustomerFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 437);
            this.Controls.Add(this.lvwSearchListCustomerFound);
            this.Controls.Add(this.lblWaterBill);
            this.Name = "frmListCustomerFound";
            this.Text = "List of Customer Found";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWaterBill;
        private System.Windows.Forms.ListView lvwSearchListCustomerFound;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader LastMonthReading;
        private System.Windows.Forms.ColumnHeader ThisMonthReading;
        private System.Windows.Forms.ColumnHeader Consumption;
        private System.Windows.Forms.ColumnHeader CustomerType;
        private System.Windows.Forms.ColumnHeader WaterBill;
    }
}