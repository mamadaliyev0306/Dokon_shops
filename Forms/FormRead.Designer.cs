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
            btnSearch = new Button();
            tbSearch = new TextBox();
            menuStrip1 = new MenuStrip();
            chiqishToolStripMenuItem = new ToolStripMenuItem();
            menyugaQaytishToolStripMenuItem = new ToolStripMenuItem();
            logingaQaytishToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRead).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewRead
            // 
            dataGridViewRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRead.Location = new Point(37, 103);
            dataGridViewRead.Name = "dataGridViewRead";
            dataGridViewRead.RowHeadersWidth = 62;
            dataGridViewRead.Size = new Size(1161, 549);
            dataGridViewRead.TabIndex = 0;
            dataGridViewRead.CellContentClick += dataGridViewRead_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 128);
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(641, 42);
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
            tbSearch.Location = new Point(220, 46);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(415, 34);
            tbSearch.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chiqishToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1608, 40);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // chiqishToolStripMenuItem
            // 
            chiqishToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menyugaQaytishToolStripMenuItem, logingaQaytishToolStripMenuItem });
            chiqishToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chiqishToolStripMenuItem.Name = "chiqishToolStripMenuItem";
            chiqishToolStripMenuItem.Size = new Size(113, 36);
            chiqishToolStripMenuItem.Text = "Chiqish";
            // 
            // menyugaQaytishToolStripMenuItem
            // 
            menyugaQaytishToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menyugaQaytishToolStripMenuItem.Name = "menyugaQaytishToolStripMenuItem";
            menyugaQaytishToolStripMenuItem.Size = new Size(279, 36);
            menyugaQaytishToolStripMenuItem.Text = "Menyuga qaytish";
            // 
            // logingaQaytishToolStripMenuItem
            // 
            logingaQaytishToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logingaQaytishToolStripMenuItem.Name = "logingaQaytishToolStripMenuItem";
            logingaQaytishToolStripMenuItem.Size = new Size(279, 36);
            logingaQaytishToolStripMenuItem.Text = "Loginga qaytish";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1355, 103);
            button1.Name = "button1";
            button1.Size = new Size(146, 58);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormRead
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1608, 649);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Controls.Add(button1);
            Controls.Add(dataGridViewRead);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormRead";
            Text = "FormReat";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRead).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRead;
        private Button btnSearch;
        private TextBox tbSearch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chiqishToolStripMenuItem;
        private ToolStripMenuItem menyugaQaytishToolStripMenuItem;
        private ToolStripMenuItem logingaQaytishToolStripMenuItem;
        private Button button1;
    }
}