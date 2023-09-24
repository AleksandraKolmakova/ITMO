using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = dsNorthwind.Customers;
            dgvCustomer.MultiSelect = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCustomer.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

      


        private void btnFillTable_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(dsNorthwind.Customers);
        }

        private void bntAddRow_Click(object sender, EventArgs e)
        {
            dsNorthwind.CustomersRow NewRow = (dsNorthwind.CustomersRow)
                dsNorthwind.Customers.NewRow();

            NewRow.CustomerID = "WINGT";
            NewRow.CompanyName = "Wingtip";
            NewRow.ContactName = "Steve Lasker";
            NewRow.ContactTitle = "CEO";
            NewRow.Address = "1234 Main Street";
            NewRow.City = "Buffalo";
            NewRow.Region = "NY";
            NewRow.PostalCode = "98052";
            NewRow.Country = "USA";
            NewRow.Phone = "206-555-0111";
            NewRow.Fax = "206-555-0112";


            try
            {
                dsNorthwind.Customers.Rows.Add(NewRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Row Failed");
            }
        }

        private dsNorthwind.CustomersRow GetSelectedRow()
        {
            String SelectedCustomerID = dgvCustomer.CurrentRow.Cells["CustomerID"].Value.ToString();
            dsNorthwind.CustomersRow SelectedRow =
            dsNorthwind.Customers.FindByCustomerID(SelectedCustomerID);
            return SelectedRow;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }

        private void UpdateRowVersionDisplay()
        {
            try
            {
                txtCurrentDRV.Text = GetSelectedRow()[dgvCustomer.CurrentCell.OwningColumn.Name, 
                    DataRowVersion.Current].ToString();
            }
            catch (Exception ex)
            {
                txtCurrentDRV.Text = ex.Message;
            }

            try
            {
                txtOriginalDRV.Text = GetSelectedRow()[dgvCustomer.CurrentCell.OwningColumn.Name,
                    DataRowVersion.Original].ToString();
            }
            catch (Exception ex)
            {
                txtOriginalDRV.Text = ex.Message;
            }

            txtRowState.Text = GetSelectedRow().RowState.ToString();
        }

        private void btnUpdateValue_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[dgvCustomer.CurrentCell.OwningColumn.Name] = 
                txtCellValue.Text;
            UpdateRowVersionDisplay();
        }

        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            txtCellValue.Text = dgvCustomer.CurrentCell.Value.ToString();
            UpdateRowVersionDisplay();
        }

        private void btnAcceptChanges_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            UpdateRowVersionDisplay();
        }

        private void btnRegectChanges_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            UpdateRowVersionDisplay();
        }
    }
}
