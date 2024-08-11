using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD00535_HoDucDuong_ASM_Part2
{
    public partial class frmShowListCustomer : Form
    {
        public frmShowListCustomer()
        {
            InitializeComponent();
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            List<Customer> ListCustomers = new List<Customer>();

            if (File.Exists("customers.txt"))
            {
                using (StreamReader reader = new StreamReader("customers.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');

                        if (parts.Length < 6)
                        {
                            continue;
                        }

                        string customerName = parts[0];
                        if (!double.TryParse(parts[1], out double lastMonthReading) ||
                            !double.TryParse(parts[2], out double thisMonthReading) ||
                            !double.TryParse(parts[3], out double consumption) ||
                            !double.TryParse(parts[5], out double totalWaterBill))
                        {
                            continue;
                        }

                        string customerType = parts[4];
                        Customer customer = new Customer(customerName, lastMonthReading, thisMonthReading, consumption, customerType, totalWaterBill);
                        ListCustomers.Add(customer);
                    }
                }
            }

            // Assuming you have a ListView control named lvwListCustomer on this form
            lvwListCustomer.Items.Clear();

            foreach (var customer in ListCustomers)
            {
                string[] row =
                {
                    customer.CustomerName,
                    customer.LastMonthReading.ToString(),
                    customer.ThisMonthReading.ToString(),
                    customer.Consumption.ToString() + " (m3)",
                    customer.CustomerType,
                    customer.TotalWaterBill.ToString("N2")
                };
                ListViewItem listViewItem = new ListViewItem(row);
                lvwListCustomer.Items.Add(listViewItem);
            }
        }
        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            frmShowListCustomer showListCustomer = new frmShowListCustomer();
            showListCustomer.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchCustomer.Text;

            var matchingCustomers = lvwListCustomer.Items.Cast<ListViewItem>()
                .Where(item => item.SubItems[0].Text.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (matchingCustomers.Count == 0)
            {
                MessageBox.Show("Customer with the given name not found: " + searchName, "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("You have not entered the customer name to search for!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmListCustomerFound listCustomerFoundForm = new frmListCustomerFound(matchingCustomers.Select(item => CreateCustomerFromListViewItem(item)).ToList());
                listCustomerFoundForm.Show();
                this.Hide();
            }
            Reset();
        }
        private Customer CreateCustomerFromListViewItem(ListViewItem item)
        {
            return new Customer(
                item.SubItems[0].Text,
                double.Parse(item.SubItems[1].Text),
                double.Parse(item.SubItems[2].Text),
                double.Parse(item.SubItems[3].Text.Replace(" (m3)", "")),
                item.SubItems[4].Text,
                double.Parse(item.SubItems[5].Text)
            );
        }
        private void Reset()
        {
            txtSearchCustomer.Text = string.Empty;
            txtSearchCustomer.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEnjoyCustomer enjoyCustomer = new frmEnjoyCustomer();
            enjoyCustomer.Show();
            this.Hide();
        }
    }
}
