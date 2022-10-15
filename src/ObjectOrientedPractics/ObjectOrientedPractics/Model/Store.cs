using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        private List<Item> _items;

        private List<Customer> _customers;

        public Store(List<Item> items, List<Customer> customers)
        {
            Items = items;
            Customers = customers;
        }

        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }

        public List<Item> Items
        {
            get 
            { 
                return _items; 
            }

            set 
            { 
                _items = value; 
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }

            set
            {
                _customers = value;
            }
        }
    }
}
