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
    public partial class FormUpdateParol : Form
    {
        public FormUpdateParol()
        {
            InitializeComponent();
        }
        public string role;
        public FormUpdateParol(string aaa)
        {
            InitializeComponent();
            role= aaa;
        }
        private void btnUpdateEnter_Click(object sender, EventArgs e)
        {
            string pathUsers = @"../../../AllLists/UserList.txt";
            List<Users> users1 = new List<Users>();
            string[] UserListMassiv1 = File.ReadAllLines(pathUsers);
            for (int i = 0; i < UserListMassiv1.Length; i++)
            {
                string[] userListLine = UserListMassiv1[i].Split(",");
                users1.Add(new Users() { Role = userListLine[3], FIO = userListLine[0], UserName = userListLine[1], Password = userListLine[2] });
            }


            int sanoq = 0;
            foreach (Users users2 in users1)
            {

                if (tbFIOUpdate.Text != "" && tbUsernameUpdate.Text != "" && tbParolUpdate.Text != "" )
                {
                    if (tbUsernameUpdate.Text != users2.UserName)
                    {

                        sanoq++;
                    }

                }
            }
            if (tbFIOUpdate.Text != "" && tbUsernameUpdate.Text != "" && tbParolUpdate.Text != "")
            {
                if (UserListMassiv1.Length == sanoq)
                {
                    StreamWriter streamWriter = File.CreateText(pathUsers);

                    foreach (Users item in users1)
                    {
                        streamWriter.WriteLine(item.FIO + "," + item.UserName + "," + item.Password + "," + item.Role);
                    }

                    streamWriter.WriteLine(tbFIOUpdate.Text + "," + tbUsernameUpdate.Text + "," + tbParolUpdate.Text + "," + role);
                    streamWriter.Close();
                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();

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

        private void tbUsernameUpdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
