namespace Dukon_Project
{
    partial class FormLastPassword
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
            btnTasdiqlashEskisi = new Button();
            tbEskiPassword = new TextBox();
            tbEskiUserName = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 38);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 184);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 38);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // btnTasdiqlashEskisi
            // 
            btnTasdiqlashEskisi.BackColor = Color.FromArgb(128, 255, 128);
            btnTasdiqlashEskisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTasdiqlashEskisi.Location = new Point(155, 312);
            btnTasdiqlashEskisi.Margin = new Padding(4, 4, 4, 4);
            btnTasdiqlashEskisi.Name = "btnTasdiqlashEskisi";
            btnTasdiqlashEskisi.Size = new Size(450, 50);
            btnTasdiqlashEskisi.TabIndex = 2;
            btnTasdiqlashEskisi.Text = "Tasdiqlash";
            btnTasdiqlashEskisi.UseVisualStyleBackColor = false;
            btnTasdiqlashEskisi.Click += btnTasdiqlashEskisi_Click;
            // 
            // tbEskiPassword
            // 
            tbEskiPassword.Location = new Point(228, 191);
            tbEskiPassword.Margin = new Padding(4, 4, 4, 4);
            tbEskiPassword.Name = "tbEskiPassword";
            tbEskiPassword.Size = new Size(315, 31);
            tbEskiPassword.TabIndex = 3;
            // 
            // tbEskiUserName
            // 
            tbEskiUserName.Location = new Point(228, 96);
            tbEskiUserName.Margin = new Padding(4, 4, 4, 4);
            tbEskiUserName.Name = "tbEskiUserName";
            tbEskiUserName.Size = new Size(315, 31);
            tbEskiUserName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(509, 38);
            label3.TabIndex = 5;
            label3.Text = "Eski UserName va Passwordni kiriting";
            // 
            // FormLastPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1217, 582);
            Controls.Add(label3);
            Controls.Add(tbEskiUserName);
            Controls.Add(tbEskiPassword);
            Controls.Add(btnTasdiqlashEskisi);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormLastPassword";
            Text = "FormLastPassword";
            Load += FormLastPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnTasdiqlashEskisi;
        private TextBox tbEskiPassword;
        private TextBox tbEskiUserName;
        private Label label3;
    }
}