namespace Dukon_Project
{
    partial class AddPerson
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
            button1 = new Button();
            button2 = new Button();
            dataGridViewRole = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbFIO = new TextBox();
            txbUserName = new TextBox();
            txbPassword = new TextBox();
            cmbRole = new ComboBox();
            btnDelete = new Button();
            btnSearch = new Button();
            label5 = new Label();
            tbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRole).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(45, 577);
            button1.Name = "button1";
            button1.Size = new Size(168, 56);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(258, 577);
            button2.Name = "button2";
            button2.Size = new Size(168, 56);
            button2.TabIndex = 1;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridViewRole
            // 
            dataGridViewRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRole.Location = new Point(516, 60);
            dataGridViewRole.Name = "dataGridViewRole";
            dataGridViewRole.RowHeadersWidth = 62;
            dataGridViewRole.Size = new Size(717, 537);
            dataGridViewRole.TabIndex = 2;
            dataGridViewRole.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 3;
            label1.Text = "FIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 5;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 294);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 6;
            label4.Text = "Role";
            // 
            // txbFIO
            // 
            txbFIO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbFIO.Location = new Point(150, 63);
            txbFIO.Name = "txbFIO";
            txbFIO.Size = new Size(324, 39);
            txbFIO.TabIndex = 7;
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbUserName.Location = new Point(150, 134);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(324, 39);
            txbUserName.TabIndex = 8;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(150, 218);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(324, 31);
            txbPassword.TabIndex = 9;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(150, 294);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(324, 33);
            cmbRole.TabIndex = 10;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1273, 63);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 47);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Lime;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1048, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 39);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(527, 20);
            label5.Name = "label5";
            label5.Size = new Size(132, 32);
            label5.TabIndex = 13;
            label5.Text = "UserName";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(676, 20);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(334, 31);
            tbSearch.TabIndex = 14;
            // 
            // AddPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 689);
            Controls.Add(tbSearch);
            Controls.Add(label5);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(cmbRole);
            Controls.Add(label2);
            Controls.Add(txbPassword);
            Controls.Add(txbUserName);
            Controls.Add(txbFIO);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridViewRole);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AddPerson";
            Text = "AddPerson";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridViewRole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbFIO;
        private TextBox txbUserName;
        private TextBox txbPassword;
        private ComboBox cmbRole;
        private Button btnDelete;
        private Button btnSearch;
        private Label label5;
        private TextBox tbSearch;
    }
}