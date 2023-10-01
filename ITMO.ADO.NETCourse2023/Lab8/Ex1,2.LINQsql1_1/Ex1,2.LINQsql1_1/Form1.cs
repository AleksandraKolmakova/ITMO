using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ex1_3.LINQsql1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomersAndCities_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext
                (@"Data Source = DESKTOP-ILCCTBA\SQLEXPRESS; Initial Catalog = northwnd;
                    Integrated Security = True"); //входная точка в базу

            var results = from c in db.GetTable<Customer>()
                          where c.City == "London"
                          select c; 
            foreach ( var c in results ) 
            lstCustomersAndCities.Items.Add(c.ToString());
         }

        private void btnCustomersOrders_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext
                (@"Data Source = DESKTOP-ILCCTBA\SQLEXPRESS; Initial Catalog = northwnd;
                    Integrated Security = True"); //входная точка в базу
          var custQuery =
          from cust in db.GetTable<Customer>()
          where cust.Orders.Any()
          select cust;
            foreach (var custObj in custQuery)
            {
                ListViewItem item =
                    lstCustomersOrders.Items.Add(custObj.CustomerID.ToString());
                item.SubItems.Add(custObj.City.ToString());
                item.SubItems.Add(custObj.Orders.Count.ToString());
            }

        }
    }
}
