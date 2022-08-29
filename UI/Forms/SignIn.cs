using HammbuuFittDal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms;

namespace UI
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        Context db;
        
        private void Login_Load(object sender, EventArgs e)
        {
            db = new Context();
            txtLoginPassword.PasswordChar = '*';
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtLoginUserName.Text.Trim()!="")
            {
                if (db.Users.FirstOrDefault(x => x.UserName == txtLoginUserName.Text) != null && db.Users.FirstOrDefault(x => x.Password == txtLoginPassword.Text) != null)
                {
                    MainPage mainPage = new MainPage(txtLoginUserName.Text);
                    this.Hide();
                    mainPage.Show();
                }
                else
                    MessageBox.Show("Lütfen kullanıcı adı veya şifrenizi doğru giriniz!");
            }
            else
                MessageBox.Show("Lütfen kullanıcı adı ve şifre bölümlerini boş bırakmayınız ");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            this.Hide();
            sign.Show();
        }

        private void lblPasswordReminder_Click(object sender, EventArgs e)
        {
            PasswordReminder passwordReminder = new PasswordReminder();
            this.Hide();
            passwordReminder.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                txtLoginPassword.PasswordChar =  default;
            else
                txtLoginPassword.PasswordChar = '*';
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
