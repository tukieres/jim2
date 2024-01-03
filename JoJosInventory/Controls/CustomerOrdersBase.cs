namespace JoJosInventory.Controls
{
    public partial class CustomerOrdersBase : UserControl
    {        
        CustomerOrders Co = new Controls.CustomerOrders();
        public CustomerOrdersBase()
        {
            InitializeComponent();
            Co.Dock = DockStyle.Fill;
            ShowCo();
        }

        public void ShowCo()
        {
            this.Controls.Add(Co);
            //Co.searchFilters();
        }

        public void ShowEdit(int id)
        {
            PrintedProductsEdit Pe = new PrintedProductsEdit(id);
            Pe.Dock = DockStyle.Fill;
            this.Controls.Add(Pe);

        }
    }
}
