using Dukon_Project.classes;
using System;
using System.Collections;
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
    public partial class FormFilter : Form
    {
        public FormFilter()
        {
            InitializeComponent();
            // dataGridView1.DataSource = Filterlash(DateTime.Parse(tbLastDate.Text), DateTime.Parse(tbNextDate.Text));
        }

        private void tbLastDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchFilter_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Filterlash(DateTime.Parse(tbLastDate.Text), DateTime.Parse(tbNextDate.Text));


        }
        public List<newProduct> Filterlash(DateTime boshlangichSana, DateTime tugashSana)
        {
            string pathArxiv = @"../../../AllLists\SotuvArxivi.txt";
            string[] massiv = File.ReadAllLines(pathArxiv);
            List<newProduct> natijaRuyxat = new List<newProduct>();
            List<newProduct> list = new List<newProduct>();

            foreach (string line in massiv)
            {
                string[] massiv1 = line.Split(',');
                list.Add(new newProduct() { User1 = massiv1[0],productId= int.Parse(massiv1[1]), productName = massiv1[2], productPrice = int.Parse(massiv1[3]), productSize = int.Parse(massiv1[4]), DateTime = DateTime.Parse(massiv1[5].Substring(0, 10)) });
            }
            foreach (newProduct sanа in list)
            {
                if (sanа.DateTime >= boshlangichSana && sanа.DateTime <= tugashSana)
                {
                    natijaRuyxat.Add(new newProduct() { User1 = sanа.User1,productId = sanа.productId ,productName = sanа.productName, productPrice = sanа.productPrice, productSize = sanа.productSize, DateTime = sanа.DateTime });
                }
            }
            return natijaRuyxat;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormFilter_Load(object sender, EventArgs e)
        {

        }

        private void BtnBackReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReport formReport = new FormReport();
            formReport.Show();
        }
    }
}
