using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public OrdersTab()
        {
            InitializeComponent();
        }

        public List<Customer> Customers { get; set; }

        public void UpdateOrders()
        {
            List<Customer> customers = Customers;

            List<Order> orders = new List<Order>();

            foreach (var customer in customers)
            {
                orders.AddRange(customer.Orders);
            }
        }
    }
}
