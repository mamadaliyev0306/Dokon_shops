namespace Dukon_Project
{
    partial class FormDelete
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
            btnDelete = new Button();
            dataGridViewDelete = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            txbSeach = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDelete).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1056, 67);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 47);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewDelete
            // 
            dataGridViewDelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDelete.Location = new Point(41, 67);
            dataGridViewDelete.Margin = new Padding(4);
            dataGridViewDelete.Name = "dataGridViewDelete";
            dataGridViewDelete.RowHeadersWidth = 51;
            dataGridViewDelete.Size = new Size(907, 517);
            dataGridViewDelete.TabIndex = 1;
            dataGridViewDelete.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(698, 21);
            button1.Name = "button1";
            button1.Size = new Size(112, 39);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 3;
            label1.Text = "ProductName";
            // 
            // txbSeach
            // 
            txbSeach.Location = new Point(353, 24);
            txbSeach.Name = "txbSeach";
            txbSeach.Size = new Size(308, 31);
            txbSeach.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1056, 147);
            button2.Name = "button2";
            button2.Size = new Size(169, 51);
            button2.TabIndex = 5;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormDelete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 642);
            Controls.Add(button2);
            Controls.Add(txbSeach);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridViewDelete);
            Controls.Add(btnDelete);
            Margin = new Padding(4);
            Name = "FormDelete";
            Text = "FormDelete";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private DataGridView dataGridViewDelete;
        private Button button1;
        private Label label1;
        private TextBox txbSeach;
        private Button button2;
    }
}