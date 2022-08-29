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
    public partial class PasswordReminder : Form
    {
        public PasswordReminder()
        {
            InitializeComponent();
        }
        Context db;
        private void PasswordReminder_Load(object sender, EventArgs e)
        {
            db = new Context();
        }
        private void PasswordReminder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPasswordReminder_Click(object sender, EventArgs e)
        {
            if (txtEmailReminder.Text.Trim()!=""&&txtUserNameReminder.Text.Trim() != "")
            {
                if (db.Users.Where(x => x.UserID == db.Users.FirstOrDefault(y => y.UserName == txtUserNameReminder.Text).UserID).FirstOrDefault() != null)
                {
                    if (db.Users.Where(x => x.MailAddress == txtEmailReminder.Text).FirstOrDefault() != null)
                    {
                        string password = db.Users.Where(x => x.UserID == db.Users.FirstOrDefault(z => z.UserName == txtUserNameReminder.Text).UserID).FirstOrDefault().Password.ToString();
                        MessageBox.Show("Şifreniz : " + password);
                        Methods.Clear(grpPasswordReminder);
                    }
                    else
                        MessageBox.Show("Bu kullanıcı adının mail adresi doğru değil!");
                }
                else
                    MessageBox.Show("Kullanıcı adınız yanlış!");
            }
            else
                MessageBox.Show("Lütfen boş alan bırakmayınız!");
        }

        private void btnBackToLoginPage_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
