using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dukon_Project
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFilter filter = new FormFilter();
            filter.Show();
        }

        private void btnTushum_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTushum formTushum1 = new FormTushum();
            formTushum1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMeneger formMeneger = new FormMeneger();
            formMeneger.Show();
        }
    }
}
