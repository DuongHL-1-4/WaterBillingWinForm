using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BD00535_HoDucDuong_ASM_Part2
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }
        private void frmSignIn_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += frmSignIn_KeyUp;
            
        }

        private void frmSignIn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignIn_Click(sender, e);
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassWord.Text == "admin")
            {
                frmMain waterBill = new frmMain();
                waterBill.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEnjoy_Click(object sender, EventArgs e)
        {
            frmEnjoyCustomer enjoyCustomer = new frmEnjoyCustomer();
            enjoyCustomer.Show();
            this.Hide();
        }
    }
}
