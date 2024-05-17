﻿using Dukon_Project.classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dukon_Project
{


    public partial class FormSealer : Form
    {
        public List<Product> productsList { get; set; }
        public List<newProduct> UpdateProducts = new List<newProduct>();

        public FormSealer()
        {
            InitializeComponent();
            productsList = GetProducts();



            dataGridViewProductTable.DataSource = productsList;

        }
        public string name { get; set; }
        public FormSealer(string nom)
        {
            InitializeComponent();
            name = nom;
            productsList = GetProducts();


            dataGridViewProductTable.DataSource = productsList;
        }


        /// Maxsulotlar Ro'yhatini txt fayldan Listag yuklab, Listni qaytaramiz.        
        public List<Product> GetProducts()
        {
            string PathProductList = @"../../../AllLists\ProductList.txt";
            string[] ProductArray = File.ReadAllLines(PathProductList);
            List<Product> ProductList = new List<Product>();
            foreach (string Product in ProductArray)
            {
                string[] ProductListLine = Product.Split(",");

                DateTime date = DateTime.Parse(ProductListLine[4]);
                DateTime date1 = DateTime.Now;
                DateTime date2 = new DateTime(2015, 10, 10);
                var date3 = new DateTime(2016, 10, 10);
                TimeSpan farq1yil = date3.Subtract(date2);
                TimeSpan farq = date1.Subtract(date);
                if (farq < farq1yil && int.Parse(ProductListLine[3]) > 0)
                {
                    ProductList.Add(new Product()
                    {
                        Id = int.Parse(ProductListLine[0]),
                        ProductName = ProductListLine[1],
                        ProductPrice = int.Parse(ProductListLine[2]),
                        ProductSize = (int.Parse(ProductListLine[3])),
                        ProductDateTime = DateTime.Parse(ProductListLine[4]),
                    });
                }
                StreamWriter streamWriter = File.CreateText(PathProductList);
                foreach (Product item in ProductList)
                {

                    streamWriter.WriteLine(item.Id + "," + item.ProductName + "," + item.ProductPrice + "," + item.ProductSize + "," + item.ProductDateTime);
                }
                streamWriter.Close();


            }
            return ProductList;
        }


        public List<Product> GetProductsCOPY()
        {
            string PathProductList = @"../../../AllLists\ProductList.txt";
            string[] ProductArray = File.ReadAllLines(PathProductList);
            List<Product> ProductList = new List<Product>();
            for (int i = 0; i < ProductArray.Length; i++)
            {
                string[] ProductListLine = ProductArray[i].Split(",");

                if (true)
                {
                    ProductList.Add(new Product()
                    {
                        Id = int.Parse(ProductListLine[0]),
                        ProductName = ProductListLine[1],
                        ProductPrice = int.Parse(ProductListLine[2]),
                        ProductSize = int.Parse(ProductListLine[3]),
                        ProductDateTime = DateTime.Parse(ProductListLine[4]),
                    });
                }
                else
                {
                    // Delete funksiyasi chaqiriladi va yaroqsiz maxsulotlar o'chiriladi

                }

            }
            return ProductList;
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // DGV Jadvali

        }

        private void lbGoBack_Click(object sender, EventArgs e)
        {

        }
        public int mqdor { get; set; }
        public int gtId { get; set; }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

            if (tbGetProduct.Text == "" || tbMiqdor.Text == "")
            {

                MessageBox.Show("maydonni bo'sh qoldirdingiz");

            }
            else
            {
                try
                {
                    int sanoq = 0;
                    foreach (Product product1 in GetProducts())
                    {
                        if (product1.Id == int.Parse(tbGetProduct.Text))
                        {
                            sanoq++;
                            string GetProductPath = @"../../../AllLists\GetProductList.txt";
                            List<newProduct> users = new List<newProduct>();
                            string[] ProductListMassiv = File.ReadAllLines(GetProductPath);

                            foreach (string item in ProductListMassiv)
                            {
                                string[]? userListLine = item.Split(',');
                                users.Add(new newProduct() { User1 = userListLine[0], productId = int.Parse(userListLine[1]), productName = userListLine[2], productPrice = int.Parse(userListLine[3]), productSize = int.Parse(userListLine[4]), DateTime = DateTime.Parse(userListLine[5]) });
                            }
                            foreach (Product product in GetProducts())
                            {
                                if (int.Parse(tbGetProduct.Text) == product.Id && product.ProductSize > int.Parse(tbMiqdor.Text))
                                {
                                    users.Add(new newProduct() { User1 = name, productId = product.Id, productName = product.ProductName, productPrice = product.ProductPrice, productSize = int.Parse(tbMiqdor.Text), DateTime = product.ProductDateTime });
                                }
                            }
                            StreamWriter streamWriter = File.CreateText(GetProductPath);
                            foreach (newProduct users1 in users)
                            {
                                streamWriter.WriteLine(users1.User1 + "," + users1.productId + "," + users1.productName + "," + users1.productPrice + "," + users1.productSize + "," + users1.DateTime);
                            }
                            streamWriter.Close();
                            ////Sotilmoqchi bo'lgan maqsulot
                            string UpdatePath = @"../../../AllLists\ProductList.txt";
                            string[] line = File.ReadAllLines(UpdatePath);
                            List<Product> list = new List<Product>();
                            foreach (string item in line)
                            {
                                string[] line1 = item.Split(",");
                                list.Add(new Product() { Id = int.Parse(line1[0]), ProductName = line1[1], ProductPrice = int.Parse(line1[2]), ProductSize = int.Parse(line1[3]), ProductDateTime = DateTime.Parse(line1[4]) });
                            }
                            try
                            {
                                foreach (Product product in list)
                                {
                                    foreach (newProduct item in users)
                                    {
                                        if (product.Id == int.Parse(tbGetProduct.Text) && product.ProductPrice == item.productPrice)
                                        {
                                            product.ProductSize = product.ProductSize - item.productSize;
                                            mqdor = item.productSize;
                                            gtId = item.productId;
                                            break;

                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Id xatolik bor?");
                            }
                            StreamWriter streamWriter2 = new StreamWriter(UpdatePath);
                            foreach (Product product in list)
                            {
                                streamWriter2.WriteLine(product.Id + "," + product.ProductName + "," + product.ProductPrice + "," + product.ProductSize + "," + product.ProductDateTime);
                            }
                            streamWriter2.Close();
                            dataGridView2.DataSource = users;
                            dataGridViewProductTable.DataSource = list;


                            //dataGridViewProductTable.DataSource = product1;
                            ////
                            tbMiqdor.Text = null;
                            tbGetProduct.Text = null;
                            break;

                        }

                    }
                }
                catch (Exception exx)
                {
                    MessageBox.Show("bunday maxsulot mavjud emas");
                }

                tbMiqdor.Text = null;
                tbGetProduct.Text = null;

            }



        }

        private void btnBekorQ_Click(object sender, EventArgs e)
        {
            string GetProductPath = @"../../../AllLists\GetProductList.txt";
            List<newProduct> users = new List<newProduct>();
            string[] ProductListMassiv = File.ReadAllLines(GetProductPath);
            List<Product> products = new List<Product>();

            foreach (string item in ProductListMassiv)
            {
                string[]? userListLine = item.Split(',');
                users.Add(new newProduct() { User1 = userListLine[0], productId = int.Parse(userListLine[1]), productName = userListLine[2], productPrice = int.Parse(userListLine[3]), productSize = int.Parse(userListLine[4]), DateTime = DateTime.Parse(userListLine[5]) });
            }
            string UpdatePath = @"../../../AllLists\ProductList.txt";
            string[] line = File.ReadAllLines(UpdatePath);

            List<Product> list = new List<Product>();
            foreach (string item in line)
            {
                string[] line1 = item.Split(",");
                list.Add(new Product() { Id = int.Parse(line1[0]), ProductName = line1[1], ProductPrice = int.Parse(line1[2]), ProductSize = int.Parse(line1[3]), ProductDateTime = DateTime.Parse(line1[4]) });
            }
            if (!string.IsNullOrEmpty(GetProductPath))
            {
                try
                {
                    foreach (Product item in list)
                    {
                        foreach (newProduct product in users)
                        {
                            if (product.productId == item.Id)
                            {
                                item.ProductSize = item.ProductSize + product.productSize;
                            }
                        }
                        products.Add(new Product() { Id = item.Id, ProductName = item.ProductName, ProductPrice = item.ProductPrice, ProductSize = item.ProductSize, ProductDateTime = item.ProductDateTime });
                    }
                    StreamWriter streamWriterB = new StreamWriter(UpdatePath);
                    foreach (Product item in products)
                    {
                        streamWriterB.WriteLine(item.Id + "," + item.ProductName + "," + item.ProductPrice + "," + item.ProductSize + "," + item.ProductDateTime);
                    }
                    streamWriterB.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xatolik bor");
                }

            }

            StreamWriter streamWriter = File.CreateText(GetProductPath);
            streamWriter.Write("");
            streamWriter.Close();
            dataGridView2.DataSource = users.Clear;
            dataGridViewProductTable.DataSource = products;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {


            this.Hide();
            Seale seale = new Seale();
            seale.Show();


        }

        private void tbMiqdor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {

            string UpdatePath = @"../../../AllLists\GetProductList.txt";
            List<newProduct> UpdateProducts1 = new List<newProduct>();
            string[] massiv = File.ReadAllLines(UpdatePath);
            foreach (string mass in massiv)
            {
                string[] massivList = mass.Split(',');
                if (massivList[1] == tbId.Text)
                    continue;
                UpdateProducts1.Add(new newProduct() { User1 = massivList[0], productId = int.Parse(massivList[1]), productName = massivList[2], productPrice = int.Parse(massivList[3]), productSize = int.Parse(massivList[4]), DateTime = DateTime.Parse(massivList[5]) });

            }

            string UpdatePat = @"../../../AllLists\ProductList.txt";
            string[] line = File.ReadAllLines(UpdatePat);
            List<newProduct> products = new List<newProduct>();
            List<Product> list = new List<Product>();
            foreach (string item in line)
            {
                string[] line1 = item.Split(",");
                list.Add(new Product() { Id = int.Parse(line1[0]), ProductName = line1[1], ProductPrice = int.Parse(line1[2]), ProductSize = int.Parse(line1[3]), ProductDateTime = DateTime.Parse(line1[4]) });
            }

            foreach (Product product in list)
            {

                if (product.Id == gtId)
                {
                    product.ProductSize = product.ProductSize + mqdor;

                }


            }
            StreamWriter streamWriter2 = new StreamWriter(UpdatePath);
            foreach (Product product in list)
            {
                streamWriter2.WriteLine(product.Id + "," + product.ProductName + "," + product.ProductPrice + "," + product.ProductSize + "," + product.ProductDateTime);
            }
            streamWriter2.Close();
            StreamWriter streamWriter = File.CreateText(UpdatePath);
            foreach (newProduct product in UpdateProducts1)
            {
                streamWriter.WriteLine(product.User1 + "," + product.productId + "," + product.productName + "," + product.productPrice + "," + product.productSize + "," + product.DateTime);
            }
            streamWriter.Close();
            dataGridView2.DataSource = UpdateProducts1;
            dataGridViewProductTable.DataSource = list;


        }

        private void tbUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearchNew_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            foreach (Product item in GetProducts())
            {
                if (item.ProductName.Contains(tbNewSearch.Text))
                {
                    products.Add(new Product() { Id = item.Id, ProductName = item.ProductName, ProductPrice = item.ProductPrice, ProductSize = item.ProductSize, ProductDateTime = item.ProductDateTime });
                }
            }
            dataGridViewProductTable.DataSource = products;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
