using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsNorthwind);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNorthwind.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsNorthwind.Customers);
            //код для создания нового столбца в DataTable
            DataColumn Location = new DataColumn("Location");
            Location.Expression = "City + ',' + Country";
            dsNorthwind.Customers.Columns.Add(Location);
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn LocationColumn = new DataGridViewTextBoxColumn();
            LocationColumn.Name = "LocationColumn";
            LocationColumn.HeaderText = "Location";
            LocationColumn.DataPropertyName = "Location";
            customersDataGridView.Columns.Add(LocationColumn);
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            try
            {
                customersDataGridView.Columns.Remove("LocationColumn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnGetClickedCell_Click(object sender, EventArgs e)
        {
            string CurrentCellInfo; //переменная для хранения информации о выбранной ячейке
            //объявленная переменная будет хранить содержимое выбранной ячейки
            CurrentCellInfo = 
                customersDataGridView.CurrentCell.Value.ToString() + Environment.NewLine;

            CurrentCellInfo += "Column: " +
                customersDataGridView.CurrentCell.OwningColumn.DataPropertyName + Environment.NewLine;
            CurrentCellInfo += "Column Index: " +
                customersDataGridView.CurrentCell.ColumnIndex.ToString() + Environment.NewLine;
            CurrentCellInfo += "Row Index: " +
                customersDataGridView.CurrentCell.RowIndex.ToString() + Environment.NewLine;

            lblCurrentCellInfo.Text = CurrentCellInfo;

        }

        //проверка на соответствие правилам ввода
        private void customersDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (customersDataGridView.Columns[e.ColumnIndex].DataPropertyName=="ContactName")
            {
                if (e.FormattedValue.ToString() == "")
                {
                    customersDataGridView.Rows[e.RowIndex].ErrorText =
                        "ContactName is a requered field";
                    e.Cancel = true;
                }
                else customersDataGridView.Rows[e.RowIndex].ErrorText = "";
            }
        }

        private void btnApplyStyle_Click(object sender, EventArgs e)
        {
            customersDataGridView.AlternatingRowsDefaultCellStyle.BackColor =
                Color.LightBlue;
        }
    }
}
