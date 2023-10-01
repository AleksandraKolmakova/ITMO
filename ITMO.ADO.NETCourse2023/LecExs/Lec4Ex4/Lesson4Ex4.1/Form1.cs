using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4Ex4._1
{ 
    
    public partial class Form1 : Form
    {
        private int dvFilter = -1;
        private CurrencyManager cmProducts;
    public Form1()
        {
            InitializeComponent();
            try
            {
                dataSet1.ReadXml(@"data.xml");
            }
            catch (Exception)
            {

                MessageBox.Show("Input file is not found");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtProducts = dataSet1.Tables[0];
            txtProductName.DataBindings.Add("Text", dtProducts, "ProductName");

            cmProducts = (CurrencyManager)(this.BindingContext[dtProducts]);
            cmProducts.Position = 0;

            dataView1.RowFilter = "Qty >" + dvFilter.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataSet1.WriteXml(@"data.xml");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            cmProducts.Position = 0;
        }

        private void btnPrevis_Click(object sender, EventArgs e)
        {
            if(cmProducts.Position != 0)
                cmProducts.Position -= 1;
        }

         private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmProducts.Position != cmProducts.Count - 1)
            {
                cmProducts.Position += 1;
            }
        }

    private void btnLast_Click(object sender, EventArgs e)
        {
            cmProducts.Position = cmProducts.Count - 1;
        }

        private void btbIncr_Click(object sender, EventArgs e)
        {
            dvFilter++;
            dataView1.RowFilter = "Qty >" + dvFilter.ToString();
        }
    }
}
