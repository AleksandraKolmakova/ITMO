using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingDataSetXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //заполнение таблиц Customers и Orders
        private void btnFillDataSet_Click(object sender, EventArgs e)
        {
            CustomerAdapter.Fill(dsNorthwind.Customers);
            OrdersAdapter.Fill(dsNorthwind.Orders);

            //связь сетки с таблицей Customers
            dgvCustomers.DataSource = dsNorthwind.Customers;
        }

        private void btnSaveXmlData_Click(object sender, EventArgs e)
        {
            try
            {
                dsNorthwind.WriteXml("Northwind.xml");
                MessageBox.Show("Data save as XML");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveXmlSchema_Click(object sender, EventArgs e)
        {
            try
            {
                dsNorthwind.WriteXmlSchema("Northwind.xsd");
                MessageBox.Show("Schema save as XML");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
