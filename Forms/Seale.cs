using Dukon_Project.classes;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Seale : Form
    {
        public Seale()
        {
            InitializeComponent();
            string GetProductPath = @"../../../AllLists\GetProductList.txt";
            string[] ProductArray = File.ReadAllLines(GetProductPath);
            List<newProduct> ProductList = new List<newProduct>();
            for (int i = 0; i < ProductArray.Length; i++)
            {
                string[] ProductListLine = ProductArray[i].Split(",");


                ProductList.Add(new newProduct()
                {
                    User1 = ProductListLine[0],
                    productId = int.Parse(ProductListLine[1]),
                    productName = ProductListLine[2],
                    productPrice = int.Parse(ProductListLine[3]),
                    productSize = int.Parse(ProductListLine[4]),
                    DateTime = DateTime.Now
                    
                });
            }
            dataGridView1.DataSource = ProductList;


            List<newProduct> products = new List<newProduct>();
            string[] ProductListMassiv = File.ReadAllLines(GetProductPath);
            foreach(var item in ProductListMassiv) 
            { 
                string[] userListLine = item.Split(",");
                products.Add(new newProduct() { User1 = userListLine[0], productId = int.Parse(userListLine[1]) ,productName = userListLine[2], productPrice = int.Parse(userListLine[3]), productSize = int.Parse(userListLine[4]), DateTime = DateTime.Parse(userListLine[5]) });
            }
            int summ = 0;
            foreach (newProduct product in products)
            {
                summ += product.productPrice * product.productSize;

            }
            summa.Text = summ.ToString();
        }

        private void btnSeale_Click(object sender, EventArgs e)
        {
            List<newProduct> ProductList = new List<newProduct>();

            string GetProductPathArxiv = @"../../../AllLists/SotuvArxivi.txt";
            string[] ProductArrayArxiv = File.ReadAllLines(GetProductPathArxiv);
            List<newProduct> ProductListArxiv = new List<newProduct>();
           foreach(string item in ProductArrayArxiv) 
            { 
                string[] ProductListLineArxiv = item.Split(',');

                ProductList.Add(new newProduct()
                {
                    User1 = ProductListLineArxiv[0],
                    productId = int.Parse(ProductListLineArxiv[1]),
                    productName = ProductListLineArxiv[2],
                    productPrice = int.Parse(ProductListLineArxiv[3]),
                    productSize = int.Parse(ProductListLineArxiv[4]),
                    DateTime = DateTime.Now
                    
                }) ;
            }
            string GetProductPath = @"../../../AllLists\GetProductList.txt";
            string[] ProductArray = File.ReadAllLines(GetProductPath);
            for (int i = 0; i < ProductArray.Length; i++)
            {
                string[] ProductListLine = ProductArray[i].Split(",");


                ProductList.Add(new newProduct()
                {
                    User1 = ProductListLine[0],
                    productId = int.Parse(ProductListLine[1]),
                    productName = ProductListLine[2],
                    productPrice = int.Parse(ProductListLine[3]),
                    productSize = int.Parse(ProductListLine[4]),
                    DateTime = DateTime.Now
                    
                });
            }
           
            string ArxivPath = @"../../../AllLists/SotuvArxivi.txt";
            StreamWriter streamWriterArxiv = File.CreateText(ArxivPath);

            foreach (newProduct product in ProductList)
            {
                streamWriterArxiv.WriteLine(product.User1 + ","+product.productId+"," +product.productName + "," + product.productPrice + "," + product.productSize + "," + product.DateTime.ToString());
            }
            streamWriterArxiv?.Close();
            StreamWriter streamWriter = File.CreateText(GetProductPath);
            streamWriter.Write("");

            streamWriter.Close();

            MessageBox.Show("Ma'hsulot sotildi");
            Thread.Sleep(1000);
            this.Hide();
            FormSealer formSealer = new FormSealer();
            formSealer.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void summa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
