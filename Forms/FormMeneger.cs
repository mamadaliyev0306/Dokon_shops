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

        private void mahsulotlarRoyhatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRead formRead = new FormRead();
            formRead.Show();
        }

        private void sotuvchiQoshishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPerson addPerson = new AddPerson();
            addPerson.Show();
        }

        private void mahsulotQoshishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void mahsulotTaxrilashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.Show();
        }

        private void mahsulotlarJadvaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            FormRead formRead1 = new FormRead();
            formRead1.Show();
        }

        private void logingaQaytishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void dasturniYopishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mahsulotOchirishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDelete formDelete = new FormDelete();
            formDelete.Show();
        }

        private void FormMeneger_Load(object sender, EventArgs e)
        {

        }
    }
}
