using JoJosInventory.Classes;
using JoJosInventory.Data;
namespace JoJosInventory.Controls
{
    public partial class PrintedProductsAdd : UserControl
    {
        BcPrinted printed = BcPrinted.Instance;
        LookUp lookup = LookUp.Instance;
        public PrintedProductsAdd()
        {
            InitializeComponent();
            cmbCategory.DataSource = lookup.RawCategories;
            cmbSku.DataSource = lookup.RawSku;
            cmbCity.DataSource = lookup.City;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CloseMe(-1);
        }

        private void CloseMe(int id)
        {
            PrintedProductsBase ppb = (PrintedProductsBase)this.Parent;
            this.Parent.Controls.Remove(this);
            if (id == -1)
            {
                ppb.ShowPp();
            }
            else
            {
                ppb.ShowEdit(id);
            }
            this.Dispose();
        }

        private void label_Click(object sender, EventArgs e)
        {
            CloseMe(-1);
        }

        private void lblBack_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Base bs = printed.PrintedProductsAdd(cmbCategory.Text, cmbSku.Text, txtShortDescription.Text.Length > 0 ? txtShortDescription.Text : null, txtDescription.Text, txtQuantity.Text, cmbCity.Text);
            this.Cursor = Cursors.Default;
            if (!bs.error)
            {
                Button btn = (Button)sender;
                CloseMe(btn.Tag.ToString() == "1" ? Convert.ToInt32(bs.objet) : -1);
            }
            else
            {
                MessageBox.Show(bs.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintedProductsAdd_Load(object sender, EventArgs e)
        {
            cmbCategory.Text = string.Empty;
            cmbSku.Text = string.Empty;
            cmbCity.Text = string.Empty;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = UtilityClass.Quantity_KeyPress(e);
        }
        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Length > 0 && cmbSku.Text.Length > 0 && cmbCategory.Text.Length > 0 && cmbCity.Text.Length > 0 && txtDescription.Text.Length > 0)
            {
                btnAdd.Enabled = true;
                btnAddEdit.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnAddEdit.Enabled = false;
            }
        }
    }
}
