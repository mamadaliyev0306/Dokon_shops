namespace Dukon_Project
{
    partial class FormReport
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
            btnTushum = new Button();
            btnFilter = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnTushum
            // 
            btnTushum.BackColor = Color.FromArgb(128, 255, 128);
            btnTushum.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTushum.Location = new Point(156, 50);
            btnTushum.Margin = new Padding(4);
            btnTushum.Name = "btnTushum";
            btnTushum.Size = new Size(278, 70);
            btnTushum.TabIndex = 0;
            btnTushum.Text = "Tushum";
            btnTushum.UseVisualStyleBackColor = false;
            btnTushum.Click += btnTushum_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(255, 224, 192);
            btnFilter.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.Location = new Point(156, 183);
            btnFilter.Margin = new Padding(4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(278, 70);
            btnFilter.TabIndex = 1;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(637, 351);
            button1.Name = "button1";
            button1.Size = new Size(222, 58);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1036, 563);
            Controls.Add(button1);
            Controls.Add(btnFilter);
            Controls.Add(btnTushum);
            Margin = new Padding(4);
            Name = "FormReport";
            Text = "FormReport";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTushum;
        private Button btnFilter;
        private Button button1;
    }
}