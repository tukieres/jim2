namespace JoJosInventory.Controls
{
    public partial class PrintedProductsEdit : UserControl
    {
        bool expanded = false;
        public PrintedProductsEdit()
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

        private void FlPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control child in FlPanel.Controls)
            {
                child.Width = FlPanel.Width - 10;
            }
            dgv.Height = FlPanel.Height - pnSearch.Height - 10;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                pnSearch.Height = 38;
                expanded = false;
                btnExpand.ImageIndex = 1;

            }
            else
            {
                pnSearch.Height = 120;
                expanded = true;
                btnExpand.ImageIndex = 0;
            }
            dgv.Height = FlPanel.Height - pnSearch.Height - 10;

        }
    }
}
