using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4.LINQsql_m
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTheBest10Products_Click(object sender, EventArgs e)
        {
            var db = new DataClassesProcDataContext();
            foreach (var r in db.Ten_Most_Expensive_Products())
            {
                ListViewItem item =
                lstTheBest10Products.Items.Add(r.TenMostExpensiveProducts.ToString());
                item.SubItems.Add(r.UnitPrice.ToString());
            }

        }
    }
}
