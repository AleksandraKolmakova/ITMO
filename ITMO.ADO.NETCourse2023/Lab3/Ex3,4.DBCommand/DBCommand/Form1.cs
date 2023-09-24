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

namespace DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDtQuery_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            cmdDtQuery.CommandType = CommandType.Text;

            cnNorthwind.Open();
            SqlDataReader reader = cmdDtQuery.ExecuteReader();
            bool MoreResults = false;
            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                MoreResults = reader.NextResult();
            } while (MoreResults);
            MoreResults = reader.NextResult();

            reader.Close();
            cmdDtQuery.Connection.Close();
            ResultsTextBox.Text = results.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlCommand cmdCustomers = new SqlCommand(
                "SELECT CustomerID, CompanyName\r\nFROM Customers", cnNorthwind);
            cnNorthwind.Open();
            SqlDataReader rdrProducts;
            rdrProducts = cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdrProducts.Read())
            {
                lstCust.Items.Add(rdrProducts.GetString(0) + "\t"
                    + rdrProducts.GetString(1));
            }
            rdrProducts.Close();
        }

        private void btnMostExpProd_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            cmdTenMostExpProd.CommandType = CommandType.StoredProcedure;
            cmdTenMostExpProd.CommandText = "Ten Most Expensive Products";

            cnNorthwind.Open();
            SqlDataReader reader = cmdTenMostExpProd.ExecuteReader();
            bool Results = false;
            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t" + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                Results = reader.NextResult();
            } while (Results);
            Results = reader.NextResult();

            reader.Close();
            cmdTenMostExpProd.Connection.Close();
            txtMostExpProd.Text = results.ToString();
        }

        private void btnCreateTb_Click(object sender, EventArgs e)
        {
            try
            {
                cmdCreateTable.CommandType = CommandType.Text;
                cmdCreateTable.CommandText = "CREATE TABLE SalesPersons (" +
                   "[SalesPersonID] [int] IDENTITY(1,1) NOT NULL, " +
                   "[FirstName] [nvarchar](50)  NULL, " +
                   "[LastName] [nvarchar](50)  NULL)";
                cnNorthwind.Open();
                cmdCreateTable.ExecuteNonQuery();
                MessageBox.Show("New table SalesPersons created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Table SalesPersons already exists");
            }
            cnNorthwind.Close();
        }

        private void btnParReq_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            cmdParametrRequest.CommandType = CommandType.Text;
            cmdParametrRequest.Parameters["@City"].Value = txtCity.Text;

            cnNorthwind.Open();
            SqlDataReader reader = cmdParametrRequest.ExecuteReader();
            bool Results = false;
            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t" + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                Results = reader.NextResult();
            } while (Results);
            Results = reader.NextResult();

            reader.Close();
            cmdParametrRequest.Connection.Close();
            txtResultsCity.Text = results.ToString();
        }

        private void btnParamStorProc_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            cmdParamStorProc.CommandType = CommandType.StoredProcedure;
            cmdParamStorProc.CommandText = "SalesByCategory";
            cmdParamStorProc.Parameters["@CategoryName"].Value = txtCategoryName.Text;
            cmdParamStorProc.Parameters["@OrdYear"].Value = txtOrdYear.Text;

            cnNorthwind.Open();
            SqlDataReader reader = cmdParamStorProc.ExecuteReader();
            bool Results = false;
            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t" + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                Results = reader.NextResult();
            } while (Results);
            Results = reader.NextResult();

            reader.Close();
            cmdParamStorProc.Connection.Close();
            txtResultsParStProc.Text = results.ToString();
        }
    }
}
