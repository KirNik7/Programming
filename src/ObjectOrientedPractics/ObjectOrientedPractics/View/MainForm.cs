using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        /// <summary>
        /// Предоставляет реализацию расположения элементов на форме.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = Store.Items;
            CustomersTab.Customers = Store.Customers;
            CartsTab.Items = Store.Items;
            CartsTab.Customers = Store.Customers;
            OrdersTab.Customers = Store.Customers;
        }

        /// <summary>
        /// Возвращает и задаёт информацию о магазине (товары и покупатели).
        /// </summary>
        public Store Store 
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
            }
        }

        private void SelectedTabChanged(object sender, System.EventArgs e)
        {
            CartsTab.RefrechData();
        }
    }
}
