using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Ex1_3.LINQsql1_1
{
    [Table(Name = "Customers")] //атрибут для связи класса с таблицей БД
    public class Customer //новый класс сущностей
    {
        private string _CustomerID;
        [Column(IsPrimaryKey = true, Storage = "_CustomerID")]

        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
            }
        }

        private string _City;
        [Column(Storage = "_City")]

        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this._City = value;
            }
        }

        public override string ToString()
        {
            return CustomerID + "\t" + City;
        }

        private EntitySet<Order> _Orders;
        public Customer() 
        {
            this._Orders = new EntitySet<Order>();
        }
        [Association(Storage = "_Orders", OtherKey = "CustomerID")]
        public EntitySet<Order> Orders
        {
            get { return this._Orders; }
            set { this._Orders.Assign(value);}
        }

    }
}
