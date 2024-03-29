﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourceWizard
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
            // TODO: This line of code loads data into the 'dsNorthwind.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.dsNorthwind.Orders);
            // TODO: This line of code loads data into the 'dsNorthwind.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsNorthwind.Customers);

        }
    }
}
