namespace JoJosInventory.Controls
{
    public partial class PrintedProductsBase : UserControl
    {
        Controls.PrintedProducts Pp = new Controls.PrintedProducts();
        public PrintedProductsBase()
        {
            InitializeComponent();
            Pp.Dock = DockStyle.Fill;
            ShowPp();
        }

        public void ShowPp()
        {
            this.Controls.Add(Pp);
            Pp.searchFilters();
        }

        public void ShowEdit(int id)
        {
            PrintedProductsEdit Pe = new PrintedProductsEdit(id);
            Pe.Dock = DockStyle.Fill;
            this.Controls.Add(Pe);

        }
    }
}
