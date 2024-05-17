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
    public partial class FormMeneger : Form
    {
        public FormMeneger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateForm createForm = new CreateForm();
            createForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReport createForm = new FormReport();
            createForm.Show();
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRead formRead = new FormRead();
            formRead.Show();
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDelete formDelete = new FormDelete();
            formDelete.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
