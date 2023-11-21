using JoJosInventory.Classes;
using System.Data;
using JoJosInventory.Data;
using JoJosInventory.Froms;
using Microsoft.VisualBasic;

namespace JoJosInventory.Controls
{
    public partial class PrintedProducts : UserControl
    {
        BcPrinted Printed = BcPrinted.Instance;
        Base bc;
        bool expanded = false;
        LookUp lookup = LookUp.Instance;
        DataTable dt;

        public PrintedProducts()
        {
            InitializeComponent();
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            searchFilters();
            cmbCategory.DataSource = lookup.RawCategories;
            cmbSku.DataSource = lookup.RawSku;
            cmbCity.DataSource = lookup.City;

        }

        private void Formatdgv()
        {
            dgv.Columns.Clear();
            dt = (DataTable)bc.objet;
            dgv.DataSource = dt;

            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.Name = "ToDelete";
            chkColumn.HeaderText = "To delete";
            dgv.Columns.Add(chkColumn);
            dgv.Columns["ToDelete"].DisplayIndex = 0;

            dgv.Columns["Id"].Visible = false;
            dgv.Columns["Name"].HeaderText = "Category";
            dgv.Columns["Sku"].HeaderText = "SKU";
            dgv.Columns["City"].HeaderText = "City";
            dgv.Columns["StockQuantity"].HeaderText = "Qty on hand";
            dgv.Columns["FullDescription"].HeaderText = "Description";

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Edit";
            btnColumn.HeaderText = "Edit";
            btnColumn.Text = "Edit";
            btnColumn.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(btnColumn);

            dgv.Columns["ToDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["StockQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.Columns["ToDelete"].ReadOnly = false;
            dgv.Columns["Name"].ReadOnly = true;
            dgv.Columns["Sku"].ReadOnly = true;
            dgv.Columns["City"].ReadOnly = true;
            dgv.Columns["StockQuantity"].ReadOnly = true;
            dgv.Columns["FullDescription"].ReadOnly = true;
            dgv.Columns["Edit"].ReadOnly = false;

            dgv_Resize();
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
                pnSearch.Height = 144;
                expanded = true;
                btnExpand.ImageIndex = 0;
            }
            dgv.Height = FlPanel.Height - pnSearch.Height - 10;

        }

        private void FlPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control child in FlPanel.Controls)
            {
                child.Width = FlPanel.Width - 10;
            }
            dgv.Height = FlPanel.Height - pnSearch.Height - 10;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PrintedProductsAdd ppa = new PrintedProductsAdd();
            ppa.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(ppa);
            this.Parent.Controls.Remove(this);
        }
        private void dgv_Resize()
        {
            if (dgv.Columns.Count > 0)
            {
                int width = dgv.Width - 21;
                dgv.Columns["ToDelete"].Width = (int)(width * (0.05));
                dgv.Columns["Id"].Width = 1;
                dgv.Columns["Name"].Width = (int)(width * (0.15));
                dgv.Columns["Sku"].Width = (int)(width * (0.10));
                dgv.Columns["City"].Width = (int)(width * (0.15));
                dgv.Columns["StockQuantity"].Width = (int)(width * (0.10));
                dgv.Columns["FullDescription"].Width = (int)(width * (0.35));
                dgv.Columns["Edit"].Width = (int)(width * (0.10));
            }
        }

        private void dgv_Resize(object sender, EventArgs e)
        {
            dgv_Resize();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit buttons
            if (e.ColumnIndex == dgv.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                PrintedProductsEdit ppe = new PrintedProductsEdit();
                ppe.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(ppe);
                this.Parent.Controls.Remove(this);

                /*int Id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);
                string Name = dgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string Sku = dgv.Rows[e.RowIndex].Cells["Sku"].Value.ToString();
                DateTime? dueDate = null;
                if (dgv.Rows[e.RowIndex].Cells["DueDate"].Value != null)
                {
                    try
                    {
                        dueDate = DateTime.Parse(dgv.Rows[e.RowIndex].Cells["DueDate"].Value.ToString());
                    }
                    catch (Exception) { }

                }
                string Qty = dgv.Rows[e.RowIndex].Cells["CurrentAmount"].Value.ToString();


                ModalEditBaseMaterial f1 = new ModalEditBaseMaterial(Id, Name, Sku, dueDate, Qty);
                DialogResult result = f1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Update Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchFilters();
                }
                else
                {
                    //click on cancel
                }*/
            }
        }

        private void searchFilters()
        {
            this.Cursor = Cursors.WaitCursor;
            bc = Printed.PrintedProductsSearch("", "", "", "");
            if (!bc.error)
            {
                Formatdgv();
                FilterDgv();
            }
            this.Cursor = Cursors.Default;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchFilters();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCategory.Text = string.Empty;
            cmbSku.Text = string.Empty;
            cmbCity.Text = string.Empty;
            txtDescription.Text = string.Empty;
            searchFilters();
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Check to delete            
            if (e.ColumnIndex == dgv.Columns["ToDelete"].Index && e.RowIndex >= 0)
            {
                //bool isCheckeo = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["ToDelete"].Value);
                bool test = false;

                foreach (DataGridViewRow row in dgv.Rows)
                {

                    if (row.Cells["todelete"] != null && row.Cells["toDelete"].Value != null && !row.IsNewRow)
                    {
                        bool isChecked = Convert.ToBoolean(row.Cells["toDelete"].Value);
                        if (isChecked)
                        {
                            int rowIndex = row.Index;
                            test = true;
                        }
                    }
                }
                if (test) { btnDelete.Enabled = true; } else { btnDelete.Enabled = false; }
            }

        }

        private void dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv.IsCurrentCellDirty)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("This operation cannot be reversed, do you wish to delete the selected materials?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resp.ToString() == "Yes")
            {
                this.Cursor = Cursors.WaitCursor;
                List<string> markedIds = new List<string>();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells["ToDelete"] != null && row.Cells["ToDelete"].Value != null && !row.IsNewRow)
                    {
                        bool isChecked = Convert.ToBoolean(row.Cells["ToDelete"].Value);
                        if (isChecked)
                        {
                            string id = row.Cells["Id"].Value.ToString();
                            markedIds.Add(id);
                        }
                    }
                }
                string formattedIds = "(" + string.Join(",", markedIds) + ")";
                Base bs = Printed.BaseMaterialDelete(formattedIds);
                if (bs.error == false) { searchFilters(); } else { MessageBox.Show(bs.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                this.Cursor = Cursors.Default;
            }
        }

        private void PrintedProducts_Load(object sender, EventArgs e)
        {
            cmbSku.Text = string.Empty;
            cmbCategory.Text = string.Empty;
            cmbCity.Text = string.Empty;
        }

        private void FilterDgv()
        {
            string s = "";
            dt.DefaultView.RowFilter = "NAME LIKE '%" + cmbCategory.Text + "%' AND Sku LIKE '%" + cmbSku.Text + "%' AND City LIKE '%" + cmbCity.Text + "%' AND FullDescription LIKE '%" + txtDescription.Text + "%'";
        }
        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }
    }
}
