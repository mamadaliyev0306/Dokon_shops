using Dukon_Project.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dukon_Project
{
    public partial class FormTushum : Form
    {
        public FormTushum()
        {
            InitializeComponent();
          
            string pathArxiv = @"../../../AllLists\SotuvArxivi.txt";
            string pathuser = @"../../../AllLists\UserList.txt";
            string[] massiv = File.ReadAllLines(pathArxiv);
            string[] massivUser = File.ReadAllLines(pathuser);
            List<newProduct> natijaRuyxat = new List<newProduct>();
            List<Xisobot> list = new List<Xisobot>();
            List<Users> listUser = new List<Users>();

            foreach (string line in massiv)
            {
                string[] massiv1 = line.Split(",");
                natijaRuyxat.Add(new newProduct() { User1 = massiv1[0], productId = int.Parse(massiv1[1]), productName = massiv1[2], productPrice = int.Parse(massiv1[3]), productSize = int.Parse(massiv1[4]), DateTime = DateTime.Parse(massiv1[5].Substring(0, 10)) });
            }

            foreach (string line1 in massivUser)
            {
                string[] massiv2 = line1.Split(',');
                listUser.Add(new Users() { FIO = massiv2[0], UserName = massiv2[1], Password = massiv2[2], Role = massiv2[3] });
            }

            foreach (Users item in listUser)
            {
                int summa1 = 0;
                foreach (newProduct item1 in natijaRuyxat)
                {
                    if (item1.User1 == item.UserName && item.Role == Role.Sealer.ToString())
                    {
                        summa1 += item1.productSize * item1.productPrice;
                    }
                }
                list.Add(new Xisobot() { userName = item.UserName, summa = summa1 });
            }

            dataGridView1.DataSource = list;
        }

        private void tbUserIsmi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnterTushum_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Today;
            string pathArxiv = @"../../../AllLists\SotuvArxivi.txt";
            string pathuser = @"../../../AllLists\UserList.txt";
            string[] massiv = File.ReadAllLines(pathArxiv);
            string[] massivUser = File.ReadAllLines(pathuser);
            List<newProduct> natijaRuyxat = new List<newProduct>();
            List<Xisobot> list = new List<Xisobot>();
            List<string> listUser = new List<string>();
            foreach (string line in massiv)
            {
                string[] massiv1 = line.Split(",");
                natijaRuyxat.Add(new newProduct() { User1 = massiv1[0],productId= int.Parse(massiv1[1]) ,productName = massiv1[2], productPrice = int.Parse(massiv1[3]), productSize = int.Parse(massiv1[4]), DateTime = DateTime.Parse(massiv1[5].Substring(0, 10)) });
            }
            foreach (string user in massivUser)
            {
                string[] massiv2 = user.Split(",");
                listUser.Add(massiv2[1]);
            }
            int summa1 = 0;
            int sanoq1 = 0;
            foreach (newProduct sanа in natijaRuyxat)
            {
                if (sanа.DateTime == time)
                {
                    foreach (string item in listUser)
                    {
                        foreach (newProduct sanoq in natijaRuyxat)
                        {
                            if (item == sanа.User1)
                            {
                                summa1 += sanoq.productSize * sanoq.productPrice;
                            }
                        }
                        if (item == sanа.User1 && sanoq1 == 0)
                        {
                            sanoq1++;
                            list.Add(new Xisobot() { userName = sanа.User1, summa = summa1 });
                        }
                    }
                }
            }
            int jami = 0;
            tbSana.Text = DateTime.Now.ToString();
            foreach (Xisobot xisobot in list)
            {
                jami += xisobot.summa;
            }
            tbsumm.Text = jami.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTushum_Load(object sender, EventArgs e)
        {

        }

        private void BtnNazat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReport formReport = new FormReport();
            formReport.Show();
        }

        private void tbSana_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
