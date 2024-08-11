namespace BD00535_HoDucDuong_ASM_Part2
{
    partial class frmEnjoyCustomer
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
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboNumberOfPeople = new System.Windows.Forms.ComboBox();
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboCustomerType = new System.Windows.Forms.ComboBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtThisMonthReading = new System.Windows.Forms.TextBox();
            this.lblThisMonth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLastMonthReading = new System.Windows.Forms.TextBox();
            this.lblLastMonth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblWaterBill = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnListCustomer = new System.Windows.Forms.Button();
            this.groupBoxInformation.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.panel5);
            this.groupBoxInformation.Controls.Add(this.panel4);
            this.groupBoxInformation.Controls.Add(this.panel3);
            this.groupBoxInformation.Controls.Add(this.panel2);
            this.groupBoxInformation.Controls.Add(this.panel1);
            this.groupBoxInformation.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformation.Location = new System.Drawing.Point(12, 74);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(770, 320);
            this.groupBoxInformation.TabIndex = 2;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboNumberOfPeople);
            this.panel5.Controls.Add(this.lblNumberOfPeople);
            this.panel5.Location = new System.Drawing.Point(15, 255);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(739, 54);
            this.panel5.TabIndex = 5;
            // 
            // cboNumberOfPeople
            // 
            this.cboNumberOfPeople.Enabled = false;
            this.cboNumberOfPeople.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumberOfPeople.FormattingEnabled = true;
            this.cboNumberOfPeople.Location = new System.Drawing.Point(356, 6);
            this.cboNumberOfPeople.Name = "cboNumberOfPeople";
            this.cboNumberOfPeople.Size = new System.Drawing.Size(380, 41);
            this.cboNumberOfPeople.TabIndex = 5;
            this.cboNumberOfPeople.Text = "1";
            this.cboNumberOfPeople.SelectedIndexChanged += new System.EventHandler(this.cboCustomerType_SelectedIndexChanged);
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPeople.Location = new System.Drawing.Point(3, 9);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(190, 33);
            this.lblNumberOfPeople.TabIndex = 0;
            this.lblNumberOfPeople.Text = "Number Of People";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboCustomerType);
            this.panel4.Controls.Add(this.lblCustomerType);
            this.panel4.Location = new System.Drawing.Point(15, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(739, 54);
            this.panel4.TabIndex = 4;
            // 
            // cboCustomerType
            // 
            this.cboCustomerType.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerType.FormattingEnabled = true;
            this.cboCustomerType.Items.AddRange(new object[] {
            "Household",
            "Administrative agency, public services",
            "Production units",
            "Business services"});
            this.cboCustomerType.Location = new System.Drawing.Point(356, 6);
            this.cboCustomerType.Name = "cboCustomerType";
            this.cboCustomerType.Size = new System.Drawing.Size(380, 41);
            this.cboCustomerType.TabIndex = 4;
            this.cboCustomerType.Text = "Household";
            this.cboCustomerType.SelectedIndexChanged += new System.EventHandler(this.cboCustomerType_SelectedIndexChanged);
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(3, 9);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(156, 33);
            this.lblCustomerType.TabIndex = 0;
            this.lblCustomerType.Text = "Customer Type";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtThisMonthReading);
            this.panel3.Controls.Add(this.lblThisMonth);
            this.panel3.Location = new System.Drawing.Point(15, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 54);
            this.panel3.TabIndex = 3;
            // 
            // txtThisMonthReading
            // 
            this.txtThisMonthReading.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThisMonthReading.Location = new System.Drawing.Point(356, 6);
            this.txtThisMonthReading.Name = "txtThisMonthReading";
            this.txtThisMonthReading.Size = new System.Drawing.Size(380, 38);
            this.txtThisMonthReading.TabIndex = 3;
            // 
            // lblThisMonth
            // 
            this.lblThisMonth.AutoSize = true;
            this.lblThisMonth.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisMonth.Location = new System.Drawing.Point(3, 9);
            this.lblThisMonth.Name = "lblThisMonth";
            this.lblThisMonth.Size = new System.Drawing.Size(227, 33);
            this.lblThisMonth.TabIndex = 0;
            this.lblThisMonth.Text = "This Month\'s Reading";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLastMonthReading);
            this.panel2.Controls.Add(this.lblLastMonth);
            this.panel2.Location = new System.Drawing.Point(15, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 54);
            this.panel2.TabIndex = 2;
            // 
            // txtLastMonthReading
            // 
            this.txtLastMonthReading.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastMonthReading.Location = new System.Drawing.Point(356, 6);
            this.txtLastMonthReading.Name = "txtLastMonthReading";
            this.txtLastMonthReading.Size = new System.Drawing.Size(380, 38);
            this.txtLastMonthReading.TabIndex = 2;
            // 
            // lblLastMonth
            // 
            this.lblLastMonth.AutoSize = true;
            this.lblLastMonth.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMonth.Location = new System.Drawing.Point(3, 9);
            this.lblLastMonth.Name = "lblLastMonth";
            this.lblLastMonth.Size = new System.Drawing.Size(230, 33);
            this.lblLastMonth.TabIndex = 0;
            this.lblLastMonth.Text = "Last Month\'s Reading";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 54);
            this.panel1.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(356, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(380, 38);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(3, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(166, 33);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(574, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 61);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(52, 406);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(168, 61);
            this.btnPayment.TabIndex = 14;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblWaterBill
            // 
            this.lblWaterBill.AutoSize = true;
            this.lblWaterBill.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterBill.Location = new System.Drawing.Point(283, 14);
            this.lblWaterBill.Name = "lblWaterBill";
            this.lblWaterBill.Size = new System.Drawing.Size(218, 57);
            this.lblWaterBill.TabIndex = 2;
            this.lblWaterBill.Text = "Water Bill";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(400, 406);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(168, 61);
            this.btnSignIn.TabIndex = 12;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnListCustomer
            // 
            this.btnListCustomer.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCustomer.Location = new System.Drawing.Point(226, 406);
            this.btnListCustomer.Name = "btnListCustomer";
            this.btnListCustomer.Size = new System.Drawing.Size(168, 61);
            this.btnListCustomer.TabIndex = 12;
            this.btnListCustomer.Text = "List Customer";
            this.btnListCustomer.UseVisualStyleBackColor = true;
            this.btnListCustomer.Click += new System.EventHandler(this.btnListCustomer_Click);
            // 
            // frmEnjoyCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 479);
            this.Controls.Add(this.lblWaterBill);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnListCustomer);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBoxInformation);
            this.Name = "frmEnjoyCustomer";
            this.Text = "Payment";
            this.groupBoxInformation.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboCustomerType;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtThisMonthReading;
        private System.Windows.Forms.Label lblThisMonth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLastMonthReading;
        private System.Windows.Forms.Label lblLastMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblWaterBill;
        private System.Windows.Forms.ComboBox cboNumberOfPeople;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnListCustomer;
    }
}