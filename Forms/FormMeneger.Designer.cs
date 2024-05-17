namespace Dukon_Project
{
    partial class FormMeneger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button btnCreate;
        private void InitializeComponent()
        {
            btnCreate = new Button();
            btnDelete = new Button();
            btnRead = new Button();
            btnReport = new Button();
            btnUpdate = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(224, 224, 224);
            btnCreate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(42, 37);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(198, 92);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightGray;
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(302, 148);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 97);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.LightGray;
            btnRead.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(302, 37);
            btnRead.Margin = new Padding(2);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(174, 92);
            btnRead.TabIndex = 3;
            btnRead.Text = "Products";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.LightGray;
            btnReport.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.Location = new Point(169, 274);
            btnReport.Margin = new Padding(2);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(202, 100);
            btnReport.TabIndex = 4;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(42, 150);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(198, 92);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1029, 28);
            button1.Name = "button1";
            button1.Size = new Size(229, 45);
            button1.TabIndex = 7;
            button1.Text = "Dasturdan chiqish";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormMeneger
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1318, 632);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(btnReport);
            Controls.Add(btnRead);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Margin = new Padding(2);
            Name = "FormMeneger";
            Text = "FormMeneger";
            ResumeLayout(false);
        }

        private Button btnDelete;
        private Button btnRead;
        private Button btnReport;
        private DataGridView GetProduct;
        private Button btnUpdate;
        private Button button1;
    }
}