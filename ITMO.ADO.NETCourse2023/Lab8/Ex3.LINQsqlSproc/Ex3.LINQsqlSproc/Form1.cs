using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.LINQsqlSproc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Northwnd db = new Northwnd
            (@"c:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\northwnd.mdf");

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            //переменная для хранения содержимого txtbox в кач-ве аргумента хранимой процедуры
            string param = txtOrderID.Text;
            //переменная для хранения результатов возвращаемых хранимой процедурой
            var custquery = db.CustOrdersDetail(Convert.ToInt32(param));
            //выполнение хранимой процедуры и отображение результатов
            string msg = "";
            foreach (CustOrdersDetailResult custOrdersDetail in custquery)
            {
                msg = msg + custOrdersDetail.ProductName + "\n";
            }
            if (msg == "") 
            msg = "No results.";
            MessageBox.Show(msg);

            param = "";
            txtOrderID.Text = "";
        }

        private void btnOrderStory_Click(object sender, EventArgs e)
        {
            string param = txtClientID.Text;
            var custquery = db.CustOrderHist(param);
            string msg = "";
            foreach (CustOrderHistResult custOrderHist in custquery)
            {
                msg = msg + custOrderHist.ProductName + "\n";
            }
            if (msg == "")
                msg = "No results.";
            MessageBox.Show(msg);

            param = "";
            txtClientID.Text = "";
        }
    }
}
