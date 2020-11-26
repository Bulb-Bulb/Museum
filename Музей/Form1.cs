using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Музей
{
    public partial class NameAutoriz : Form
    {
        public NameAutoriz()
        {
            InitializeComponent();
        }

        private void NameAutoriz_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public struct Users_Authoriz
        {
            public string login;
            public string password;
            public string type;
        }
        public static Users_Authoriz users = new Users_Authoriz();
        private void buttonOK_Click1(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Users_Authoriz user in Program.Museum.Users_Authoriz)

                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.login = user.Login;
                        users.password = user.Password;
                        users.type = user.Type;
                    }
 

    

