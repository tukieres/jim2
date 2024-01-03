using JoJosInventory.Classes;
using JoJosInventory.Data;
using JoJosInventory.Froms;
using System.Data;

namespace JoJosInventory.Controls
{
    public partial class PrintedProductsEdit : UserControl
    {
        bool expanded = false;
        int Id = 0;
        LookUp lookup = LookUp.Instance;
        BcPrinted printed = BcPrinted.Instance;
        Base bc;
        DataTable dt;

        public PrintedProductsEdit(int id)
        {
            InitializeComponent();
            Id = id;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            searchFilters();
            cmbCategory.DataSource = lookup.RawCategories;
            cmbSku.DataSource = lookup.RawSku;
            cmbSearchCategory.DataSource = new List<string>(lookup.RawCategories);
            cmbSearchSKU.DataSource = new List<string>(lookup.RawSku);
            cmbCity.DataSource = lookup.City;
            lookup.event_UpdateLookUp += lookup_events_Lookup;
        }

        private void lookup_events_Lookup(object sender, EventArgs e)
        {
            string s;
            s = cmbCategory.Text;
            cmbCategory.DataSource = lookup.RawCategories;
            cmbCategory.Text = s;

            s = cmbSku.Text;
            cmbSku.DataSource = lookup.RawSku;
            cmbSku.Text = s;

            s = cmbCity.Text;
            cmbCity.DataSource = lookup.City;
            cmbCity.Text = s;
            
            s = cmbSearchCategory.Text;
            cmbSearchCategory.DataSource = new List<string>(lookup.RawCategories);
            cmbSearchCategory.Text = s;

            s = cmbSearchSKU.Text;
            cmbSearchSKU.DataSource = new List<string>(lookup.RawSku);
            cmbSearchSKU.Text = s;
            

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
                child.Width = FlPanel.Width;
            }
            dgv.Height = FlPanel.Height - pnData.Height - pnSearch.Height - 10;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                pnSearch.Height = 49;
                expanded = false;
                btnExpand.ImageIndex = 1;

            }
            else
            {
                pnSearch.Height = 114;
                expanded = true;
                btnExpand.ImageIndex = 0;
            }
            dgv.Height = FlPanel.Height - pnData.Height - pnSearch.Height - 10;

        }
        private void Formatdgv()
        {
            dgv.Columns.Clear();
            dt = (DataTable)bc.objet;
            dgv.DataSource = dt;
            dgv.AutoGenerateColumns = true;

            var btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Edit";
            btnColumn.HeaderText = "Edit";
            btnColumn.Text = "Edit";
            btnColumn.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(btnColumn);

            var checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.Name = "Requirod";
            checkboxColumn.HeaderText = "Required";
            checkboxColumn.DataPropertyName = "Required";
            checkboxColumn.TrueValue = true;
            checkboxColumn.FalseValue = false;
            checkboxColumn.ValueType = typeof(bool);
            dgv.Columns.Add(checkboxColumn);

            dgv.Columns["Requirod"].DisplayIndex = 0;
            dgv.Columns["Name"].DisplayIndex = 0;
            dgv.Columns["Sku"].DisplayIndex = 1;
            dgv.Columns["Quantity"].DisplayIndex = 2;
            dgv.Columns["Edit"].DisplayIndex = 3;
            dgv.Columns["Required"].DisplayIndex = 4;
            dgv.Columns["RawId"].DisplayIndex = 5;

            dgv.Columns["Required"].Visible = false;
            dgv.Columns["RawId"].Visible = false;
            dgv.Columns["Name"].HeaderText = "Category";
            dgv.Columns["Sku"].HeaderText = "SKU";
            dgv.Columns["Quantity"].HeaderText = "Required Qty";

            dgv.Columns["Required"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.Columns["Requirod"].ReadOnly = true;
            dgv.Columns["Name"].ReadOnly = true;
            dgv.Columns["Sku"].ReadOnly = true;
            dgv.Columns["Quantity"].ReadOnly = true;
            dgv.Columns["Edit"].ReadOnly = false;

            dgv_Resize();
        }
        private void dgv_Resize()
        {
            if (dgv.Columns.Count > 0)
            {
                int width = dgv.Width - 21;
                dgv.Columns["Required"].Width = 1;
                dgv.Columns["RawId"].Width = 1;
                dgv.Columns["Requirod"].Width = (int)(width * (0.10));
                dgv.Columns["Name"].Width = (int)(width * (0.30));
                dgv.Columns["Sku"].Width = (int)(width * (0.25));
                dgv.Columns["Quantity"].Width = (int)(width * (0.25));
                dgv.Columns["Edit"].Width = (int)(width * (0.09));
            }
        }

        private void searchFilters()
        {
            this.Cursor = Cursors.WaitCursor;
            bc = printed.PrintedProductsDefinition(Id);
            if (!bc.error)
            {
                Formatdgv();
                FilterDgv();
                lblUnsaved.Visible = false;
                btnSave.Enabled = false;
                btnSaveContinue.Enabled = false;
            }
            this.Cursor = Cursors.Default;
        }
        private void FilterDgv()
        {
            if (dt != null)
            {
                string s = "";
                if (chkRequired.Checked) s = " AND Quantity > 0 ";
                dt.DefaultView.RowFilter = "NAME LIKE '%" + cmbSearchCategory.Text + "%' AND Sku LIKE '%" + cmbSearchSKU.Text + "%'" + s;
            }

        }
        private void PrintedProductsEdit_Load(object sender, EventArgs e)
        {
            Cursor.Equals(Cursors.WaitCursor);
            DataTable dtb = (DataTable)printed.PrintedProductsId(Id).objet;
            foreach (DataRow dr in dtb.Rows)
            {
                cmbCategory.Text = dr[1].ToString();
                cmbSku.Text = dr[2].ToString();
                cmbCity.Text = dr[7].ToString();
                txtQty.Text = dr[5].ToString();
                txtDescription.Text = dr[4].ToString();
                txtShortDescription.Text = dr[3].ToString();
            }
            cmbSearchCategory.Text = string.Empty;
            cmbSearchSKU.Text = string.Empty;
            lblUnsaved.Visible = false;
            btnSave.Enabled = false;
            btnSaveContinue.Enabled = false;
            Cursor.Equals(Cursors.Default);

        }

        private void dgv_Resize(object sender, EventArgs e)
        {
            dgv_Resize();
        }

        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text.Length > 0 && cmbSku.Text.Length > 0 && cmbCategory.Text.Length > 0 && cmbCity.Text.Length > 0 && txtDescription.Text.Length > 0)
            {
                btnSave.Enabled = true;
                btnSaveContinue.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnSaveContinue.Enabled = false;
            }
            lblUnsaved.Visible = true;
            //btnSave.Enabled = true;
            //btnSaveContinue.Enabled = true;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = UtilityClass.Quantity_KeyPress(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbSearchCategory.Text = string.Empty;
            chkRequired.Checked = false;
            cmbSearchSKU.Text = string.Empty;
            //searchFilters();
            FilterDgv();
        }

        private void cmbSearchCategory_TextChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }

        private void chkRequired_CheckedChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }

        public void UpdateDgv(bool required, string qty, int id)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["RawId"].Value.ToString() == id.ToString())
                {
                    if (!required)
                    {
                        row.Cells["Quantity"].Value = 0;
                        row.Cells["Requirod"].Value = false;
                    }
                    else
                    {
                        row.Cells["Quantity"].Value = qty;
                        row.Cells["Requirod"].Value = true;
                    }
                }
            }
            lblUnsaved.Visible = true;
            btnSave.Enabled = true;
            btnSaveContinue.Enabled = true;
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit buttons
            if (e.ColumnIndex == dgv.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int Id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["RawId"].Value);
                string Name = dgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string Sku = dgv.Rows[e.RowIndex].Cells["Sku"].Value.ToString();
                string Required = dgv.Rows[e.RowIndex].Cells["Requirod"].Value.ToString();

                string Qty = dgv.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();


                var f1 = new ModalProductDefinitionRawMaterial(Name, Sku, (Required == "True"), Qty, Id, this);
                DialogResult result = f1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //MessageBox.Show("Update Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //searchFilters();
                }
                else
                {
                    //click on cancel
                }
            }
        }

        private void PrintedProductsUpdate()
        {
            this.Cursor = Cursors.WaitCursor;

            string concatenate = string.Empty;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var cellValue = row.Cells["Requirod"].Value;
                if (cellValue != null && bool.TryParse(cellValue.ToString(), out bool isRequired) && isRequired)
                {
                    if (concatenate == string.Empty)
                    {
                        concatenate = "(" + Id + "," + row.Cells["RawId"].Value + "," + row.Cells["Quantity"].Value + ")";
                    }
                    else
                    {
                        concatenate = concatenate + ",(" + Id + "," + row.Cells["RawId"].Value + "," + row.Cells["Quantity"].Value + ")";
                    }
                }
            }

            Base bs = printed.PrintedProductsEdit(Id, cmbCategory.Text, cmbSku.Text, txtShortDescription.Text, txtDescription.Text, txtQty.Text, cmbCity.Text, concatenate);
            this.Cursor = Cursors.Default;
            if (!bs.error)
            {
                lblUnsaved.Visible = false;
                btnSave.Enabled = false;
                btnSaveContinue.Enabled = false;
            }
            else
            {
                MessageBox.Show(bs.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            PrintedProductsUpdate();
            CloseMe();
        }

        private void btnSaveContinue_Click(object sender, EventArgs e)
        {
            PrintedProductsUpdate();
        }
    }
}
