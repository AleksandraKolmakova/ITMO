using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BindingSource productsBindingSource;

       

        private void Form1_Load(object sender, EventArgs e)
        {
            //загрузка данных в таблицу Products
            productsTableAdapter1.Fill(dsNorthwind1.Products);
            //создание BindingSource для таблицы Products
            productsBindingSource = new BindingSource(dsNorthwind1, "Products");
            //настройка связывания для txt
            txtProductID.DataBindings.Add("Text", productsBindingSource, "ProductID");
            txtProductName.DataBindings.Add("Text", productsBindingSource, "ProductName");
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveLast();
        }
    }
}
