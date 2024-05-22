namespace Dukon_Project
{
    partial class FormTushum
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


        private void InitializeComponent()
        {
            btnEnterTushum = new Button();
            label1 = new Label();
            tbSana = new TextBox();
            tbsumm = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            BtnNazat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEnterTushum
            // 
            btnEnterTushum.BackColor = Color.FromArgb(128, 255, 128);
            btnEnterTushum.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnterTushum.Location = new Point(537, 243);
            btnEnterTushum.Margin = new Padding(4);
            btnEnterTushum.Name = "btnEnterTushum";
            btnEnterTushum.Size = new Size(150, 59);
            btnEnterTushum.TabIndex = 0;
            btnEnterTushum.Text = "Bugungi tushum";
            btnEnterTushum.UseVisualStyleBackColor = true;
            btnEnterTushum.Click += btnEnterTushum_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 134);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 1;
            label1.Text = "Bugungi tushum";
            // 
            // tbSana
            // 
            tbSana.Location = new Point(549, 42);
            tbSana.Name = "tbSana";
            tbSana.Size = new Size(158, 31);
            tbSana.TabIndex = 2;
            tbSana.TextChanged += tbSana_TextChanged;
            // 
            // tbsumm
            // 
            tbsumm.Location = new Point(562, 135);
            tbsumm.Name = "tbsumm";
            tbsumm.Size = new Size(145, 31);
            tbsumm.TabIndex = 3;
            tbsumm.TextChanged += tbUserIsmi_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(737, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 4;
            label2.Text = "so'm";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 414);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(361, 42);
            label3.Name = "label3";
            label3.Size = new Size(170, 32);
            label3.TabIndex = 6;
            label3.Text = "Bugungi sana";
            // 
            // BtnNazat
            // 
            BtnNazat.Location = new Point(626, 378);
            BtnNazat.Name = "BtnNazat";
            BtnNazat.Size = new Size(128, 48);
            BtnNazat.TabIndex = 7;
            BtnNazat.Text = "Back";
            BtnNazat.UseVisualStyleBackColor = true;
           
            // 
            // FormTushum
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1156, 450);
            Controls.Add(BtnNazat);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(tbsumm);
            Controls.Add(tbSana);
            Controls.Add(label1);
            Controls.Add(btnEnterTushum);
            Margin = new Padding(4);
            Name = "FormTushum";
            Text = "FormTushum";
            Load += FormTushum_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnterTushum;
        private Label label1;
        private TextBox tbSana;
        private TextBox tbsumm;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Button BtnNazat;
    }
}