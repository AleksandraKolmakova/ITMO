using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les6Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable dtOrdersCustomers = new DataTable();
        private DataTable dtCustomers = new DataTable();
        private DataTable dtCustomersAll = new DataTable();


        private void btnLoadOrdersCustomers_Click(object sender, EventArgs e)
        {
            daOrdersCustomers.Fill(dtOrdersCustomers);
            dgvOrdersCustomers.DataSource = dtOrdersCustomers;
        }

       
        private void btnCloadCustomers_Click(object sender, EventArgs e)
        {
            daCustomers.Fill(dtCustomers);
            dgvCustomers.DataSource = dtCustomers;
        }
        private void btnLoadCustomersAllTable_Click(object sender, EventArgs e)
        {
            daCustomersAllTable.Fill(dtCustomersAll);
            dvgCustomersAll.DataSource = dtCustomersAll;
        }

        private void btnUpdateCustomers_Click(object sender, EventArgs e)
        {
            daCustomersAllTable.Update(dtCustomersAll);
            //daCustomers.Update(dtCustomers);
        }

        private void btnDataAdapter_Click(object sender, EventArgs e)
        {
            DataSet dsProducts = new DataSet();
            dsProducts.Tables.Add(new DataTable("Products"));
            SqlDataAdapter daProducts = new SqlDataAdapter();
            SqlCommand cmSelect = new SqlCommand
                ("SELECT * FROM Products;", sqlConnection1);
            daProducts.SelectCommand = cmSelect;

            dsProducts.Tables["Products"].BeginLoadData();
            daProducts.Fill(dsProducts, "Products");
            dsProducts.Tables["Products"].EndLoadData();

            dgvProducts.DataSource = dsProducts.Tables["Products"];
        }
    }
}
