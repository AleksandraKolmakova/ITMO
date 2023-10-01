using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable dtProducts = new DataTable();
        private DataTable dtCustomerProducts = new DataTable();    
        
        private void btnLoadCustomers_Click(object sender, EventArgs e)
        {
            daCustomers.Fill(dtProducts);
            dgvCustomersTable.DataSource = dtProducts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daCustomerProducts.Fill(dtCustomerProducts);
            dgvCustomerProducts.DataSource = dtCustomerProducts;
        }
        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            daCustomers.Update(dtProducts);
            daCustomerProducts.Update(dtCustomerProducts);
        }
    }
}
