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
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menyuToolStripMenuItem = new ToolStripMenuItem();
            xisobotlarToolStripMenuItem = new ToolStripMenuItem();
            mahsulotlarRoyhatiToolStripMenuItem = new ToolStripMenuItem();
            mahsulotQoshishToolStripMenuItem = new ToolStripMenuItem();
            mahsulotTaxrilashToolStripMenuItem = new ToolStripMenuItem();
            mahsulotlarJadvaliToolStripMenuItem = new ToolStripMenuItem();
            mahsulotOchirishToolStripMenuItem = new ToolStripMenuItem();
            sotuvchiQoshishToolStripMenuItem = new ToolStripMenuItem();
            chiqishToolStripMenuItem = new ToolStripMenuItem();
            logingaQaytishToolStripMenuItem = new ToolStripMenuItem();
            dasturniYopishToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menyuToolStripMenuItem, chiqishToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(993, 40);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // menyuToolStripMenuItem
            // 
            menyuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xisobotlarToolStripMenuItem, mahsulotlarRoyhatiToolStripMenuItem, sotuvchiQoshishToolStripMenuItem });
            menyuToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menyuToolStripMenuItem.Name = "menyuToolStripMenuItem";
            menyuToolStripMenuItem.Size = new Size(109, 36);
            menyuToolStripMenuItem.Text = "Menyu";
            // 
            // xisobotlarToolStripMenuItem
            // 
            xisobotlarToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xisobotlarToolStripMenuItem.Name = "xisobotlarToolStripMenuItem";
            xisobotlarToolStripMenuItem.Size = new Size(364, 34);
            xisobotlarToolStripMenuItem.Text = "Xisobotlar";
            // 
            // mahsulotlarRoyhatiToolStripMenuItem
            // 
            mahsulotlarRoyhatiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mahsulotQoshishToolStripMenuItem, mahsulotTaxrilashToolStripMenuItem, mahsulotlarJadvaliToolStripMenuItem, mahsulotOchirishToolStripMenuItem });
            mahsulotlarRoyhatiToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mahsulotlarRoyhatiToolStripMenuItem.Name = "mahsulotlarRoyhatiToolStripMenuItem";
            mahsulotlarRoyhatiToolStripMenuItem.Size = new Size(364, 34);
            mahsulotlarRoyhatiToolStripMenuItem.Text = "Mahsulotlar bo'limi";
            mahsulotlarRoyhatiToolStripMenuItem.Click += mahsulotlarRoyhatiToolStripMenuItem_Click;
            // 
            // mahsulotQoshishToolStripMenuItem
            // 
            mahsulotQoshishToolStripMenuItem.Name = "mahsulotQoshishToolStripMenuItem";
            mahsulotQoshishToolStripMenuItem.Size = new Size(277, 34);
            mahsulotQoshishToolStripMenuItem.Text = "Mahsulot qo'shish";
            mahsulotQoshishToolStripMenuItem.Click += mahsulotQoshishToolStripMenuItem_Click;
            // 
            // mahsulotTaxrilashToolStripMenuItem
            // 
            mahsulotTaxrilashToolStripMenuItem.Name = "mahsulotTaxrilashToolStripMenuItem";
            mahsulotTaxrilashToolStripMenuItem.Size = new Size(277, 34);
            mahsulotTaxrilashToolStripMenuItem.Text = "Mahsulot taxrilash";
            mahsulotTaxrilashToolStripMenuItem.Click += mahsulotTaxrilashToolStripMenuItem_Click;
            // 
            // mahsulotlarJadvaliToolStripMenuItem
            // 
            mahsulotlarJadvaliToolStripMenuItem.Name = "mahsulotlarJadvaliToolStripMenuItem";
            mahsulotlarJadvaliToolStripMenuItem.Size = new Size(277, 34);
            mahsulotlarJadvaliToolStripMenuItem.Text = "Mahsulotlar jadvali";
            mahsulotlarJadvaliToolStripMenuItem.Click += mahsulotlarJadvaliToolStripMenuItem_Click;
            // 
            // mahsulotOchirishToolStripMenuItem
            // 
            mahsulotOchirishToolStripMenuItem.Name = "mahsulotOchirishToolStripMenuItem";
            mahsulotOchirishToolStripMenuItem.Size = new Size(277, 34);
            mahsulotOchirishToolStripMenuItem.Text = "Mahsulot ochirish";
            mahsulotOchirishToolStripMenuItem.Click += mahsulotOchirishToolStripMenuItem_Click;
            // 
            // sotuvchiQoshishToolStripMenuItem
            // 
            sotuvchiQoshishToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sotuvchiQoshishToolStripMenuItem.Name = "sotuvchiQoshishToolStripMenuItem";
            sotuvchiQoshishToolStripMenuItem.Size = new Size(364, 34);
            sotuvchiQoshishToolStripMenuItem.Text = "Sotuvchi qo'shish va o'chirish";
            sotuvchiQoshishToolStripMenuItem.Click += sotuvchiQoshishToolStripMenuItem_Click;
            // 
            // chiqishToolStripMenuItem
            // 
            chiqishToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logingaQaytishToolStripMenuItem, dasturniYopishToolStripMenuItem });
            chiqishToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chiqishToolStripMenuItem.Name = "chiqishToolStripMenuItem";
            chiqishToolStripMenuItem.Size = new Size(113, 36);
            chiqishToolStripMenuItem.Text = "Chiqish";
            // 
            // logingaQaytishToolStripMenuItem
            // 
            logingaQaytishToolStripMenuItem.Name = "logingaQaytishToolStripMenuItem";
            logingaQaytishToolStripMenuItem.Size = new Size(299, 40);
            logingaQaytishToolStripMenuItem.Text = "Loginga qaytish";
            logingaQaytishToolStripMenuItem.Click += logingaQaytishToolStripMenuItem_Click;
            // 
            // dasturniYopishToolStripMenuItem
            // 
            dasturniYopishToolStripMenuItem.Name = "dasturniYopishToolStripMenuItem";
            dasturniYopishToolStripMenuItem.Size = new Size(299, 40);
            dasturniYopishToolStripMenuItem.Text = "Dasturni yopish";
            dasturniYopishToolStripMenuItem.Click += dasturniYopishToolStripMenuItem_Click;
            // 
            // FormMeneger
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(993, 632);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FormMeneger";
            Text = "FormMeneger";
            Load += FormMeneger_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView GetProduct;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menyuToolStripMenuItem;
        private ToolStripMenuItem mahsulotlarRoyhatiToolStripMenuItem;
        private ToolStripMenuItem xisobotlarToolStripMenuItem;
        private ToolStripMenuItem sotuvchiQoshishToolStripMenuItem;
        private ToolStripMenuItem chiqishToolStripMenuItem;
        private ToolStripMenuItem logingaQaytishToolStripMenuItem;
        private ToolStripMenuItem dasturniYopishToolStripMenuItem;
        private ToolStripMenuItem mahsulotQoshishToolStripMenuItem;
        private ToolStripMenuItem mahsulotTaxrilashToolStripMenuItem;
        private ToolStripMenuItem mahsulotlarJadvaliToolStripMenuItem;
        private ToolStripMenuItem mahsulotOchirishToolStripMenuItem;
    }
}