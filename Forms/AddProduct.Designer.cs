namespace Dukon_Project
{
    partial class AddProduct
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProductName = new TextBox();
            txtProductDateTime = new TextBox();
            txtProductSize = new TextBox();
            txtProductPrice = new TextBox();
            button1 = new Button();
            dataGridViewCreate = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCreate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 38);
            label1.TabIndex = 0;
            label1.Text = "ProductName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 160);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 38);
            label2.TabIndex = 1;
            label2.Text = "ProductPrice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 242);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 38);
            label3.TabIndex = 2;
            label3.Text = "ProductSize";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 318);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(247, 38);
            label4.TabIndex = 3;
            label4.Text = "ProductDateTime";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(228, 82);
            txtProductName.Margin = new Padding(2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(322, 39);
            txtProductName.TabIndex = 5;
            txtProductName.TextChanged += textBox1_TextChanged;
            // 
            // txtProductDateTime
            // 
            txtProductDateTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductDateTime.Location = new Point(255, 319);
            txtProductDateTime.Margin = new Padding(2);
            txtProductDateTime.Name = "txtProductDateTime";
            txtProductDateTime.Size = new Size(295, 39);
            txtProductDateTime.TabIndex = 7;
            txtProductDateTime.TextChanged += txtProductDateTime_TextChanged;
            // 
            // txtProductSize
            // 
            txtProductSize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductSize.Location = new Point(228, 244);
            txtProductSize.Margin = new Padding(2);
            txtProductSize.Name = "txtProductSize";
            txtProductSize.Size = new Size(322, 39);
            txtProductSize.TabIndex = 8;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductPrice.Location = new Point(228, 162);
            txtProductPrice.Margin = new Padding(2);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(322, 39);
            txtProductPrice.TabIndex = 9;
            txtProductPrice.TextChanged += txtProductPrice_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(36, 554);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(190, 51);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewCreate
            // 
            dataGridViewCreate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCreate.Location = new Point(611, 52);
            dataGridViewCreate.Margin = new Padding(2);
            dataGridViewCreate.Name = "dataGridViewCreate";
            dataGridViewCreate.RowHeadersWidth = 62;
            dataGridViewCreate.Size = new Size(724, 558);
            dataGridViewCreate.TabIndex = 11;
            dataGridViewCreate.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(306, 554);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(190, 51);
            button2.TabIndex = 12;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1359, 658);
            Controls.Add(button2);
            Controls.Add(dataGridViewCreate);
            Controls.Add(button1);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductSize);
            Controls.Add(txtProductDateTime);
            Controls.Add(txtProductName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AddProduct";
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCreate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProductName;
        private TextBox textBox2;
        private TextBox txtProductDateTime;
        private TextBox txtProductSize;
        private TextBox txtProductPrice;
        private Button button1;
        private DataGridView dataGridViewCreate;
        private Button button2;
    }
}