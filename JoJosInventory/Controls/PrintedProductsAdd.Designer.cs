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
            components = new System.ComponentModel.Container();
            pnHeader = new Panel();
            lblBack = new Label();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            btnAdd = new Button();
            button1 = new Button();
            pnMain = new Panel();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
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
            btnExpand = new Button();
            panel1 = new Panel();
            label11 = new Label();
            button4 = new Button();
            button5 = new Button();
            label14 = new Label();
            button6 = new Button();
            timerCLose = new System.Windows.Forms.Timer(components);
            pnHeader.SuspendLayout();
            pnMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.Gray;
            pnHeader.Controls.Add(lblBack);
            pnHeader.Controls.Add(button2);
            pnHeader.Controls.Add(button3);
            pnHeader.Controls.Add(label1);
            pnHeader.Controls.Add(btnAdd);
            pnHeader.Controls.Add(button1);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(637, 41);
            pnHeader.TabIndex = 4;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBack.ForeColor = Color.Aqua;
            lblBack.Location = new Point(252, 18);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(174, 15);
            lblBack.TabIndex = 0;
            lblBack.Text = "<-- back to Printed Product List";
            lblBack.Click += label_Click;
            lblBack.MouseEnter += lblBack_MouseEnter;
            lblBack.MouseLeave += lblBack_MouseLeave;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.Navy;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.ImageIndex = 1;
            button2.Location = new Point(457, 11);
            button2.Name = "button2";
            button2.Size = new Size(68, 27);
            button2.TabIndex = 1;
            button2.Text = "&Add New";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.BackColor = Color.Navy;
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.ImageIndex = 1;
            button3.Location = new Point(532, 11);
            button3.Name = "button3";
            button3.Size = new Size(87, 27);
            button3.TabIndex = 2;
            button3.Text = "Add &and Edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(232, 25);
            label1.TabIndex = 3;
            label1.Text = "Add Printed Product List";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.ImageIndex = 1;
            btnAdd.Location = new Point(902, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(68, 27);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "&Add New";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImageIndex = 1;
            button1.Location = new Point(976, 9);
            button1.Name = "button1";
            button1.Size = new Size(61, 27);
            button1.TabIndex = 1;
            button1.Text = "&Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnMain.BackColor = Color.White;
            pnMain.Controls.Add(label9);
            pnMain.Controls.Add(textBox2);
            pnMain.Controls.Add(label8);
            pnMain.Controls.Add(textBox1);
            pnMain.Controls.Add(label6);
            pnMain.Controls.Add(txtDescription);
            pnMain.Controls.Add(cmbCity);
            pnMain.Controls.Add(cmbSku);
            pnMain.Controls.Add(btnClear);
            pnMain.Controls.Add(btnSearch);
            pnMain.Controls.Add(label5);
            pnMain.Controls.Add(label4);
            pnMain.Controls.Add(label3);
            pnMain.Controls.Add(cmbCategory);
            pnMain.Controls.Add(btnExpand);
            pnMain.Location = new Point(14, 47);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(605, 179);
            pnMain.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(187, 67);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 16;
            label9.Text = "Quantity *";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(187, 10);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 14;
            label8.Text = "Short Description";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(187, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 125);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 12;
            label6.Text = "Description *";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(10, 144);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(587, 23);
            txtDescription.TabIndex = 7;
            // 
            // cmbCity
            // 
            cmbCity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(432, 29);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(165, 23);
            cmbCity.TabIndex = 5;
            // 
            // cmbSku
            // 
            cmbSku.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSku.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSku.FormattingEnabled = true;
            cmbSku.Location = new Point(11, 86);
            cmbSku.Name = "cmbSku";
            cmbSku.Size = new Size(164, 23);
            cmbSku.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.DarkOrange;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.ImageIndex = 1;
            btnClear.Location = new Point(927, 104);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 27);
            btnClear.TabIndex = 8;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.Green;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.ImageIndex = 1;
            btnSearch.Location = new Point(860, 104);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(61, 27);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 68);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "SKU *";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(432, 10);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "City *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Category *";
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(10, 29);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(164, 23);
            cmbCategory.TabIndex = 3;
            // 
            // btnExpand
            // 
            btnExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExpand.FlatStyle = FlatStyle.Flat;
            btnExpand.ImageIndex = 1;
            btnExpand.Location = new Point(950, 6);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(38, 23);
            btnExpand.TabIndex = 2;
            btnExpand.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(14, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 50);
            panel1.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(8, 19);
            label11.Name = "label11";
            label11.Size = new Size(268, 15);
            label11.TabIndex = 14;
            label11.Text = "Before defning the product you must frst create it";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.AutoSize = true;
            button4.BackColor = Color.DarkOrange;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.ImageIndex = 1;
            button4.Location = new Point(1332, 104);
            button4.Name = "button4";
            button4.Size = new Size(61, 27);
            button4.TabIndex = 8;
            button4.Text = "&Clear";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.AutoSize = true;
            button5.BackColor = Color.Green;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.ImageIndex = 1;
            button5.Location = new Point(1265, 104);
            button5.Name = "button5";
            button5.Size = new Size(61, 27);
            button5.TabIndex = 7;
            button5.Text = "&Search";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(834, 39);
            label14.Name = "label14";
            label14.Size = new Size(28, 15);
            label14.TabIndex = 6;
            label14.Text = "City";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ImageIndex = 1;
            button6.Location = new Point(1355, 6);
            button6.Name = "button6";
            button6.Size = new Size(38, 23);
            button6.TabIndex = 2;
            button6.UseVisualStyleBackColor = true;
            // 
            // timerCLose
            // 
            timerCLose.Interval = 10;
            // 
            // PrintedProductsAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(panel1);
            Controls.Add(pnMain);
            Controls.Add(pnHeader);
            Name = "PrintedProductsAdd";
            Size = new Size(637, 294);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblBack;
        private Panel pnMain;
        private Label label6;
        private TextBox txtDescription;
        private ComboBox cmbCity;
        private ComboBox cmbSku;
        private Button btnClear;
        private Button btnSearch;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cmbCategory;
        private Button btnExpand;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox2;
        private Panel panel1;
        private Label label11;
        private Button button4;
        private Button button5;
        private Label label14;
        private Button button6;
        private System.Windows.Forms.Timer timerCLose;
    }
}
