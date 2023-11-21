using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JoJosInventory.Controls
{
    public partial class PrintedProductsAdd : UserControl
    {
        public PrintedProductsAdd()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CloseMe();
        }

        private void CloseMe()
        {
            PrintedProductsBase ppb = (PrintedProductsBase)this.Parent;
            ppb.ShowPp();
            this.Parent.Controls.Remove(this);
            this.Dispose();

        }

        private void label_Click(object sender, EventArgs e)
        {
            CloseMe();
        }

        private void lblBack_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

    }
}
