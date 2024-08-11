using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD00535_HoDucDuong_ASM_Part2
{
    public partial class frmEnjoyCustomer : Form
    {
        public frmEnjoyCustomer()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++)
                cboNumberOfPeople.Items.Add(i);
        }

        List<Customer> ListCustomers = new List<Customer>();

        private void btnPayment_Click(object sender, EventArgs e)
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
            
            if (cboCustomerType.Text == "Household")
                MessageBox.Show($"Customer name: {txtCustomerName.Text} \n Last Month's Reading {txtLastMonthReading.Text} \n This Month's Reading: {txtThisMonthReading.Text} " +
                    $"\n Consumption: {consumption.ToString()} (m3) \n Customer Type: {cboCustomerType.Text} \n Number of People: {numberOfPeople.ToString()} " +
                    $"\n Total Water Billing: {totalWaterBill.ToString()} VND", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Customer name: {txtCustomerName.Text} \n Last Month's Reading {txtLastMonthReading.Text} \n This Month's Reading: {txtThisMonthReading.Text} " +
                    $"\n Consumption: {consumption.ToString()} (m3) \n Customer Type: {cboCustomerType.Text} " +
                    $"\n Total Water Billing: {totalWaterBill.ToString()} VND", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveCustomerData(newCustomer);
                frmMain mainForm = (frmMain)Application.OpenForms["frmMain"];
                if (mainForm != null)
                {
                    mainForm.AddCustomerToListView(newCustomer);
                }
                Reset();
            }
        }
        private void SaveCustomerData(Customer customer)
        {
            using (StreamWriter writer = new StreamWriter("customers.txt", true))
            {
                writer.WriteLine($"{customer.CustomerName};{customer.LastMonthReading};{customer.ThisMonthReading};" +
                                 $"{customer.Consumption};{customer.CustomerType};{customer.TotalWaterBill}");
            }
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

        private void cboCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomerType.Text == "Household")
            {
                cboNumberOfPeople.Enabled = true;
            }
            else
            {
                cboNumberOfPeople.Enabled = false;
                cboNumberOfPeople.SelectedIndex = -1;
                cboCustomerType.Text = string.Empty;
            }
        }

        private void Reset()
        {
            txtCustomerName.Text = string.Empty;
            txtLastMonthReading.Text = string.Empty;
            txtThisMonthReading.Text = string.Empty;
            cboNumberOfPeople.Enabled = false;
            txtCustomerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSignIn signIn = new frmSignIn();
            signIn.ShowDialog();
            signIn.Hide();
        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            frmShowListCustomer showListCustomer = new frmShowListCustomer();
            showListCustomer.Show();
            this.Hide();
        }
    }
}
