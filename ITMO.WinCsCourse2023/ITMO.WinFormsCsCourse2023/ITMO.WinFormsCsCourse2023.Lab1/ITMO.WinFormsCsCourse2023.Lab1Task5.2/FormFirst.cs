using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinCSCourse2023.Lab1.Task5._2
{
    public partial class FormFirst : Form
    {
        public FormFirst()
        {
            InitializeComponent();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
           
            {
                myPath.AddLines(new[]
                    {
                new Point(0, Height / 2),
                new Point(Width / 2, 0),
                new Point(Width, Height / 2),
                new Point(Width / 2, Height)
            });
                
                Region myRegion = new Region(myPath);
                this.Region = myRegion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
