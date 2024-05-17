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
    public partial class AddPerson : Form
    {
        public AddPerson()
        {

            InitializeComponent();
            GetRead();
            cmbRole.Items.Add(Roles.Meneger);
            cmbRole.Items.Add(Roles.Sealer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateForm createForm = new CreateForm();
            createForm.Show();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public enum Roles
        {
            Sealer,
            Meneger
        }
        public void GetRead()
        {
            string pathAdd = @"../../../AllLists\UserList.txt";
            List<Users> users = new List<Users>();
            string[] ProductListMassiv = File.ReadAllLines(pathAdd);

            for (int i = 0; i < ProductListMassiv.Length; i++)
            {
                string[] userListLine = ProductListMassiv[i].Split(",");
                if (userListLine[0] != "")
                    users.Add(new Users() { FIO = userListLine[0], UserName = userListLine[1], Password = userListLine[2], Role = userListLine[3] });
            }
            StreamWriter streamWriter = File.CreateText(pathAdd);
            foreach (Users users1 in users)
            {
                streamWriter.WriteLine(users1.FIO + "," + users1.UserName + "," + users1.Password + "," + users1.Role);
            }
            streamWriter.Close();

            dataGridViewRole.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathAdd = @"../../../AllLists\UserList.txt";
            List<Users> users = new List<Users>();
            string[] ProductListMassiv = File.ReadAllLines(pathAdd);

            for (int i = 0; i < ProductListMassiv.Length; i++)
            {
                string[] userListLine = ProductListMassiv[i].Split(",");
                if (userListLine[0] != "")
                    users.Add(new Users() { FIO = userListLine[0], UserName = userListLine[1], Password = userListLine[2], Role = userListLine[3] });
            }
            int sanoq = 0;
            foreach (Users users2 in users)
            {

                if (txbFIO.Text != "" && txbUserName.Text != "" && txbPassword.Text != "" && cmbRole.Text != "")
                {
                    if (txbUserName.Text != users2.UserName)
                    {

                        sanoq++;
                    }

                }
            }
            if (txbFIO.Text != "" && txbUserName.Text != "" && txbPassword.Text != "" && cmbRole.Text != "")
            {
                if (ProductListMassiv.Length == sanoq)
                {
                    File.AppendAllText(pathAdd,
                        txbFIO.Text
                        + "," + txbUserName.Text
                        + "," + txbPassword.Text
                        + "," + cmbRole.Text
                        + "\n"
                        );
                    txbFIO.Text = null; txbUserName.Text = null; txbPassword.Text = null; cmbRole.Text = null;
                    GetRead();
                }
                else
                {
                    MessageBox.Show("Bu UserName ishlatilmoqda iltimos boshqa kiriting");


                }
            }
            else
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiriting");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string pathDelete = @"../../../AllLists\UserList.txt";
            if (dataGridViewRole.CanSelect)
            {
                try
                {
                    string? personUserName = dataGridViewRole.SelectedRows[0].Cells[0].Value.ToString();

                    DialogResult result = MessageBox.Show($"O'chirmoqchi bolsangiz Yes ni bosing {personUserName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        string[] lines = File.ReadAllLines(pathDelete);

                        var updatedLines = new List<string>();
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length >= 4 && parts[0] == personUserName)
                            {

                                continue;
                            }
                            updatedLines.Add(line);
                        }


                        File.WriteAllLines(pathDelete, updatedLines);


                        GetRead();

                        MessageBox.Show("muvaffaqiyatli o'chirildi");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string path = @"../../../AllLists\UserList.txt";
            List<Users> users = new List<Users>();
            string[] ProductListMassiv = File.ReadAllLines(path);

            for (int i = 0; i < ProductListMassiv.Length; i++)
            {
                string[] userListLine = ProductListMassiv[i].Split(",");
                if (userListLine[0] != "")
                    users.Add(new Users() { FIO = userListLine[0], UserName = userListLine[1], Password = userListLine[2], Role = userListLine[3] });
            }
            List<Users> products = new List<Users>();
            foreach (Users item in users)
            {
                if (item.UserName.Contains(tbSearch.Text))
                {
                    products.Add(new Users() { FIO=item.FIO, UserName = item.UserName, Password = item.Password, Role = item.Role });
                }
            }
            dataGridViewRole.DataSource = products;
        }
    }
}
