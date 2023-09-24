using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadDataSetXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet dsNorthwind = new DataSet();

        private void btnLoadSchema_Click(object sender, EventArgs e)
        {
            //загрузка сведения схемы из файла.xsd:
            dsNorthwind.ReadXmlSchema("Northwind.xsd");
            //связь gdvCustomers и gdvOrders для отображения данных:
            gdvCustomers.DataSource = dsNorthwind.Tables["Customers"];
            gdvOrders.DataSource = dsNorthwind.Tables["Orders"];

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            //загрузка данных в набор данных
            dsNorthwind.ReadXml("Northwind.xml");
        }
    }
}
