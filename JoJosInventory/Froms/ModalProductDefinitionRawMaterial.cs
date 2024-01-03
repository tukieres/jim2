using JoJosInventory.Classes;
using JoJosInventory.Controls;

namespace JoJosInventory.Froms
{
    public partial class ModalProductDefinitionRawMaterial : Form
    {
        int Id;
        PrintedProductsEdit Ppe;
        public ModalProductDefinitionRawMaterial(string cat, string sku, bool required, string qty, int id, PrintedProductsEdit ppe)
        {
            InitializeComponent();
            lblCat.Text = cat;
            lblSku.Text = sku;
            chkRequired.Checked = required;
            txtQty.Text = qty;
            Id = id;
            Ppe = ppe;
        }

        private void chkRequired_CheckStateChanged(object sender, EventArgs e)
        {
            txtQty.Enabled = chkRequired.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = UtilityClass.Quantity_KeyPress(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Ppe.UpdateDgv(chkRequired.Checked, txtQty.Text, Id);
            this.DialogResult = DialogResult.OK;
        }
    }
}
