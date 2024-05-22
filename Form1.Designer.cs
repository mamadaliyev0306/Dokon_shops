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
            btnTasdiqlash = new Button();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btnUpdateParol = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 60);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            // 
            // btnTasdiqlash
            // 
            btnTasdiqlash.BackColor = Color.FromArgb(128, 255, 128);
            btnTasdiqlash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTasdiqlash.Location = new Point(104, 348);
            btnTasdiqlash.Margin = new Padding(4);
            btnTasdiqlash.Name = "btnTasdiqlash";
            btnTasdiqlash.Size = new Size(483, 47);
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
            tbUserName.Location = new Point(199, 137);
            tbUserName.Margin = new Padding(4);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(362, 39);
            tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(224, 224, 224);
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(199, 246);
            tbPassword.Margin = new Padding(4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(362, 39);
            tbPassword.TabIndex = 4;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // btnUpdateParol
            // 
            btnUpdateParol.BackColor = Color.FromArgb(128, 128, 255);
            btnUpdateParol.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnUpdateParol.Location = new Point(143, 436);
            btnUpdateParol.Margin = new Padding(4);
            btnUpdateParol.Name = "btnUpdateParol";
            btnUpdateParol.Size = new Size(418, 48);
            btnUpdateParol.TabIndex = 5;
            btnUpdateParol.Text = "Login or password update";
            btnUpdateParol.UseVisualStyleBackColor = false;
            btnUpdateParol.Click += btnUpdateParol_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 128, 255);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbUserName);
            groupBox1.Controls.Add(btnUpdateParol);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Controls.Add(btnTasdiqlash);
            groupBox1.Location = new Point(458, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(628, 624);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1348, 12);
            button1.Name = "button1";
            button1.Size = new Size(53, 40);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 131);
            label2.Name = "label2";
            label2.Size = new Size(183, 45);
            label2.TabIndex = 8;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 240);
            label3.Name = "label3";
            label3.Size = new Size(171, 45);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1671, 645);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnTasdiqlash;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btnUpdateParol;
        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}
