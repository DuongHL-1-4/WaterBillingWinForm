using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD00535_HoDucDuong_ASM_Part2
{
    public class Customer :IComparable<Customer>
    {
        public string CustomerName { get; set; }
        public double LastMonthReading { get; set; }
        public double ThisMonthReading { get; set; }
        public double Consumption { get; set; }
        public string CustomerType { get; set; }
        public double TotalWaterBill { get; set; }

        public Customer(string customerName, double lastMonthReading, double thisMonthReading,
            double consumption, string customerType, double totalWaterBill)
        {
            CustomerName = customerName;
            LastMonthReading = lastMonthReading;
            ThisMonthReading = thisMonthReading;
            Consumption = consumption;
            CustomerType = customerType;
            TotalWaterBill = totalWaterBill;
        }
        public int CompareTo(Customer other)
        {
            return this.CustomerName.CompareTo(other.CustomerName);
        }
    }
}
