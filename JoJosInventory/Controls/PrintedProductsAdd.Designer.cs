namespace JoJosInventory.Controls
{
    partial class PrintedProductsAdd
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
            pnHeader = new Panel();
            lblBack = new Label();
            btnAdd = new Button();
            btnAddEdit = new Button();
            label1 = new Label();
            pnMain = new Panel();
            label9 = new Label();
            txtQuantity = new TextBox();
            label8 = new Label();
            txtShortDescription = new TextBox();
            label6 = new Label();
            txtDescription = new TextBox();
            cmbCity = new ComboBox();
            cmbSku = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbCategory = new ComboBox();
            panel1 = new Panel();
            label11 = new Label();
            label14 = new Label();
            pnHeader.SuspendLayout();
            pnMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.Gray;
            pnHeader.Controls.Add(lblBack);
            pnHeader.Controls.Add(btnAdd);
            pnHeader.Controls.Add(btnAddEdit);
            pnHeader.Controls.Add(label1);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Margin = new Padding(3, 4, 3, 4);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(927, 55);
            pnHeader.TabIndex = 4;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBack.ForeColor = Color.Aqua;
            lblBack.Location = new Point(318, 24);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(216, 20);
            lblBack.TabIndex = 0;
            lblBack.Text = "<-- back to Printed Product List";
            lblBack.Click += label_Click;
            lblBack.MouseEnter += lblBack_MouseEnter;
            lblBack.MouseLeave += lblBack_MouseLeave;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.Navy;
            btnAdd.Enabled = false;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.ImageIndex = 1;
            btnAdd.Location = new Point(681, 15);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Tag = "0";
            btnAdd.Text = "&Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAddEdit
            // 
            btnAddEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddEdit.AutoSize = true;
            btnAddEdit.BackColor = Color.Navy;
            btnAddEdit.Enabled = false;
            btnAddEdit.FlatStyle = FlatStyle.Flat;
            btnAddEdit.ForeColor = Color.White;
            btnAddEdit.ImageIndex = 1;
            btnAddEdit.Location = new Point(783, 15);
            btnAddEdit.Margin = new Padding(3, 4, 3, 4);
            btnAddEdit.Name = "btnAddEdit";
            btnAddEdit.Size = new Size(123, 43);
            btnAddEdit.TabIndex = 2;
            btnAddEdit.Tag = "1";
            btnAddEdit.Text = "Add and &Edit";
            btnAddEdit.UseVisualStyleBackColor = false;
            btnAddEdit.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(296, 32);
            label1.TabIndex = 3;
            label1.Text = "Add Printed Product List";
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnMain.BackColor = Color.White;
            pnMain.Controls.Add(label9);
            pnMain.Controls.Add(txtQuantity);
            pnMain.Controls.Add(label8);
            pnMain.Controls.Add(txtShortDescription);
            pnMain.Controls.Add(label6);
            pnMain.Controls.Add(txtDescription);
            pnMain.Controls.Add(cmbCity);
            pnMain.Controls.Add(cmbSku);
            pnMain.Controls.Add(label5);
            pnMain.Controls.Add(label4);
            pnMain.Controls.Add(label3);
            pnMain.Controls.Add(cmbCategory);
            pnMain.Location = new Point(16, 63);
            pnMain.Margin = new Padding(3, 4, 3, 4);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(890, 239);
            pnMain.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(214, 89);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 16;
            label9.Text = "Quantity *";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(214, 115);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(265, 27);
            txtQuantity.TabIndex = 7;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            txtQuantity.TextChanged += cmbCategory_TextChanged;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(214, 13);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 14;
            label8.Text = "Short Description";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtShortDescription.Location = new Point(214, 39);
            txtShortDescription.Margin = new Padding(3, 4, 3, 4);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.Size = new Size(464, 27);
            txtShortDescription.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 167);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 12;
            label6.Text = "Description *";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(11, 192);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(869, 27);
            txtDescription.TabIndex = 7;
            txtDescription.TextChanged += cmbCategory_TextChanged;
            txtDescription.Validated += cmbCategory_TextChanged;
            // 
            // cmbCity
            // 
            cmbCity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(693, 39);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 91);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 7;
            label5.Text = "SKU *";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(693, 13);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 6;
            label4.Text = "City *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 13);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 5;
            label3.Text = "Category *";
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(16, 309);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 67);
            panel1.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(9, 25);
            label11.Name = "label11";
            label11.Size = new Size(336, 20);
            label11.TabIndex = 14;
            label11.Text = "Before defning the product you must frst create it";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(1152, 52);
            label14.Name = "label14";
            label14.Size = new Size(34, 20);
            label14.TabIndex = 6;
            label14.Text = "City";
            // 
            // PrintedProductsAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(panel1);
            Controls.Add(pnMain);
            Controls.Add(pnHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrintedProductsAdd";
            Size = new Size(927, 392);
            Load += PrintedProductsAdd_Load;
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnHeader;
        private Label label1;
        private Button btnAdd;
        private Button btnAddEdit;
        private Label lblBack;
        private Panel pnMain;
        private Label label6;
        private TextBox txtDescription;
        private ComboBox cmbCity;
        private ComboBox cmbSku;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cmbCategory;
        private Label label8;
        private TextBox txtShortDescription;
        private Label label9;
        private TextBox txtQuantity;
        private Panel panel1;
        private Label label11;
        private Label label14;
    }
}
