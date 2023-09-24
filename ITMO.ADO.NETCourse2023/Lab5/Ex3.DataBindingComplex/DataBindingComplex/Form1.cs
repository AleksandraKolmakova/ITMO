using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingComplex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBindingGrid_Click(object sender, EventArgs e)
        {
            //заполнение таблицы Products данными из БД
            productsTableAdapter1.Fill(northwndDataSet1.Products);
            //создание нового компонента BindingSource для таблицы Products
            BindingSource bsProducts = new BindingSource(northwndDataSet1, "Products");
            //связь сетки с компонентом BindingSource
            gdvProducts.DataSource = bsProducts;
            //связь навигатора с компонентом BindingSource
            bindingNavigator1.BindingSource = bsProducts;
        }
    }
}
