using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp2
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            string login = LoginInput.Text.ToLower();
            string password = PasswordInput.Text;
            bool flag = true;

            switch (login)
            {
                case "admin":
                    if (password == "admin")
                    {
                        MyUser.SetLogin(login);
                        Hide();
                        Admin ifrm = new Admin();
                        ifrm.Show();
                    }
                    else
                    {
                        flag = false;
                    }
                    break;

                case "employee":
                    if (password == "employee")
                    {
                        MyUser.SetLogin(login);
                        Hide();
                        Admin ifrm = new Admin();
                        ifrm.Show();
                    }
                    else
                    {
                        flag = false;
                    }
                    break;

                case "mechanik":
                    if (password == "mechanik")
                    {
                        MyUser.SetLogin(login);
                        Hide();
                        Admin ifrm = new Admin();
                        ifrm.Show();
                    }
                    else
                    {
                        flag = false;
                    }
                    break;

                case "user":

                    if (password == "user")
                    {
                        MyUser.SetLogin(login);
                        Hide();
                        User ifrm = new User();
                        ifrm.Show();
                    }
                    else
                    {
                        flag = false;
                    }
                    break;
                default:
                    flag = false;
                    break;
            }
            
            if (!flag)
            {
                MessageBox.Show("Невверный логин или пароль");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
