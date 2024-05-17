using Dukon_Project.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dukon_Project
{
    public partial class UpdateProduct : Form
    {
        FormSealer sealer = new FormSealer();

        public UpdateProduct()
        {
            InitializeComponent();
            FormSealer formSealer = new FormSealer();
            List<Product> products1 = new List<Product>();
            products1 = formSealer.GetProducts();
            dataGridView1.DataSource = products1;
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMeneger formMeneger = new FormMeneger();
            formMeneger.Show(); this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string pathAdd = @"../../../AllLists\ProductList.txt";

            List<Product> users = new List<Product>();
            string[] ProductListMassiv = File.ReadAllLines(pathAdd);

            foreach (var item in ProductListMassiv)
            {
                string[] userListLine = item.Split(",");
                if (userListLine[0] != "")
                    users.Add(new Product() { Id = int.Parse(userListLine[0]), ProductName = userListLine[1], ProductPrice = int.Parse(userListLine[2]), ProductSize = int.Parse(userListLine[3]), ProductDateTime = DateTime.Parse(userListLine[4]) });
            }
            List<Product> products = new List<Product>();
            foreach (Product item in users)
            {
                if (item.ProductName.Contains(textBoxProductName.Text))
                {
                    products.Add(new Product() { Id = item.Id, ProductName = item.ProductName, ProductPrice = item.ProductPrice, ProductSize = item.ProductSize, ProductDateTime = item.ProductDateTime });
                }
            }
            dataGridView1.DataSource = products;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = @"../../../AllLists\ProductList.txt";
            List<Product> products = new List<Product>();
            if (tbProductID.Text!="" && tbProductID.Text.Length > 3 && tbProductID.Text.Length < 5 && textBoxNewName.Text != "" && textBoxNewPrice.Text != "" && textBoxNewDateTime.Text != "")
            {


                try
                {
                    foreach (Product item in sealer.GetProducts())
                    {

                        if (int.Parse(tbProductID.Text) == item.Id)
                        {
                            item.ProductName = textBoxNewName.Text;
                            item.ProductPrice = int.Parse(textBoxNewPrice.Text);
                            item.ProductSize = int.Parse(textBoxNewMiqdor.Text);
                            item.ProductDateTime = DateTime.Parse(textBoxNewDateTime.Text);
                        }

                        products.Add(new Product() { Id = item.Id, ProductName = item.ProductName, ProductPrice = item.ProductPrice, ProductSize = item.ProductSize, ProductDateTime = item.ProductDateTime });
                    }
                    StreamWriter streamWriter = new StreamWriter(path);
                    foreach (Product item in products)
                    {
                        streamWriter.WriteLine(item.Id + "," + item.ProductName + "," + item.ProductPrice + "," + item.ProductSize + "," + item.ProductDateTime);
                    }
                    streamWriter.Close();

                    MessageBox.Show("maxsulot taxrirlandi !!!");
                    dataGridView1.DataSource = sealer.GetProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Xatolik bor?");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathAdd = @"../../../AllLists\ProductList.txt";

            List<Product> users = new List<Product>();
            string[] ProductListMassiv = File.ReadAllLines(pathAdd);

            foreach (var item in ProductListMassiv)
            {
                string[] userListLine = item.Split(",");
                if (userListLine[0] != "")
                    users.Add(new Product() { Id = int.Parse(userListLine[0]), ProductName = userListLine[1], ProductPrice = int.Parse(userListLine[2]), ProductSize = int.Parse(userListLine[3]), ProductDateTime = DateTime.Parse(userListLine[4]) });
            }
            if(tbProductID.Text!="" && tbProductID.Text.Length>3 && tbProductID.Text.Length < 5)
            {
             try
             {
                foreach (Product item in users)
                {
                    if (item.Id.ToString().Contains(tbProductID.Text))
                    {
                        textBoxNewName.Text = item.ProductName;
                        textBoxNewPrice.Text = item.ProductPrice.ToString();
                        textBoxNewMiqdor.Text = item.ProductSize.ToString();
                        textBoxNewDateTime.Text = item.ProductDateTime.ToString();
                    }

                }

             }
              catch(Exception ex)
              {
                MessageBox.Show("Id xato ?");
              }

            }
            else if (tbProductID.Text == "")
            {
                textBoxNewName.Text = "";
                textBoxNewPrice.Text = "";
                textBoxNewMiqdor.Text = "";
                textBoxNewDateTime.Text = "";
            }else
            {
                MessageBox.Show("Id xatolik bor?");
            }
        }
    }
}
