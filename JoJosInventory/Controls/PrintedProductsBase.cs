using System;
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
        }
    }
}
