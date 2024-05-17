using Dukon_Project.classes;
using Microsoft.VisualBasic.ApplicationServices;

namespace Dukon_Project
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

       
       
        private void btnTasdiqlash_Click(object sender, EventArgs e)
        {

            string UserListPath = @"../../../AllLists\UserList.txt";
            List<Users> users = new List<Users>();
            string[] UserListMassiv = File.ReadAllLines(UserListPath);
            for (int i = 0; i < UserListMassiv.Length; i++)
            {
                string[] userListLine = UserListMassiv[i].Split(",");
                users.Add(new Users() { Role = userListLine[3], FIO = userListLine[0], UserName = userListLine[1], Password = userListLine[2] });
            }
            if (tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                int sanoq = 0;
                foreach (Users user in users)
                {
                    if (tbUserName.Text == user.UserName && tbPassword.Text == user.Password)
                    {
                        if (user.Role == Role.Sealer.ToString())
                        {
                            sanoq++;
                            
                            FormSealer formSealer = new FormSealer(tbUserName.Text);
                            formSealer.Show(); this.Hide();
                        }
                        if (user.Role == Role.Meneger.ToString())
                        {
                            sanoq++;
                            this.Hide();
                            FormMeneger formMeneger = new FormMeneger();
                            formMeneger.Show();

                        }
                    }

                }
                if (sanoq == 0)
                {


                    MessageBox.Show("bunday foydalanuvchi mavjud emas");
                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();

                }
            }
            else
            {
                MessageBox.Show("username yoki parol bo'sh qoldirildi");
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateParol_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLastPassword formLastPassword = new FormLastPassword();
            formLastPassword.Show();


        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
