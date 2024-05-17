namespace Dukon_Project
{
    partial class FormRead
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
            dataGridViewRead = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            btnSearch = new Button();
            tbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRead).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRead
            // 
            dataGridViewRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRead.Location = new Point(35, 72);
            dataGridViewRead.Name = "dataGridViewRead";
            dataGridViewRead.RowHeadersWidth = 62;
            dataGridViewRead.Size = new Size(951, 549);
            dataGridViewRead.TabIndex = 0;
            dataGridViewRead.CellContentClick += dataGridViewRead_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1179, 549);
            button1.Name = "button1";
            button1.Size = new Size(146, 58);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 18);
            label1.Name = "label1";
            label1.Size = new Size(198, 38);
            label1.TabIndex = 2;
            label1.Text = "ProductName";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 128);
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(678, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 38);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(287, 26);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(346, 34);
            tbSearch.TabIndex = 4;
            // 
            // FormRead
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1376, 649);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridViewRead);
            Name = "FormRead";
            Text = "FormReat";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRead).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRead;
        private Button button1;
        private Label label1;
        private Button btnSearch;
        private TextBox tbSearch;
    }
}