namespace JoJosInventory.Froms
{
    partial class ModalEditBaseMaterial
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnSave = new Button();
            cmbCategory = new ComboBox();
            cmbSku = new ComboBox();
            dpDue = new DateTimePicker();
            txtQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkDue = new CheckBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(314, 187);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Navy;
            btnSave.Enabled = false;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(208, 187);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(14, 36);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(170, 28);
            cmbCategory.TabIndex = 0;
            cmbCategory.TextChanged += txtQuantity_TextChanged;
            // 
            // cmbSku
            // 
            cmbSku.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSku.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSku.FormattingEnabled = true;
            cmbSku.Location = new Point(14, 127);
            cmbSku.Margin = new Padding(3, 4, 3, 4);
            cmbSku.Name = "cmbSku";
            cmbSku.Size = new Size(170, 28);
            cmbSku.TabIndex = 3;
            cmbSku.TextChanged += txtQuantity_TextChanged;
            // 
            // dpDue
            // 
            dpDue.Enabled = false;
            dpDue.Format = DateTimePickerFormat.Short;
            dpDue.Location = new Point(243, 36);
            dpDue.Margin = new Padding(3, 4, 3, 4);
            dpDue.Name = "dpDue";
            dpDue.Size = new Size(170, 27);
            dpDue.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(243, 127);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(170, 27);
            txtQuantity.TabIndex = 4;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 103);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 7;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 103);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 8;
            label3.Text = "SKU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 12);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 9;
            label4.Text = "Due Date";
            // 
            // chkDue
            // 
            chkDue.AutoSize = true;
            chkDue.Location = new Point(219, 41);
            chkDue.Margin = new Padding(3, 4, 3, 4);
            chkDue.Name = "chkDue";
            chkDue.Size = new Size(18, 17);
            chkDue.TabIndex = 1;
            chkDue.UseVisualStyleBackColor = true;
            chkDue.CheckedChanged += chkDue_CheckedChanged;
            // 
            // ModalEditBaseMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 254);
            ControlBox = false;
            Controls.Add(chkDue);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(dpDue);
            Controls.Add(cmbSku);
            Controls.Add(cmbCategory);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModalEditBaseMaterial";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Base Material";
            Load += ModalEditBaseMaterial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private ComboBox cmbCategory;
        private ComboBox cmbSku;
        private DateTimePicker dpDue;
        private TextBox txtQuantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkDue;
    }
}