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

namespace Dukon_Project
{
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
            GetRead();


        }

        public void GetRead()
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
            StreamWriter streamWriter = File.CreateText(pathAdd);
            foreach (Product users1 in users)
            {

                streamWriter.WriteLine(users1.Id + "," + users1.ProductName + "," + users1.ProductPrice + "," + users1.ProductSize + "," + users1.ProductDateTime.ToString("yyyy/MM/dd"));

            }
            streamWriter.Close();

            dataGridViewDelete.DataSource = users;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridViewDelete.CanSelect)
            {
                try
                {
                    int productId = Convert.ToInt32(dataGridViewDelete.SelectedRows[0].Cells[0].Value.ToString());

                    DialogResult result = MessageBox.Show($"Do you want to delete the product with ID {productId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        string[] lines = File.ReadAllLines(@"../../../AllLists\ProductList.txt");

                        var updatedLines = new List<string>();
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length >= 5 && parts[0] == productId.ToString())
                            {

                                continue;
                            }
                            updatedLines.Add(line);
                        }


                        File.WriteAllLines(@"../../../AllLists\ProductList.txt", updatedLines);


                        GetRead();

                        MessageBox.Show("Product deleted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select the product to be deleted!");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMeneger formMeneger = new FormMeneger();
            formMeneger.Show();
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
            List<Product> products = new List<Product>();
            foreach (Product item in users)
            {
                if (item.ProductName.Contains(txbSeach.Text))
                {
                    products.Add(new Product() { Id = item.Id, ProductName = item.ProductName, ProductPrice = item.ProductPrice, ProductSize = item.ProductSize, ProductDateTime = item.ProductDateTime });
                }
            }
            dataGridViewDelete.DataSource = products;
        }
    }
}
