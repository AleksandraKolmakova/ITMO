using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class KvadratnYravn : Form
    {
        public KvadratnYravn()
        {
            InitializeComponent();
        }

        public string KoefA
        {
            get { return Koefa.Text; }
            set { Koefa.Text = value; }
        }
        public string KoefB
        {
            get { return Koefb.Text; }
            set { Koefb.Text = value; }
        }
        public string KoefC
        {
            get { return Koefc.Text; }
            set { Koefc.Text = value; }
        }

        public string KorniUravneniya()
        {
            double koefA = double.Parse(Koefa.Text);
            double koefB = double.Parse(Koefb.Text);
            double koefC = double.Parse(Koefc.Text);
            double X1, X2, dicriminant;
            string otvet;
            if (koefA == 0)
            {
                X1 = -koefC / koefB;
                otvet = "1 корень: X = " + X1;
                if (koefB == 0)
                    otvet = "Уравнение не имеет корней!";
            }
            else
            {
                dicriminant = koefB * koefB - 4 * koefA * koefC;
                if (dicriminant > 0)
                {
                    X1 = Math.Round((-koefB + Math.Sqrt(dicriminant)) / (2 * koefA), 4);
                    X2 = Math.Round((-koefB - Math.Sqrt(dicriminant)) / (2 * koefA), 4);
                    otvet = "2 корня: X1 = " + X1 + ", X2 = " + X2;
                }
                else
                {
                    if (dicriminant == 0)
                    {
                        X1 = Math.Round(-koefB / (2 * koefA), 4);
                        otvet = "1 корень: X = " + X1;
                    }
                    else
                        otvet = "Уравнение не имеет корней!";
                }
            }
            return otvet;
        }
    }
}
