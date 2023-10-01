using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTran_Click(object sender, EventArgs e)
        {
            cnNorthwindt.Open();
            SqlTransaction tran = cnNorthwindt.BeginTransaction(IsolationLevel.ReadCommitted);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnNorthwindt;
            cmd.Transaction = tran;

            try
            {
                cmd.CommandText = "DELETE [Order Details] WHERE ProductID = 42";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE Products WHERE ProductID = 42";
                cmd.ExecuteNonQuery();

                tran.Commit();
                MessageBox.Show("Transaction commited");
            }

            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Transaction rolled back");
            }
            finally
            {
                cnNorthwindt.Close();
            }
        }
    }
}
