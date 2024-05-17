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
    public partial class FormLastPassword : Form
    {
        public string role;
        public FormLastPassword()
        {
            InitializeComponent();

        }

        public List<Users> GetUsers()
        {
            string UserListPath1 = @"../../../AllLists\UserList.txt";
            List<Users> users1 = new List<Users>();
            string[] UserListMassiv1 = File.ReadAllLines(UserListPath1);
            for (int i = 0; i < UserListMassiv1.Length; i++)
            {
                string[] userListLine = UserListMassiv1[i].Split(",");
                users1.Add(new Users() { Role = userListLine[3], FIO = userListLine[0], UserName = userListLine[1], Password = userListLine[2] });
            }
            return users1;
        }

        private void btnTasdiqlashEskisi_Click(object sender, EventArgs e)
        {
            int sanoq = 0;
            foreach (Users users in GetUsers())
            {
                if (tbEskiUserName.Text == users.UserName && tbEskiPassword.Text == users.Password)
                {
                    sanoq++;
                    string pathUsers = @"../../../AllLists\UserList.txt";
                    List<Users> users1 = new List<Users>();
                    string[] UserListMassiv1 = File.ReadAllLines(pathUsers);
                    for (int i = 0; i < UserListMassiv1.Length; i++)
                    {
                        string[] userListLine = UserListMassiv1[i].Split(",");
                        users1.Add(new Users() { Role = userListLine[3], FIO = userListLine[0], UserName = userListLine[1], Password = userListLine[2] });
                    }
                    StreamWriter streamWriter = File.CreateText(pathUsers);
                    foreach (Users users2 in users1)
                    {
                        if (tbEskiUserName.Text == users2.UserName)
                        {
                            role = users2.Role;
                            continue;
                        }
                        streamWriter.WriteLine(users2.FIO + "," + users2.UserName + "," + users2.Password + "," + users2.Role);
                    }
                    streamWriter.Close();
                    this.Hide();
                    FormUpdateParol formUpdateParol = new FormUpdateParol(role);
                    formUpdateParol.Show();

                }
            }
            if (sanoq == 0)
            {
                MessageBox.Show("username yoki parol xato");
                tbEskiPassword.Text = "";
                tbEskiUserName.Text = "";
            }
        }

        private void FormLastPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
