namespace BD00535_HoDucDuong_ASM_Part2
{
    partial class frmShowListCustomer
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
            this.lvwListCustomer = new System.Windows.Forms.ListView();
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastMonthReading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThisMonthReading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Consumption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaterBill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.lblWaterBill = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwListCustomer
            // 
            this.lvwListCustomer.AllowColumnReorder = true;
            this.lvwListCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerName,
            this.LastMonthReading,
            this.ThisMonthReading,
            this.Consumption,
            this.CustomerType,
            this.WaterBill});
            this.lvwListCustomer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwListCustomer.FullRowSelect = true;
            this.lvwListCustomer.GridLines = true;
            this.lvwListCustomer.HideSelection = false;
            this.lvwListCustomer.LabelEdit = true;
            this.lvwListCustomer.Location = new System.Drawing.Point(22, 69);
            this.lvwListCustomer.Name = "lvwListCustomer";
            this.lvwListCustomer.Size = new System.Drawing.Size(908, 335);
            this.lvwListCustomer.TabIndex = 5;
            this.lvwListCustomer.UseCompatibleStateImageBehavior = false;
            this.lvwListCustomer.View = System.Windows.Forms.View.Details;
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
            this.WaterBill.Width = 150;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(687, 419);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 61);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(301, 428);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(380, 38);
            this.txtSearchCustomer.TabIndex = 10;
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomer.Location = new System.Drawing.Point(29, 433);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(266, 33);
            this.lblSearchCustomer.TabIndex = 9;
            this.lblSearchCustomer.Text = "Search Customer By Name";
            // 
            // lblWaterBill
            // 
            this.lblWaterBill.AutoSize = true;
            this.lblWaterBill.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterBill.Location = new System.Drawing.Point(373, 9);
            this.lblWaterBill.Name = "lblWaterBill";
            this.lblWaterBill.Size = new System.Drawing.Size(275, 57);
            this.lblWaterBill.TabIndex = 12;
            this.lblWaterBill.Text = "List Customer";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(809, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 61);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmShowListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 506);
            this.Controls.Add(this.lblWaterBill);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.lvwListCustomer);
            this.Name = "frmShowListCustomer";
            this.Text = "List Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwListCustomer;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader LastMonthReading;
        private System.Windows.Forms.ColumnHeader ThisMonthReading;
        private System.Windows.Forms.ColumnHeader Consumption;
        private System.Windows.Forms.ColumnHeader CustomerType;
        private System.Windows.Forms.ColumnHeader WaterBill;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.Label lblWaterBill;
        private System.Windows.Forms.Button btnBack;
    }
}