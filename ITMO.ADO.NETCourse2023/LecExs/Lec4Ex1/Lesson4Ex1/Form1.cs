using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                dsStudents.ReadXml(@"data.xml");
            }
            catch (Exception)
            {

                MessageBox.Show("Unable to read input data file");
            }
        }

        private void btnLogRow_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dsStudents.Tables["Students"].Rows)
            {
                Console.WriteLine(dr);
                //Console.WriteLine(dsStudents.Tables["Students"].TableName);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dsStudents.WriteXml(@"data.xml");
        }
    }
}
