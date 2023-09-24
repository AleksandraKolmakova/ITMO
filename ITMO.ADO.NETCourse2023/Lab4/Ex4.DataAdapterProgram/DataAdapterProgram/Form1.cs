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

namespace DataAdapterProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection NorthwindConnection = 
            new SqlConnection("Data Source=DESKTOP-ILCCTBA\\SQLEXPRESS;" +
                "Initial Catalog=northwnd;" +
                "Integrated Security=True");
        private SqlDataAdapter SqlDataAdapter1;
        private DataSet NorthwindDataSet = new DataSet("Northwind");
        private DataTable CustomersTable = new DataTable("Customers");

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM Customers", NorthwindConnection);
            NorthwindDataSet.Tables.Add(CustomersTable);
            SqlDataAdapter1.Fill(NorthwindDataSet.Tables["Customers"]);
            dataGridView1.DataSource = NorthwindDataSet.Tables["Customers"];

            SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.EndInit();
            SqlDataAdapter1.Update(NorthwindDataSet.Tables["Customers"]);
        }
    }
}
