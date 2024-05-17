namespace Dukon_Project
{
    partial class Seale
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnSeale = new Button();
            label3 = new Label();
            summa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 15);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(739, 235);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 337);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 38);
            label1.TabIndex = 1;
            label1.Text = "tulov summasi";
            label1.Click += label1_Click;
            // 
            // btnSeale
            // 
            btnSeale.BackColor = Color.FromArgb(128, 255, 128);
            btnSeale.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeale.Location = new Point(131, 442);
            btnSeale.Margin = new Padding(5, 5, 5, 5);
            btnSeale.Name = "btnSeale";
            btnSeale.Size = new Size(496, 52);
            btnSeale.TabIndex = 2;
            btnSeale.Text = "Seale";
            btnSeale.UseVisualStyleBackColor = false;
            btnSeale.Click += btnSeale_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(437, 335);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 38);
            label3.TabIndex = 4;
            label3.Text = "so'm";
            label3.Click += label3_Click;
            // 
            // summa
            // 
            summa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summa.Location = new Point(258, 337);
            summa.Margin = new Padding(5, 5, 5, 5);
            summa.Name = "summa";
            summa.Size = new Size(155, 39);
            summa.TabIndex = 5;
            summa.TextChanged += summa_TextChanged;
            // 
            // Seale
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1119, 632);
            Controls.Add(summa);
            Controls.Add(label3);
            Controls.Add(btnSeale);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Seale";
            Text = "Seale";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnSeale;
        private Label label3;
        private TextBox summa;
    }
}