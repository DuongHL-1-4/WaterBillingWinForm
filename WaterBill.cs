using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BD00535_HoDucDuong_ASM_Part2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++)
                cboNumberOfPeople.Items.Add(i);
            LoadCustomerData();
        }

        List<Customer> ListCustomers = new List<Customer>();

        public void AddCustomerToListView(Customer customer)
        {
            ListCustomers.Add(customer);
            ListCustomers.Sort();

            lvwListCustomer.Items.Clear();

            foreach (var c in ListCustomers)
            {
                string[] row =
                {
            c.CustomerName,
            c.LastMonthReading.ToString(),
            c.ThisMonthReading.ToString(),
            c.Consumption.ToString() + " (m3)",
            c.CustomerType,
            c.TotalWaterBill.ToString("N2")
        };
                ListViewItem listViewItem = new ListViewItem(row);
                lvwListCustomer.Items.Add(listViewItem);
            }
        }

        private void SaveCustomerData()
        {
            using (StreamWriter writer = new StreamWriter("customers.txt"))
            {
                foreach (var customer in ListCustomers)
                {
                    writer.WriteLine($"{customer.CustomerName};{customer.LastMonthReading};{customer.ThisMonthReading};" +
                             $"{customer.Consumption};{customer.CustomerType};{customer.TotalWaterBill}");
                }
            }
        }

        private void LoadCustomerData()
        {
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
                        if (!double.TryParse(parts[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double lastMonthReading) ||
                            !double.TryParse(parts[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double thisMonthReading) ||
                            !double.TryParse(parts[3], NumberStyles.Any, CultureInfo.InvariantCulture, out double consumption) ||
                            !double.TryParse(parts[5], NumberStyles.Any, CultureInfo.InvariantCulture, out double totalWaterBill))
                        {
                            continue;
                        }

                        string customerType = parts[4];
                        Customer customer = new Customer(customerName, lastMonthReading, thisMonthReading, consumption, customerType, totalWaterBill);
                        ListCustomers.Add(customer);

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
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveCustomerData();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            int numberOfPeople = Convert.ToInt32(cboNumberOfPeople.Text);

            if (customerName == "")
            {
                MessageBox.Show("Enter customer name, please!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtLastMonthReading.Text, out double lastMonthReading))
            {
                MessageBox.Show("Please enter a valid numeric value for the previous month's reading!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtThisMonthReading.Text, out double thisMonthReading))
            {
                MessageBox.Show("Please enter a valid numeric value for this month's reading!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double consumption = thisMonthReading - lastMonthReading;

            if (consumption < 0)
            {
                MessageBox.Show("This month's reading cannot be less than last month's reading!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double totalWaterBill = CalculateTotalWaterBill(consumption, numberOfPeople, cboCustomerType.Text);

            Customer newCustomer = new Customer(customerName, lastMonthReading, thisMonthReading, consumption, cboCustomerType.Text, totalWaterBill);
            ListCustomers.Add(newCustomer);

            ListCustomers.Sort();

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
            Reset();
        }

        private double CalculateTotalWaterBill(double consumption, int numberOfPeople, string customerType)
        {
            double totalWaterBill = 0;
            switch (customerType)
            {
                case "Household":
                    double avgConsumption = consumption / numberOfPeople;
                    if (avgConsumption <= 10)
                    {
                        totalWaterBill = consumption * 5973 * 1.1;
                    }
                    else if (avgConsumption <= 20)
                    {
                        totalWaterBill = (10 * 5973 * 1.1 * numberOfPeople) + ((consumption - (10 * numberOfPeople)) * 7052 * 1.1);
                    }
                    else if (avgConsumption <= 30)
                    {
                        totalWaterBill = (10 * 5973 * 1.1 * numberOfPeople) + (10 * 7052 * 1.1 * numberOfPeople)
                            + ((consumption - (20 * numberOfPeople)) * 8699 * 1.1);
                    }
                    else
                    {
                        totalWaterBill = (10 * 5973 * 1.1 * numberOfPeople) + (10 * 7052 * 1.1 * numberOfPeople) + (10 * 8699 * 1.1 *
                            numberOfPeople) + ((consumption - (30 * numberOfPeople)) * 9955 * 1.1);
                    }
                    break;
                case "Administrative agency, public services":
                    totalWaterBill = consumption * 9955 * 1.1;
                    break;
                case "Production units":
                    totalWaterBill = consumption * 11615 * 1.1;
                    break;
                case "Business services":
                    totalWaterBill = consumption * 22068 * 1.1;
                    break;
                default:
                    break;
            }
            return totalWaterBill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchCustomer.Text;

            var matchingCustomers = ListCustomers.Where(c => c.CustomerName.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            if (matchingCustomers.Count == 0)
            {
                MessageBox.Show("Customer with the given name not found: " + searchName, "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (searchName == "")
            {
                MessageBox.Show("You have not entered the customer name to search for!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmListCustomerFound listCustomerFoundForm = new frmListCustomerFound(matchingCustomers);
                listCustomerFoundForm.ShowDialog();
            }
            Reset();
        }

        private void btnUpData_Click(object sender, EventArgs e)
        {
            if (lvwListCustomer.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwListCustomer.SelectedItems[0];
                string customerName = selectedItem.SubItems[0].Text;
                string lastMonthReading = selectedItem.SubItems[1].Text;
                string thisMonthReading = selectedItem.SubItems[2].Text;

                var customerToUpData = ListCustomers.FirstOrDefault(c => c.CustomerName == customerName);

                if (customerToUpData != null)
                {
                    DialogResult result = MessageBox.Show("You want to change this customer's information?!", "Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        txtCustomerName.Text = customerName;
                        txtLastMonthReading.Text = lastMonthReading;
                        txtThisMonthReading.Text = thisMonthReading;
                        ListCustomers.Remove(customerToUpData);
                        lvwListCustomer.Items.Remove(selectedItem);
                    }
                }
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {

            if (lvwListCustomer.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwListCustomer.SelectedItems[0];
                string customerName = selectedItem.SubItems[0].Text;
                string lastMonthReading = selectedItem.SubItems[1].Text;
                string thisMonthReading = selectedItem.SubItems[2].Text;
                string consumption = selectedItem.SubItems[3].Text;
                string customerType = selectedItem.SubItems[4].Text;
                string totalWaterBilling = selectedItem.SubItems[5].Text;

                var customerToInvoice = ListCustomers.FirstOrDefault(c => c.CustomerName == customerName);

                if (customerToInvoice != null)
                {
                    MessageBox.Show($"Customer Name: {customerName} \n Last month's reading: {lastMonthReading} \n This month's reading: {thisMonthReading}" +
                        $"\n Consumption: {consumption} \n Customer type: {customerType}\n ----------------------------------------------------" +
                        $"\n Total water billing: {totalWaterBilling}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvwListCustomer.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwListCustomer.SelectedItems[0];
                string customerName = selectedItem.SubItems[0].Text;

                var customerToRemove = ListCustomers.FirstOrDefault(c => c.CustomerName == customerName);

                if (customerToRemove != null)
                {
                    ListCustomers.Remove(customerToRemove);
                    lvwListCustomer.Items.Remove(selectedItem);

                    MessageBox.Show("Customer has been successfully deleted!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer not found for deletion!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Reset()
        {
            txtCustomerName.Text = string.Empty;
            txtLastMonthReading.Text = string.Empty;
            txtThisMonthReading.Text = string.Empty;
            txtSearchCustomer.Text = string.Empty;
            cboNumberOfPeople.Enabled = false;
            txtCustomerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSignIn signIn = new frmSignIn();
            signIn.ShowDialog();
            signIn.Hide();
        }

        private void cboCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomerType.Text == "Household")
            {
                cboNumberOfPeople.Enabled = true;
            }
            else
            {
                cboNumberOfPeople.Enabled = false;
                cboCustomerType.Text = string.Empty;
                cboNumberOfPeople.SelectedIndex = -1;
            }
        }
    }
}