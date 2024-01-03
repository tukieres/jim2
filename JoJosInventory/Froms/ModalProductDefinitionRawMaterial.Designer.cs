namespace JoJosInventory.Froms
{
    partial class ModalProductDefinitionRawMaterial
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
            btnSave = new Button();
            btnCancel = new Button();
            chkRequired = new CheckBox();
            label3 = new Label();
            lblCategory = new Label();
            txtQty = new TextBox();
            label1 = new Label();
            lblCat = new Label();
            lblSku = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Navy;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(57, 204);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 40);
            btnSave.TabIndex = 7;
            btnSave.Text = "&Edit";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(163, 204);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 40);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkRequired
            // 
            chkRequired.AutoSize = true;
            chkRequired.Location = new Point(16, 100);
            chkRequired.Margin = new Padding(3, 4, 3, 4);
            chkRequired.Name = "chkRequired";
            chkRequired.Size = new Size(91, 24);
            chkRequired.TabIndex = 9;
            chkRequired.Text = "Required";
            chkRequired.UseVisualStyleBackColor = true;
            chkRequired.CheckStateChanged += chkRequired_CheckStateChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 63);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 11;
            label3.Text = "SKU:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(16, 19);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(77, 20);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category:";
            // 
            // txtQty
            // 
            txtQty.Enabled = false;
            txtQty.Location = new Point(91, 147);
            txtQty.Margin = new Padding(3, 4, 3, 4);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(171, 27);
            txtQty.TabIndex = 12;
            txtQty.TextAlign = HorizontalAlignment.Right;
            txtQty.KeyPress += txtQty_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 147);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 13;
            label1.Text = "Quantity:";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCat.Location = new Point(91, 19);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(77, 20);
            lblCat.TabIndex = 14;
            lblCat.Text = "Category:";
            // 
            // lblSku
            // 
            lblSku.AutoSize = true;
            lblSku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSku.Location = new Point(91, 63);
            lblSku.Name = "lblSku";
            lblSku.Size = new Size(42, 20);
            lblSku.TabIndex = 15;
            lblSku.Text = "SKU:";
            // 
            // ModalProductDefinitionRawMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(293, 260);
            ControlBox = false;
            Controls.Add(lblSku);
            Controls.Add(lblCat);
            Controls.Add(label1);
            Controls.Add(txtQty);
            Controls.Add(chkRequired);
            Controls.Add(label3);
            Controls.Add(lblCategory);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModalProductDefinitionRawMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Required Raw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private CheckBox chkRequired;
        private Label label3;
        private Label lblCategory;
        private TextBox txtQty;
        private Label label1;
        private Label lblCat;
        private Label lblSku;
    }
}