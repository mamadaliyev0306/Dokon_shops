using Dukon_Project.classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dukon_Project
{
    public partial class AddProduct : Form
    {

        public AddProduct()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateForm cr = new CreateForm();
            cr.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string pathAdd = @"../../../AllLists\ProductList.txt";

            DateTime dateTime = DateTime.Now;
            if (txtProductName.Text != "" && txtProductPrice.Text != "" && txtProductSize.Text != "" && txtProductDateTime.Text != "")
            {
                List<Product> products = new List<Product>();
                string[] massiv=File.ReadAllLines(pathAdd);
                
               // int son = rastgele.Next(1000, 9999);
                foreach (var item in massiv)
                {
                    Random rastgele1 = new Random();
                    string[] massiv1 = item.Split(',');
                   
                    products.Add(new Product() {Id = rastgele1.Next(1000, 9999), ProductName= massiv1[1], ProductPrice =int.Parse( massiv1[2]), ProductSize = int.Parse(massiv1[3]), ProductDateTime = DateTime.Parse(massiv1[4]) });
                }
                Random rastgele = new Random();
                products.Add(new Product() {Id = rastgele.Next(1000, 9999), ProductName=txtProductName.Text,ProductPrice=int.Parse(txtProductPrice.Text),ProductSize=int.Parse(txtProductSize.Text),ProductDateTime=DateTime.Parse(txtProductDateTime.Text) });
                StreamWriter streamWriter1 = new StreamWriter(pathAdd);
                foreach(Product list in products)
                {
                   
                    streamWriter1.WriteLine(list.Id+","+list.ProductName+","+list.ProductPrice+","+list.ProductSize+","+list.ProductDateTime);
                }
                streamWriter1.Close();

                txtProductDateTime.Text = null;
                txtProductName.Text = null;
                txtProductPrice.Text = null;
                txtProductSize.Text = null;



            }
            else
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiriting");
            }

            List<Product> users = new List<Product>();
            string[] ProductListMassiv = File.ReadAllLines(pathAdd);

          foreach(var item in ProductListMassiv) 
            { 
                string[] userListLine = item.Split(",");
                if (userListLine[0] != "")
                    users.Add(new Product() { Id=int.Parse(userListLine[0]), ProductName = userListLine[1], ProductPrice = int.Parse(userListLine[2]), ProductSize = int.Parse(userListLine[3]), ProductDateTime = DateTime.Parse(userListLine[4]) });
            }
            StreamWriter streamWriter = File.CreateText(pathAdd);
            foreach (Product users1 in users)
            {
                streamWriter.WriteLine(users1.Id+","+users1.ProductName + "," + users1.ProductPrice + "," + users1.ProductSize + "," + users1.ProductDateTime.ToString("yyyy/MM/dd"));
            }
            streamWriter.Close();

            dataGridViewCreate.DataSource = users;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductDateTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
