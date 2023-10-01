using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCheapest_Click(object sender, EventArgs e)
        {
            cnNorthwind.Open();
            String res = String.Format("{0}", cmdProductCount.ExecuteScalar());
            txtproductCnt.Text = res;
            cnNorthwind.Close();
        }

        private void txtMaxPrice_TextChanged(object sender, EventArgs e)
        {
            cnNorthwind.Open();
            try
            {
                cmdCheapProducts.Parameters["@price"].Value = Convert.ToDecimal(txtMaxPrice.Text);
               
                //без параметра, не безопасно (безконтрольный пользовательский ввод)
                /*cmdCheapProducts.CommandText = "SELECT ProductName, UnitPrice\r\nFROM Products\r\nWHERE (Uni" +
                "tPrice < " + txtMaxPrice.Text + ")\r\nORDER BY UnitPrice DESC";*/
            }
            catch (FormatException)
            {
                cmdCheapProducts.Parameters["@price"].Value = 0;
            }
            String res = (String)cmdCheapProducts.ExecuteScalar();
            txtExpensiveProduct.Text = res;
            cnNorthwind.Close();
        }
    }
}
