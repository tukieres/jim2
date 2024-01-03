namespace JoJosInventory.Controls
{
    partial class PrintedProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintedProducts));
            dgv = new DataGridView();
            pnHeader = new Panel();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            imageList = new ImageList(components);
            pnSearch = new Panel();
            label6 = new Label();
            txtDescription = new TextBox();
            cmbCity = new ComboBox();
            cmbSku = new ComboBox();
            btnClear = new Button();
            btnSearch = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label2 = new Label();
            btnExpand = new Button();
            FlPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pnHeader.SuspendLayout();
            pnSearch.SuspendLayout();
            FlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToOrderColumns = true;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(3, 61);
            dgv.Margin = new Padding(3, 4, 3, 4);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(666, 133);
            dgv.TabIndex = 10;
            dgv.CellClick += dgv_CellClick;
            dgv.CellValueChanged += dgv_CellValueChanged;
            dgv.CurrentCellDirtyStateChanged += dgv_CurrentCellDirtyStateChanged;
            dgv.Resize += dgv_Resize;
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.Gray;
            pnHeader.Controls.Add(label1);
            pnHeader.Controls.Add(btnAdd);
            pnHeader.Controls.Add(btnDelete);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Margin = new Padding(3, 4, 3, 4);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(709, 55);
            pnHeader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(242, 32);
            label1.TabIndex = 3;
            label1.Text = "Printed Product List";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.ImageIndex = 1;
            btnAdd.Location = new Point(514, 12);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 43);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "&Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.ImageIndex = 1;
            btnDelete.Location = new Point(611, 12);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 43);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "expand_less_FILL0_wght400_GRAD0_opsz24 (1).png");
            imageList.Images.SetKeyName(1, "expand_more_FILL0_wght400_GRAD0_opsz24 (1).png");
            // 
            // pnSearch
            // 
            pnSearch.BackColor = Color.White;
            pnSearch.Controls.Add(label6);
            pnSearch.Controls.Add(txtDescription);
            pnSearch.Controls.Add(cmbCity);
            pnSearch.Controls.Add(cmbSku);
            pnSearch.Controls.Add(btnClear);
            pnSearch.Controls.Add(btnSearch);
            pnSearch.Controls.Add(label5);
            pnSearch.Controls.Add(label4);
            pnSearch.Controls.Add(label3);
            pnSearch.Controls.Add(cmbCategory);
            pnSearch.Controls.Add(label2);
            pnSearch.Controls.Add(btnExpand);
            pnSearch.Dock = DockStyle.Top;
            pnSearch.Location = new Point(3, 4);
            pnSearch.Margin = new Padding(3, 4, 3, 4);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(675, 49);
            pnSearch.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 119);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 12;
            label6.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(8, 144);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(488, 27);
            txtDescription.TabIndex = 6;
            txtDescription.TextChanged += cmbCategory_TextChanged;
            // 
            // cmbCity
            // 
            cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(219, 77);
            cmbCity.Margin = new Padding(3, 4, 3, 4);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(187, 28);
            cmbCity.TabIndex = 4;
            cmbCity.TextChanged += cmbCategory_TextChanged;
            // 
            // cmbSku
            // 
            cmbSku.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSku.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSku.FormattingEnabled = true;
            cmbSku.Location = new Point(433, 76);
            cmbSku.Margin = new Padding(3, 4, 3, 4);
            cmbSku.Name = "cmbSku";
            cmbSku.Size = new Size(187, 28);
            cmbSku.TabIndex = 5;
            cmbSku.TextChanged += cmbCategory_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.DarkOrange;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.ImageIndex = 1;
            btnClear.Location = new Point(592, 128);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(70, 43);
            btnClear.TabIndex = 8;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.Green;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.ImageIndex = 1;
            btnSearch.Location = new Point(510, 128);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(74, 43);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Visible = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 52);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 7;
            label5.Text = "SKU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 52);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 6;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 52);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(8, 77);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(187, 28);
            cmbCategory.TabIndex = 3;
            cmbCategory.TextChanged += cmbCategory_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // btnExpand
            // 
            btnExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExpand.FlatStyle = FlatStyle.Flat;
            btnExpand.ImageIndex = 1;
            btnExpand.ImageList = imageList;
            btnExpand.Location = new Point(623, 11);
            btnExpand.Margin = new Padding(3, 4, 3, 4);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(43, 31);
            btnExpand.TabIndex = 2;
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // FlPanel
            // 
            FlPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlPanel.BackColor = Color.Gray;
            FlPanel.Controls.Add(pnSearch);
            FlPanel.Controls.Add(dgv);
            FlPanel.Location = new Point(16, 63);
            FlPanel.Margin = new Padding(3, 4, 3, 4);
            FlPanel.Name = "FlPanel";
            FlPanel.Size = new Size(674, 379);
            FlPanel.TabIndex = 4;
            FlPanel.SizeChanged += FlPanel_SizeChanged;
            // 
            // PrintedProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(FlPanel);
            Controls.Add(pnHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrintedProducts";
            Size = new Size(709, 459);
            Load += PrintedProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            FlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Panel pnHeader;
        private Panel pnSearch;
        private Button btnExpand;
        private FlowLayoutPanel FlPanel;
        private ImageList imageList;
        private Label label2;
        private Button btnAdd;
        private Button btnDelete;
        private Label label1;
        private ComboBox cmbCategory;
        private Button btnSearch;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnClear;
        private ComboBox cmbSku;
        private Label label6;
        private TextBox txtDescription;
        private ComboBox cmbCity;
    }
}
