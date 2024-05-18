namespace Dukon_Project
{
    partial class FormSealer
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
            components = new System.ComponentModel.Container();
            btnSearchProduct = new Button();
            btnBekorQ = new Button();
            tbMiqdor = new TextBox();
            tbId = new TextBox();
            tbGetProduct = new TextBox();
            dataGridView2 = new DataGridView();
            btnSale = new Button();
            dataGridViewProductTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            btBack = new Button();
            btnLogOut = new Button();
            label3 = new Label();
            tbNewSearch = new TextBox();
            BtnSearchNew = new Button();
            linkLabel1 = new LinkLabel();
            btnFilter = new Button();
            cmbF = new ComboBox();
            cmbFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.FromArgb(128, 255, 128);
            btnSearchProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchProduct.Location = new Point(1695, 150);
            btnSearchProduct.Margin = new Padding(4);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(192, 44);
            btnSearchProduct.TabIndex = 1;
            btnSearchProduct.Text = "Add Product";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // btnBekorQ
            // 
            btnBekorQ.BackColor = Color.FromArgb(255, 128, 128);
            btnBekorQ.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBekorQ.Location = new Point(1120, 772);
            btnBekorQ.Margin = new Padding(4);
            btnBekorQ.Name = "btnBekorQ";
            btnBekorQ.Size = new Size(265, 114);
            btnBekorQ.TabIndex = 2;
            btnBekorQ.Text = "Bekor qilish";
            btnBekorQ.UseVisualStyleBackColor = false;
            btnBekorQ.Click += btnBekorQ_Click;
            // 
            // tbMiqdor
            // 
            tbMiqdor.Location = new Point(1470, 156);
            tbMiqdor.Margin = new Padding(4);
            tbMiqdor.Name = "tbMiqdor";
            tbMiqdor.Size = new Size(169, 31);
            tbMiqdor.TabIndex = 3;
            tbMiqdor.TextChanged += tbMiqdor_TextChanged;
            // 
            // tbId
            // 
            tbId.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbId.Location = new Point(1425, 584);
            tbId.Margin = new Padding(4);
            tbId.Name = "tbId";
            tbId.Size = new Size(308, 34);
            tbId.TabIndex = 4;
            tbId.TextChanged += tbUpdate_TextChanged;
            // 
            // tbGetProduct
            // 
            tbGetProduct.Location = new Point(1695, 74);
            tbGetProduct.Margin = new Padding(4);
            tbGetProduct.Name = "tbGetProduct";
            tbGetProduct.Size = new Size(145, 31);
            tbGetProduct.TabIndex = 5;
            tbGetProduct.TextChanged += textBox3_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(919, 242);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(902, 261);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.Yellow;
            btnSale.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSale.Location = new Point(1565, 770);
            btnSale.Margin = new Padding(4);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(290, 116);
            btnSale.TabIndex = 10;
            btnSale.Text = "Sale";
            btnSale.UseVisualStyleBackColor = false;
            btnSale.Click += btnSale_Click;
            // 
            // dataGridViewProductTable
            // 
            dataGridViewProductTable.AutoGenerateColumns = false;
            dataGridViewProductTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductTable.Columns.AddRange(new DataGridViewColumn[] { ID, productNameDataGridViewTextBoxColumn, productPriceDataGridViewTextBoxColumn, productSizeDataGridViewTextBoxColumn, productDateTimeDataGridViewTextBoxColumn });
            dataGridViewProductTable.DataSource = productBindingSource;
            dataGridViewProductTable.Location = new Point(13, 102);
            dataGridViewProductTable.Margin = new Padding(4);
            dataGridViewProductTable.Name = "dataGridViewProductTable";
            dataGridViewProductTable.RowHeadersWidth = 51;
            dataGridViewProductTable.Size = new Size(873, 835);
            dataGridViewProductTable.TabIndex = 11;
            dataGridViewProductTable.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "Id";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            productPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productSizeDataGridViewTextBoxColumn
            // 
            productSizeDataGridViewTextBoxColumn.DataPropertyName = "ProductSize";
            productSizeDataGridViewTextBoxColumn.HeaderText = "ProductSize";
            productSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            productSizeDataGridViewTextBoxColumn.Name = "productSizeDataGridViewTextBoxColumn";
            productSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDateTimeDataGridViewTextBoxColumn
            // 
            productDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ProductDateTime";
            productDateTimeDataGridViewTextBoxColumn.HeaderText = "ProductDateTime";
            productDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDateTimeDataGridViewTextBoxColumn.Name = "productDateTimeDataGridViewTextBoxColumn";
            productDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(classes.Product);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1022, 158);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(391, 29);
            label1.TabIndex = 12;
            label1.Text = "maxsulot miqdorini kiriting:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1065, 586);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(348, 32);
            label2.TabIndex = 14;
            label2.Text = "Keraksiz maxsulot Id kiriting:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Lime;
            btBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBack.Location = new Point(1798, 571);
            btBack.Margin = new Padding(4);
            btBack.Name = "btBack";
            btBack.Size = new Size(248, 56);
            btBack.TabIndex = 15;
            btBack.Text = "Ro'yhatdan olish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(1938, 15);
            btnLogOut.Margin = new Padding(4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(150, 44);
            btnLogOut.TabIndex = 16;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(999, 76);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(627, 29);
            label3.TabIndex = 17;
            label3.Text = "savatga qo'shiladigan maxsulot id sini tanlang:";
            // 
            // tbNewSearch
            // 
            tbNewSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNewSearch.ForeColor = Color.Gray;
            tbNewSearch.Location = new Point(467, 43);
            tbNewSearch.Margin = new Padding(4);
            tbNewSearch.Name = "tbNewSearch";
            tbNewSearch.Size = new Size(293, 34);
            tbNewSearch.TabIndex = 18;
            tbNewSearch.Text = " Search";
            // 
            // BtnSearchNew
            // 
            BtnSearchNew.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSearchNew.Location = new Point(768, 41);
            BtnSearchNew.Margin = new Padding(4);
            BtnSearchNew.Name = "BtnSearchNew";
            BtnSearchNew.Size = new Size(118, 36);
            BtnSearchNew.TabIndex = 19;
            BtnSearchNew.Text = "Search";
            BtnSearchNew.UseVisualStyleBackColor = true;
            BtnSearchNew.Click += BtnSearchNew_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.Black;
            linkLabel1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(1695, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(225, 32);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Dasturdan chiqish";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(192, 255, 192);
            btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.Location = new Point(256, 41);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 36);
            btnFilter.TabIndex = 21;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbF
            // 
            cmbF.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbF.FormattingEnabled = true;
            cmbF.Items.AddRange(new object[] { "O", "K" });
            cmbF.Location = new Point(12, 38);
            cmbF.Name = "cmbF";
            cmbF.Size = new Size(50, 36);
            cmbF.TabIndex = 22;
            cmbF.Text = "O";
            // 
            // cmbFilter
            // 
            cmbFilter.BackColor = Color.White;
            cmbFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFilter.ForeColor = SystemColors.AppWorkspace;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Id", "ProductName", "ProductPrice", "ProductSize", "ProductDateTime" });
            cmbFilter.Location = new Point(68, 38);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(182, 36);
            cmbFilter.TabIndex = 23;
            cmbFilter.Text = " Sort";
            // 
            // FormSealer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1924, 1050);
            Controls.Add(cmbFilter);
            Controls.Add(cmbF);
            Controls.Add(btnFilter);
            Controls.Add(linkLabel1);
            Controls.Add(BtnSearchNew);
            Controls.Add(tbNewSearch);
            Controls.Add(label3);
            Controls.Add(btnLogOut);
            Controls.Add(btBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewProductTable);
            Controls.Add(btnSale);
            Controls.Add(dataGridView2);
            Controls.Add(tbGetProduct);
            Controls.Add(tbId);
            Controls.Add(tbMiqdor);
            Controls.Add(btnBekorQ);
            Controls.Add(btnSearchProduct);
            Margin = new Padding(4);
            Name = "FormSealer";
            Text = "FormSealer";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearchProduct;
        private Button btnBekorQ;
        private TextBox tbMiqdor;
        private TextBox tbId;
        private TextBox tbGetProduct;
        private DataGridView dataGridView2;
        private Button btnSale;
        private DataGridView dataGridViewProductTable;
        private BindingSource productBindingSource;
        private Label label1;
        private Label label2;
        private Button btBack;
        private Button btnLogOut;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDateTimeDataGridViewTextBoxColumn;
        private Label label3;
        private TextBox tbNewSearch;
        private Button BtnSearchNew;
        private LinkLabel linkLabel1;
        private Button btnFilter;
        private ComboBox cmbF;
        private ComboBox cmbFilter;
    }
}