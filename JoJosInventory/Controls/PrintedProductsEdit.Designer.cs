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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            imageList = new ImageList(components);
            FlPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            label12 = new Label();
            textBox3 = new TextBox();
            label13 = new Label();
            textBox4 = new TextBox();
            label14 = new Label();
            textBox5 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            comboBox5 = new ComboBox();
            pnSearch = new Panel();
            comboBox6 = new ComboBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            button4 = new Button();
            label3 = new Label();
            label5 = new Label();
            comboBox7 = new ComboBox();
            label6 = new Label();
            btnExpand = new Button();
            dgv = new DataGridView();
            pnHeader.SuspendLayout();
            FlPanel.SuspendLayout();
            panel1.SuspendLayout();
            pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.Gray;
            pnHeader.Controls.Add(lblBack);
            pnHeader.Controls.Add(button2);
            pnHeader.Controls.Add(button3);
            pnHeader.Controls.Add(label1);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(690, 41);
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
            button2.Location = new Point(440, 11);
            button2.Name = "button2";
            button2.Size = new Size(68, 27);
            button2.TabIndex = 1;
            button2.Text = "&Save";
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
            button3.Location = new Point(516, 11);
            button3.Name = "button3";
            button3.Size = new Size(156, 27);
            button3.TabIndex = 2;
            button3.Text = "Save &and continue editing";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
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
            FlPanel.Controls.Add(panel1);
            FlPanel.Controls.Add(pnSearch);
            FlPanel.Controls.Add(dgv);
            FlPanel.Location = new Point(14, 50);
            FlPanel.Margin = new Padding(0);
            FlPanel.Name = "FlPanel";
            FlPanel.Size = new Size(668, 439);
            FlPanel.TabIndex = 7;
            FlPanel.SizeChanged += FlPanel_SizeChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(comboBox5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 179);
            panel1.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(187, 67);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 16;
            label12.Text = "Quantity *";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(187, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 23);
            textBox3.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(187, 10);
            label13.Name = "label13";
            label13.Size = new Size(98, 15);
            label13.TabIndex = 14;
            label13.Text = "Short Description";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(187, 29);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 23);
            textBox4.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 125);
            label14.Name = "label14";
            label14.Size = new Size(75, 15);
            label14.TabIndex = 12;
            label14.Text = "Description *";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(10, 144);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(190, 23);
            textBox5.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(474, 29);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(165, 23);
            comboBox3.TabIndex = 5;
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox4.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(11, 86);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(164, 23);
            comboBox4.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 68);
            label15.Name = "label15";
            label15.Size = new Size(36, 15);
            label15.TabIndex = 7;
            label15.Text = "SKU *";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(474, 10);
            label16.Name = "label16";
            label16.Size = new Size(36, 15);
            label16.TabIndex = 6;
            label16.Text = "City *";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 10);
            label17.Name = "label17";
            label17.Size = new Size(63, 15);
            label17.TabIndex = 5;
            label17.Text = "Category *";
            // 
            // comboBox5
            // 
            comboBox5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox5.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(10, 29);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(164, 23);
            comboBox5.TabIndex = 3;
            // 
            // pnSearch
            // 
            pnSearch.BackColor = Color.White;
            pnSearch.Controls.Add(comboBox6);
            pnSearch.Controls.Add(button1);
            pnSearch.Controls.Add(checkBox1);
            pnSearch.Controls.Add(button4);
            pnSearch.Controls.Add(label3);
            pnSearch.Controls.Add(label5);
            pnSearch.Controls.Add(comboBox7);
            pnSearch.Controls.Add(label6);
            pnSearch.Controls.Add(btnExpand);
            pnSearch.Dock = DockStyle.Top;
            pnSearch.Location = new Point(0, 185);
            pnSearch.Margin = new Padding(0, 6, 0, 0);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(658, 38);
            pnSearch.TabIndex = 7;
            // 
            // comboBox6
            // 
            comboBox6.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox6.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(187, 58);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(164, 23);
            comboBox6.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.DarkOrange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImageIndex = 1;
            button1.Location = new Point(586, 85);
            button1.Name = "button1";
            button1.Size = new Size(61, 27);
            button1.TabIndex = 8;
            button1.Text = "&Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(366, 62);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Required";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.AutoSize = true;
            button4.BackColor = Color.Green;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.ImageIndex = 1;
            button4.Location = new Point(519, 85);
            button4.Name = "button4";
            button4.Size = new Size(61, 27);
            button4.TabIndex = 9;
            button4.Text = "&Search";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 40);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 7;
            label3.Text = "SKU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 39);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 5;
            label5.Text = "Category";
            // 
            // comboBox7
            // 
            comboBox7.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox7.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(7, 58);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(164, 23);
            comboBox7.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 8);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 1;
            label6.Text = "Search";
            // 
            // btnExpand
            // 
            btnExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExpand.FlatStyle = FlatStyle.Flat;
            btnExpand.ImageIndex = 1;
            btnExpand.ImageList = imageList;
            btnExpand.Location = new Point(609, 9);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(38, 23);
            btnExpand.TabIndex = 3;
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToOrderColumns = true;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Top;
            dgv.Location = new Point(0, 229);
            dgv.Margin = new Padding(0, 6, 0, 0);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(658, 100);
            dgv.TabIndex = 12;
            // 
            // PrintedProductsEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(FlPanel);
            Controls.Add(pnHeader);
            Name = "PrintedProductsEdit";
            Size = new Size(690, 497);
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            FlPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnHeader;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label lblBack;
        private ImageList imageList;
        private FlowLayoutPanel FlPanel;
        private Panel panel1;
        private Label label12;
        private TextBox textBox3;
        private Label label13;
        private TextBox textBox4;
        private Label label14;
        private TextBox textBox5;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox comboBox5;
        private Panel pnSearch;
        private ComboBox comboBox6;
        private Button button1;
        private CheckBox checkBox1;
        private Button button4;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox7;
        private Label label6;
        private Button btnExpand;
        private DataGridView dgv;
    }
}
