using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterWixard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindtDataSet1.Customers;
            sqlDataAdapter1.Fill(northwindtDataSet1.Customers);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(northwindtDataSet1);
        }

        private void sqlDataAdapter1_RowUpdating(object sender, System.Data.SqlClient.SqlRowUpdatingEventArgs e)
        {
            NorthwindtDataSet.CustomersRow CustRow = (NorthwindtDataSet.CustomersRow)e.Row;

            //диалоговое окно для подтверждения обновления
            DialogResult response = MessageBox.Show("Continue updating " 
                + CustRow.CustomerID.ToString() +
                "?", "Continue Update?", MessageBoxButtons.YesNo);

            //отменa обновления, если пользователь выбрал Нет
            if (response == DialogResult.No)
            {
                e.Status = UpdateStatus.SkipCurrentRow;
            }
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            NorthwindtDataSet.CustomersRow CustRow = (NorthwindtDataSet.CustomersRow)e.Row;
            MessageBox.Show(CustRow.CustomerID.ToString() + " has been updated");

            //сброс таблицы после обновления строки для отражения изменений
            northwindtDataSet1.Customers.Clear();
            sqlDataAdapter1.Fill(northwindtDataSet1.Customers);
        }

        private void sqlDataAdapter1_FillError(object sender, FillErrorEventArgs e)
        {
            DialogResult response = MessageBox.Show("The following error occurred " +
                "while Filling the DataSet: " + e.Errors.Message.ToString() +
 " Continue attempting to fill?", "FillError Encountered", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                e.Continue = true;
            }
            else
            {
                e.Continue = false;
            }
        }
    }
}
