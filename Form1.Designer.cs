namespace Dukon_Project
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnTasdiqlash = new Button();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btnUpdateParol = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 125);
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
            label2.Location = new Point(13, 219);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 38);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // btnTasdiqlash
            // 
            btnTasdiqlash.BackColor = Color.FromArgb(128, 255, 128);
            btnTasdiqlash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTasdiqlash.Location = new Point(162, 321);
            btnTasdiqlash.Margin = new Padding(4, 4, 4, 4);
            btnTasdiqlash.Name = "btnTasdiqlash";
            btnTasdiqlash.Size = new Size(406, 47);
            btnTasdiqlash.TabIndex = 2;
            btnTasdiqlash.Text = "Tasdiqlash";
            btnTasdiqlash.UseVisualStyleBackColor = false;
            btnTasdiqlash.Click += btnTasdiqlash_Click;
            // 
            // tbUserName
            // 
            tbUserName.AcceptsTab = true;
            tbUserName.BackColor = Color.FromArgb(224, 224, 224);
            tbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUserName.Location = new Point(197, 127);
            tbUserName.Margin = new Padding(4, 4, 4, 4);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(343, 39);
            tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(224, 224, 224);
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(197, 227);
            tbPassword.Margin = new Padding(4, 4, 4, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(343, 39);
            tbPassword.TabIndex = 4;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // btnUpdateParol
            // 
            btnUpdateParol.BackColor = Color.FromArgb(192, 192, 255);
            btnUpdateParol.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnUpdateParol.Location = new Point(162, 413);
            btnUpdateParol.Margin = new Padding(4, 4, 4, 4);
            btnUpdateParol.Name = "btnUpdateParol";
            btnUpdateParol.Size = new Size(425, 48);
            btnUpdateParol.TabIndex = 5;
            btnUpdateParol.Text = "Login or password update";
            btnUpdateParol.UseVisualStyleBackColor = false;
            btnUpdateParol.Click += btnUpdateParol_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1133, 645);
            Controls.Add(btnUpdateParol);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(btnTasdiqlash);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnTasdiqlash;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btnUpdateParol;
    }
}
