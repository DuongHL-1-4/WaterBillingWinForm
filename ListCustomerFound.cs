using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD00535_HoDucDuong_ASM_Part2
{
    public partial class frmListCustomerFound : Form
    {
        public frmListCustomerFound(List<Customer> foundCustomers)
        {
            InitializeComponent();
            foreach (var customer in foundCustomers)
            {
                string[] row =
                {
                    customer.CustomerName,
                    customer.LastMonthReading.ToString(),
                    customer.ThisMonthReading.ToString(),
                    customer.Consumption.ToString() + " (m3)",
                    customer.CustomerType,
                    customer.TotalWaterBill.ToString("N2") + " (VND)",
                };

                ListViewItem listViewItem = new ListViewItem(row);
                lvwSearchListCustomerFound.Items.Add(listViewItem);
            }
        }

    }
}