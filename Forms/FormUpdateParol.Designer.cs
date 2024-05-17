namespace Dukon_Project
{
    partial class FormUpdateParol
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
            lbFIOUpdate = new Label();
            lbNameUpdate = new Label();
            lbUpdateParol = new Label();
            btnUpdateEnter = new Button();
            tbParolUpdate = new TextBox();
            tbUsernameUpdate = new TextBox();
            tbFIOUpdate = new TextBox();
            SuspendLayout();
            // 
            // lbFIOUpdate
            // 
            lbFIOUpdate.AutoSize = true;
            lbFIOUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFIOUpdate.Location = new Point(71, 50);
            lbFIOUpdate.Margin = new Padding(4, 0, 4, 0);
            lbFIOUpdate.Name = "lbFIOUpdate";
            lbFIOUpdate.Size = new Size(62, 38);
            lbFIOUpdate.TabIndex = 0;
            lbFIOUpdate.Text = "FIO";
            // 
            // lbNameUpdate
            // 
            lbNameUpdate.AutoSize = true;
            lbNameUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameUpdate.Location = new Point(71, 131);
            lbNameUpdate.Margin = new Padding(4, 0, 4, 0);
            lbNameUpdate.Name = "lbNameUpdate";
            lbNameUpdate.Size = new Size(153, 38);
            lbNameUpdate.TabIndex = 1;
            lbNameUpdate.Text = "UserName";
            // 
            // lbUpdateParol
            // 
            lbUpdateParol.AutoSize = true;
            lbUpdateParol.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUpdateParol.Location = new Point(71, 203);
            lbUpdateParol.Margin = new Padding(4, 0, 4, 0);
            lbUpdateParol.Name = "lbUpdateParol";
            lbUpdateParol.Size = new Size(139, 38);
            lbUpdateParol.TabIndex = 2;
            lbUpdateParol.Text = "Password";
            // 
            // btnUpdateEnter
            // 
            btnUpdateEnter.BackColor = Color.FromArgb(192, 255, 192);
            btnUpdateEnter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateEnter.Location = new Point(252, 314);
            btnUpdateEnter.Margin = new Padding(4, 4, 4, 4);
            btnUpdateEnter.Name = "btnUpdateEnter";
            btnUpdateEnter.Size = new Size(405, 46);
            btnUpdateEnter.TabIndex = 3;
            btnUpdateEnter.Text = "Tasdiqlash";
            btnUpdateEnter.UseVisualStyleBackColor = false;
            btnUpdateEnter.Click += btnUpdateEnter_Click;
            // 
            // tbParolUpdate
            // 
            tbParolUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbParolUpdate.Location = new Point(252, 205);
            tbParolUpdate.Margin = new Padding(4, 4, 4, 4);
            tbParolUpdate.Name = "tbParolUpdate";
            tbParolUpdate.Size = new Size(404, 39);
            tbParolUpdate.TabIndex = 4;
            // 
            // tbUsernameUpdate
            // 
            tbUsernameUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsernameUpdate.Location = new Point(252, 131);
            tbUsernameUpdate.Margin = new Padding(4, 4, 4, 4);
            tbUsernameUpdate.Name = "tbUsernameUpdate";
            tbUsernameUpdate.Size = new Size(404, 39);
            tbUsernameUpdate.TabIndex = 5;
            tbUsernameUpdate.TextChanged += tbUsernameUpdate_TextChanged;
            // 
            // tbFIOUpdate
            // 
            tbFIOUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbFIOUpdate.Location = new Point(252, 50);
            tbFIOUpdate.Margin = new Padding(4, 4, 4, 4);
            tbFIOUpdate.Name = "tbFIOUpdate";
            tbFIOUpdate.Size = new Size(404, 39);
            tbFIOUpdate.TabIndex = 6;
            // 
            // FormUpdateParol
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(998, 621);
            Controls.Add(tbFIOUpdate);
            Controls.Add(tbUsernameUpdate);
            Controls.Add(tbParolUpdate);
            Controls.Add(btnUpdateEnter);
            Controls.Add(lbUpdateParol);
            Controls.Add(lbNameUpdate);
            Controls.Add(lbFIOUpdate);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormUpdateParol";
            Text = "FormUpdateParol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFIOUpdate;
        private Label lbNameUpdate;
        private Label lbUpdateParol;
        private Button btnUpdateEnter;
        private TextBox tbParolUpdate;
        private TextBox tbUsernameUpdate;
        private TextBox tbFIOUpdate;
    }
}