using DataViewExample.dsNorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataView dvCustomers;
        DataView dvOrders;

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(dsNorthwind1.Customers);
            ordersTableAdapter1.Fill(dsNorthwind1.Orders);
            
            dvCustomers = new DataView(dsNorthwind1.Customers);
            dvOrders = new DataView(dsNorthwind1.Orders);

            dvCustomers.Sort = "CustomerID";

            dgvCustomerGrid.DataSource = dvCustomers;

        }

        private void btnSetDataViewProperties_Click(object sender, EventArgs e)
        {
            dvCustomers.Sort = txtSort.Text;
            dvCustomers.RowFilter = txtFilter.Text;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            DataRowView newCustomRow = dvCustomers.AddNew();
            
            newCustomRow["CustomerID"] = "WINGT";
            newCustomRow["CompanyName"] = "Wing Tip Toys";
            newCustomRow.EndEdit();

        }

        private void btnGetOrders_Click(object sender, EventArgs e)
        {
            string selectedCustomerID =
            (string)dgvCustomerGrid.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
           
            DataRowView selectedRow =
            dvCustomers[dvCustomers.Find(selectedCustomerID)];

            dvOrders =
            selectedRow.CreateChildView(dsNorthwind1.Relations
                                          ["FK_Orders_Customers"]);

            dgvDataGrid.DataSource = dvOrders;

        }
    }
}
