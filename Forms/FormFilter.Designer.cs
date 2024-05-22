namespace Dukon_Project
{
    partial class FormFilter
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
            btnSearchFilter = new Button();
            label1 = new Label();
            label2 = new Label();
            tbLastDate = new TextBox();
            tbNextDate = new TextBox();
            dataGridView1 = new DataGridView();
            BtnBackReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSearchFilter
            // 
            btnSearchFilter.BackColor = Color.FromArgb(128, 255, 128);
            btnSearchFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchFilter.Location = new Point(156, 296);
            btnSearchFilter.Margin = new Padding(4);
            btnSearchFilter.Name = "btnSearchFilter";
            btnSearchFilter.Size = new Size(193, 51);
            btnSearchFilter.TabIndex = 0;
            btnSearchFilter.Text = "search";
            btnSearchFilter.UseVisualStyleBackColor = false;
            btnSearchFilter.Click += btnSearchFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 79);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 1;
            label1.Text = "lastDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 192);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 2;
            label2.Text = "nextDate";
            // 
            // tbLastDate
            // 
            tbLastDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbLastDate.Location = new Point(134, 79);
            tbLastDate.Margin = new Padding(4);
            tbLastDate.Name = "tbLastDate";
            tbLastDate.Size = new Size(244, 34);
            tbLastDate.TabIndex = 3;
            tbLastDate.TextChanged += tbLastDate_TextChanged;
            // 
            // tbNextDate
            // 
            tbNextDate.Location = new Point(134, 192);
            tbNextDate.Margin = new Padding(4);
            tbNextDate.Name = "tbNextDate";
            tbNextDate.Size = new Size(244, 31);
            tbNextDate.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 31);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(871, 530);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnBackReport
            // 
            BtnBackReport.Location = new Point(149, 381);
            BtnBackReport.Name = "BtnBackReport";
            BtnBackReport.Size = new Size(200, 50);
            BtnBackReport.TabIndex = 6;
            BtnBackReport.Text = "Back";
            BtnBackReport.UseVisualStyleBackColor = true;
        
            // 
            // FormFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1360, 588);
            Controls.Add(BtnBackReport);
            Controls.Add(dataGridView1);
            Controls.Add(tbNextDate);
            Controls.Add(tbLastDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearchFilter);
            Margin = new Padding(4);
            Name = "FormFilter";
            Text = "FormFilter";
            Load += FormFilter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchFilter;
        private Label label1;
        private Label label2;
        private TextBox tbLastDate;
        private TextBox tbNextDate;
        private DataGridView dataGridView1;
        private Button BtnBackReport;
    }
}