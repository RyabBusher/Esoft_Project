using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormAuthorization : Form
    {
        public static User users = new User();

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach(Users user in Program.eSoftDB.Users)
                {
                    if(textBoxLogin.Text==user.Login&&textBoxPassword.Text==user.Password)
                    {
                        key = true;
                        users.login = user.Login;
                        users.password = user.Password;
                        users.type = user.Type;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }
        }
    }
}
