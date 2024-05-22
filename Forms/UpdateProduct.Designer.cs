namespace Dukon_Project
{
    partial class UpdateProduct
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
            productBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnUpdate = new Button();
            textBoxProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbProductID = new TextBox();
            btnSearch = new Button();
            btnBack = new Button();
            productBindingSource1 = new BindingSource(components);
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxNewName = new TextBox();
            textBoxNewPrice = new TextBox();
            textBoxNewDateTime = new TextBox();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            textBoxNewMiqdor = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(classes.Product);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 2, 0, 2);
            menuStrip1.Size = new Size(1924, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, productPriceDataGridViewTextBoxColumn, productSizeDataGridViewTextBoxColumn, productDateTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(16, 96);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1014, 608);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
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
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 255);
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.ImageAlign = ContentAlignment.BottomLeft;
            btnUpdate.Location = new Point(1622, 636);
            btnUpdate.Margin = new Padding(5, 4, 5, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(265, 68);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "MAXSULOTNI  TAHRIRLASH";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(395, 37);
            textBoxProductName.Margin = new Padding(5, 4, 5, 4);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(352, 34);
            textBoxProductName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(32, 39);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 29);
            label1.TabIndex = 4;
            label1.Text = "Maxsulot nomini kiriting ";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(1054, 184);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(289, 29);
            label2.TabIndex = 5;
            label2.Text = "Maxsulot ID sini kiriting ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F);
            label3.Location = new Point(1242, 55);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(408, 45);
            label3.TabIndex = 6;
            label3.Text = "Maxsulotlarni Tahrirlash";
            label3.Click += label3_Click;
            // 
            // tbProductID
            // 
            tbProductID.Location = new Point(1436, 181);
            tbProductID.Margin = new Padding(5, 4, 5, 4);
            tbProductID.Name = "tbProductID";
            tbProductID.Size = new Size(212, 34);
            tbProductID.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 128);
            btnSearch.Font = new Font("Microsoft Sans Serif", 9F);
            btnSearch.ForeColor = Color.Black;
            btnSearch.ImageAlign = ContentAlignment.BottomLeft;
            btnSearch.Location = new Point(811, 35);
            btnSearch.Margin = new Padding(5, 4, 5, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(164, 36);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(128, 255, 128);
            btnBack.Font = new Font("Microsoft Sans Serif", 9F);
            btnBack.ForeColor = Color.Black;
            btnBack.ImageAlign = ContentAlignment.BottomLeft;
            btnBack.Location = new Point(1084, 640);
            btnBack.Margin = new Padding(5, 4, 5, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(265, 65);
            btnBack.TabIndex = 9;
            btnBack.Text = "ORQAGA";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(classes.Product);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(1054, 278);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(299, 29);
            label4.TabIndex = 10;
            label4.Text = "Maxsulotning yangi nomi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(1055, 372);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(298, 29);
            label5.TabIndex = 11;
            label5.Text = "Maxsulotning yangi narxi";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(1054, 563);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(321, 29);
            label6.TabIndex = 12;
            label6.Text = "Maxsulotning yangi Sanasi";
            // 
            // textBoxNewName
            // 
            textBoxNewName.Location = new Point(1436, 278);
            textBoxNewName.Margin = new Padding(5, 4, 5, 4);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(410, 34);
            textBoxNewName.TabIndex = 13;
            // 
            // textBoxNewPrice
            // 
            textBoxNewPrice.Location = new Point(1436, 372);
            textBoxNewPrice.Margin = new Padding(5, 4, 5, 4);
            textBoxNewPrice.Name = "textBoxNewPrice";
            textBoxNewPrice.Size = new Size(410, 34);
            textBoxNewPrice.TabIndex = 14;
            // 
            // textBoxNewDateTime
            // 
            textBoxNewDateTime.Location = new Point(1460, 563);
            textBoxNewDateTime.Margin = new Padding(5, 4, 5, 4);
            textBoxNewDateTime.Name = "textBoxNewDateTime";
            textBoxNewDateTime.Size = new Size(386, 34);
            textBoxNewDateTime.TabIndex = 15;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1135, 404);
            linkLabel1.Margin = new Padding(5, 0, 5, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 28);
            linkLabel1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.Location = new Point(1054, 467);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(331, 29);
            label7.TabIndex = 17;
            label7.Text = "Maxsulotning yangi miqdori";
            // 
            // textBoxNewMiqdor
            // 
            textBoxNewMiqdor.Location = new Point(1460, 467);
            textBoxNewMiqdor.Margin = new Padding(5, 4, 5, 4);
            textBoxNewMiqdor.Name = "textBoxNewMiqdor";
            textBoxNewMiqdor.Size = new Size(386, 34);
            textBoxNewMiqdor.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(1680, 176);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(148, 40);
            button1.TabIndex = 19;
            button1.Text = "izlash";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1924, 813);
            Controls.Add(button1);
            Controls.Add(textBoxNewMiqdor);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(textBoxNewDateTime);
            Controls.Add(textBoxNewPrice);
            Controls.Add(textBoxNewName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(tbProductID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxProductName);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            Load += UpdateProduct_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource productBindingSource;
        private MenuStrip menuStrip1;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private TextBox textBoxProductName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbProductID;
        private Button btnSearch;
        private Button btnBack;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDateTimeDataGridViewTextBoxColumn;
        private BindingSource productBindingSource1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxNewName;
        private TextBox textBoxNewPrice;
        private TextBox textBoxNewDateTime;
        private LinkLabel linkLabel1;
        private Label label7;
        private TextBox textBoxNewMiqdor;
        private Button button1;
    }
}