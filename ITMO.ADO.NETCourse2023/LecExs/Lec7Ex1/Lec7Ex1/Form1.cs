using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec7Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadCards_Click(object sender, EventArgs e)
        {
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };
            foreach (var card in startingDeck) 
            {
                lvCards.Items.Add(card.ToString());
            }

            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            foreach (var card in top)
            {
                lblCard.Text += card.ToString();
            }
        }

        static IEnumerable<string> Suits()
        {
            yield return "Clubs";
            yield return "Diamonds";
            yield return "Hearts";
            yield return "Spades";
        }

        static IEnumerable <string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }

        private void btnLINQ_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(cnNorthwind);

            //создание экземпляров классов
            /*Customer newCustomer = new Customer();
            newCustomer.ContactName = "Kolmakova Aleksandra";
            newCustomer.ContactTitle = "None";
            newCustomer.Phone = "12345";
            newCustomer.CompanyName = "Test";
            newCustomer.CustomerID = "KOLMA";

            db.Customers.InsertOnSubmit(newCustomer); //добавить
            db.SubmitChanges(); // сохранить*/

            Customer findCustomer = 
                db.Customers.FirstOrDefault(c => c.CustomerID.Equals("KOLMA"));

            lvNewCustomer.Items.Add
                (findCustomer.CustomerID + " " + findCustomer.ContactName);


            findCustomer =
                db.Customers.FirstOrDefault(c => c.CustomerID.Equals("ALFKI"));
            lvNewCustomer.Items.Add
                (findCustomer.CustomerID + " " + findCustomer.ContactName);
        }
    }
}
