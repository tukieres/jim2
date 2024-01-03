namespace JoJosInventory.Controls
{
    partial class PrintedProductsEdit
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintedProductsEdit));
            pnHeader = new Panel();
            lblBack = new Label();
            btnSave = new Button();
            btnSaveContinue = new Button();
            label1 = new Label();
            imageList = new ImageList(components);
            FlPanel = new FlowLayoutPanel();
            pnData = new Panel();
            label12 = new Label();
            txtQty = new TextBox();
            label13 = new Label();
            txtShortDescription = new TextBox();
            label14 = new Label();
            txtDescription = new TextBox();
            cmbCity = new ComboBox();
            cmbSku = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            cmbCategory = new ComboBox();
            pnSearch = new Panel();
            cmbSearchSKU = new ComboBox();
            btnClear = new Button();
            chkRequired = new CheckBox();
            btnSearch = new Button();
            label3 = new Label();
            label5 = new Label();
            cmbSearchCategory = new ComboBox();
            label6 = new Label();
            btnExpand = new Button();
            dgv = new DataGridView();
            lblUnsaved = new Label();
            pnHeader.SuspendLayout();
            FlPanel.SuspendLayout();
            pnData.SuspendLayout();
            pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.Gray;
            pnHeader.Controls.Add(lblBack);
            pnHeader.Controls.Add(btnSave);
            pnHeader.Controls.Add(btnSaveContinue);
            pnHeader.Controls.Add(label1);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Margin = new Padding(3, 4, 3, 4);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(942, 55);
            pnHeader.TabIndex = 4;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBack.ForeColor = Color.Aqua;
            lblBack.Location = new Point(310, 24);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(216, 20);
            lblBack.TabIndex = 0;
            lblBack.Text = "<-- back to Printed Product List";
            lblBack.Click += label_Click;
            lblBack.MouseEnter += lblBack_MouseEnter;
            lblBack.MouseLeave += lblBack_MouseLeave;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.Navy;
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.ImageIndex = 1;
            btnSave.Location = new Point(616, 11);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 43);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSaveContinue
            // 
            btnSaveContinue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveContinue.AutoSize = true;
            btnSaveContinue.BackColor = Color.Navy;
            btnSaveContinue.Enabled = false;
            btnSaveContinue.FlatStyle = FlatStyle.Flat;
            btnSaveContinue.ForeColor = Color.White;
            btnSaveContinue.ImageIndex = 1;
            btnSaveContinue.Location = new Point(700, 11);
            btnSaveContinue.Margin = new Padding(3, 4, 3, 4);
            btnSaveContinue.Name = "btnSaveContinue";
            btnSaveContinue.Size = new Size(221, 43);
            btnSaveContinue.TabIndex = 2;
            btnSaveContinue.Text = "Save &and continue editing";
            btnSaveContinue.UseVisualStyleBackColor = false;
            btnSaveContinue.Click += btnSaveContinue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(293, 32);
            label1.TabIndex = 3;
            label1.Text = "Edit Printed Product List";
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "expand_less_FILL0_wght400_GRAD0_opsz24 (1).png");
            imageList.Images.SetKeyName(1, "expand_more_FILL0_wght400_GRAD0_opsz24 (1).png");
            // 
            // FlPanel
            // 
            FlPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlPanel.BackColor = Color.Gray;
            FlPanel.Controls.Add(pnData);
            FlPanel.Controls.Add(pnSearch);
            FlPanel.Controls.Add(dgv);
            FlPanel.Location = new Point(16, 67);
            FlPanel.Margin = new Padding(0);
            FlPanel.Name = "FlPanel";
            FlPanel.Size = new Size(905, 575);
            FlPanel.TabIndex = 7;
            FlPanel.SizeChanged += FlPanel_SizeChanged;
            // 
            // pnData
            // 
            pnData.BackColor = Color.White;
            pnData.Controls.Add(label12);
            pnData.Controls.Add(txtQty);
            pnData.Controls.Add(label13);
            pnData.Controls.Add(txtShortDescription);
            pnData.Controls.Add(label14);
            pnData.Controls.Add(txtDescription);
            pnData.Controls.Add(cmbCity);
            pnData.Controls.Add(cmbSku);
            pnData.Controls.Add(label15);
            pnData.Controls.Add(label16);
            pnData.Controls.Add(label17);
            pnData.Controls.Add(cmbCategory);
            pnData.Dock = DockStyle.Top;
            pnData.Location = new Point(0, 0);
            pnData.Margin = new Padding(0);
            pnData.Name = "pnData";
            pnData.Size = new Size(752, 239);
            pnData.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(214, 89);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 16;
            label12.Text = "Quantity *";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(214, 115);
            txtQty.Margin = new Padding(3, 4, 3, 4);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(265, 27);
            txtQty.TabIndex = 7;
            txtQty.TextAlign = HorizontalAlignment.Right;
            txtQty.TextChanged += cmbCategory_TextChanged;
            txtQty.KeyPress += txtQty_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(214, 13);
            label13.Name = "label13";
            label13.Size = new Size(124, 20);
            label13.TabIndex = 14;
            label13.Text = "Short Description";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtShortDescription.Location = new Point(214, 39);
            txtShortDescription.Margin = new Padding(3, 4, 3, 4);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.Size = new Size(313, 27);
            txtShortDescription.TabIndex = 4;
            txtShortDescription.TextChanged += cmbCategory_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 168);
            label14.Name = "label14";
            label14.Size = new Size(95, 20);
            label14.TabIndex = 12;
            label14.Text = "Description *";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(11, 192);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(718, 27);
            txtDescription.TabIndex = 7;
            txtDescription.TextChanged += cmbCategory_TextChanged;
            // 
            // cmbCity
            // 
            cmbCity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(542, 39);
            cmbCity.Margin = new Padding(3, 4, 3, 4);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(188, 28);
            cmbCity.TabIndex = 5;
            cmbCity.TextChanged += cmbCategory_TextChanged;
            // 
            // cmbSku
            // 
            cmbSku.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSku.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSku.FormattingEnabled = true;
            cmbSku.Location = new Point(13, 115);
            cmbSku.Margin = new Padding(3, 4, 3, 4);
            cmbSku.Name = "cmbSku";
            cmbSku.Size = new Size(187, 28);
            cmbSku.TabIndex = 6;
            cmbSku.TextChanged += cmbCategory_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 91);
            label15.Name = "label15";
            label15.Size = new Size(46, 20);
            label15.TabIndex = 7;
            label15.Text = "SKU *";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(542, 13);
            label16.Name = "label16";
            label16.Size = new Size(44, 20);
            label16.TabIndex = 6;
            label16.Text = "City *";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 13);
            label17.Name = "label17";
            label17.Size = new Size(79, 20);
            label17.TabIndex = 5;
            label17.Text = "Category *";
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(11, 39);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(187, 28);
            cmbCategory.TabIndex = 3;
            cmbCategory.TextChanged += cmbCategory_TextChanged;
            // 
            // pnSearch
            // 
            pnSearch.BackColor = Color.White;
            pnSearch.Controls.Add(cmbSearchSKU);
            pnSearch.Controls.Add(btnClear);
            pnSearch.Controls.Add(chkRequired);
            pnSearch.Controls.Add(btnSearch);
            pnSearch.Controls.Add(label3);
            pnSearch.Controls.Add(label5);
            pnSearch.Controls.Add(cmbSearchCategory);
            pnSearch.Controls.Add(label6);
            pnSearch.Controls.Add(btnExpand);
            pnSearch.Dock = DockStyle.Top;
            pnSearch.Location = new Point(0, 247);
            pnSearch.Margin = new Padding(0, 8, 0, 0);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(752, 49);
            pnSearch.TabIndex = 7;
            // 
            // cmbSearchSKU
            // 
            cmbSearchSKU.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSearchSKU.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSearchSKU.FormattingEnabled = true;
            cmbSearchSKU.Location = new Point(214, 77);
            cmbSearchSKU.Margin = new Padding(3, 4, 3, 4);
            cmbSearchSKU.Name = "cmbSearchSKU";
            cmbSearchSKU.Size = new Size(187, 28);
            cmbSearchSKU.TabIndex = 7;
            cmbSearchSKU.TextChanged += cmbSearchCategory_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.DarkOrange;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.ImageIndex = 1;
            btnClear.Location = new Point(669, 62);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(70, 43);
            btnClear.TabIndex = 8;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // chkRequired
            // 
            chkRequired.AutoSize = true;
            chkRequired.Location = new Point(418, 83);
            chkRequired.Margin = new Padding(3, 4, 3, 4);
            chkRequired.Name = "chkRequired";
            chkRequired.Size = new Size(91, 24);
            chkRequired.TabIndex = 5;
            chkRequired.Text = "Required";
            chkRequired.UseVisualStyleBackColor = true;
            chkRequired.CheckedChanged += chkRequired_CheckedChanged;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.Green;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.ImageIndex = 1;
            btnSearch.Location = new Point(588, 62);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(74, 43);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 53);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "SKU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 52);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 5;
            label5.Text = "Category";
            // 
            // cmbSearchCategory
            // 
            cmbSearchCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSearchCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSearchCategory.FormattingEnabled = true;
            cmbSearchCategory.Location = new Point(8, 77);
            cmbSearchCategory.Margin = new Padding(3, 4, 3, 4);
            cmbSearchCategory.Name = "cmbSearchCategory";
            cmbSearchCategory.Size = new Size(187, 28);
            cmbSearchCategory.TabIndex = 4;
            cmbSearchCategory.TextChanged += cmbSearchCategory_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 1;
            label6.Text = "Search";
            // 
            // btnExpand
            // 
            btnExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExpand.FlatStyle = FlatStyle.Flat;
            btnExpand.ImageIndex = 1;
            btnExpand.ImageList = imageList;
            btnExpand.Location = new Point(696, 12);
            btnExpand.Margin = new Padding(3, 4, 3, 4);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(43, 31);
            btnExpand.TabIndex = 3;
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToOrderColumns = true;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(0, 304);
            dgv.Margin = new Padding(0, 8, 0, 0);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(752, 133);
            dgv.TabIndex = 11;
            dgv.CellClick += dgv_CellClick;
            dgv.Resize += dgv_Resize;
            // 
            // lblUnsaved
            // 
            lblUnsaved.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblUnsaved.AutoSize = true;
            lblUnsaved.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnsaved.ForeColor = Color.Red;
            lblUnsaved.Location = new Point(810, 641);
            lblUnsaved.Name = "lblUnsaved";
            lblUnsaved.Size = new Size(116, 19);
            lblUnsaved.TabIndex = 8;
            lblUnsaved.Text = "Unsaved changes";
            lblUnsaved.Visible = false;
            // 
            // PrintedProductsEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(lblUnsaved);
            Controls.Add(FlPanel);
            Controls.Add(pnHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrintedProductsEdit";
            Size = new Size(942, 663);
            Load += PrintedProductsEdit_Load;
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            FlPanel.ResumeLayout(false);
            pnData.ResumeLayout(false);
            pnData.PerformLayout();
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnHeader;
        private Label label1;
        private Button btnSave;
        private Button btnSaveContinue;
        private Label lblBack;
        private ImageList imageList;
        private FlowLayoutPanel FlPanel;
        private Panel pnData;
        private Label label12;
        private TextBox txtQty;
        private Label label13;
        private TextBox txtShortDescription;
        private Label label14;
        private TextBox txtDescription;
        private ComboBox cmbCity;
        private ComboBox cmbSku;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox cmbCategory;
        private Panel pnSearch;
        private ComboBox cmbSearchSKU;
        private Button btnClear;
        private CheckBox chkRequired;
        private Button btnSearch;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbSearchCategory;
        private Label label6;
        private Button btnExpand;
        private DataGridView dgv;
        private Label lblUnsaved;
    }
}
