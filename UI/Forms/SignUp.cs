using HammbuuFittDal;
using HammbuuFittData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        Context db;
        private void SignUp_Load(object sender, EventArgs e)
        {
            db = new Context();
            rbMan.Checked = true;
            txtPassword.PasswordChar = '*';
            txtPasswordAgain.PasswordChar = '*';
            
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Methods.Clear(grpSignUp);
            rbMan.Checked = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            dtBirthDate.MaxDate = DateTime.Now;
            int age = (DateTime.Now.Year - dtBirthDate.Value.Year);
            if (txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" && txtUserName.Text.Trim() != "" && txtMail.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtPasswordAgain.Text.Trim() != "")
            {
                User user = db.Users.FirstOrDefault(x => x.UserName == txtUserName.Text);
                if (user == null)
                {
                    if (nmrWeight.Value > 0 && nmrHeight.Value > 0)
                    {
                        decimal bmhMan = (66.5m + (13.75m * Convert.ToDecimal(nmrHeight.Value)) + (5.03m * Convert.ToDecimal(nmrWeight.Value)) - (6.75m * Convert.ToDecimal(age)));
                        decimal bmhWoman = (65.5m + (9.56m * Convert.ToDecimal(nmrHeight.Value)) + (1.85m * Convert.ToDecimal(nmrWeight.Value)) - (4.68m * Convert.ToDecimal(age)));
                        decimal vki = (nmrWeight.Value) / (Convert.ToDecimal(Math.Pow((double)(nmrHeight.Value / 100m), 2)));
                        if (age > 18)
                        {
                            if (RegexUtilities.IsPasswordValid(txtPassword.Text))
                            {
                                if (txtPassword.Text == txtPasswordAgain.Text)
                                {
                                    if (RegexUtilities.IsValidEmail(txtMail.Text))
                                    {
                                        if (rbMan.Checked)
                                        {
                                            user = new User()
                                            {
                                                UserName = txtUserName.Text,
                                                MailAddress = txtMail.Text,
                                                Password = txtPassword.Text,
                                                FirstName = txtFirstName.Text,
                                                LastName = txtLastName.Text,
                                                Gender = true,
                                                Age = (age),
                                                BodyMassIndex = vki,
                                                BasalMetabolismRate = bmhMan,
                                                IsActive = true,
                                                IsSportsman = chkSportsman.Checked ? true : false
                                            };
                                            db.Users.Add(user);
                                            db.SaveChanges();
                                            AppPresentation appPresentation= new AppPresentation();
                                            this.Hide();
                                            appPresentation.Show();
                                        }
                                        else
                                        {
                                            user = new User()
                                            {
                                                UserName = txtUserName.Text,
                                                MailAddress = txtMail.Text,
                                                Password = txtPassword.Text,
                                                FirstName = txtFirstName.Text,
                                                LastName = txtLastName.Text,
                                                Gender = false,
                                                Age = (age),
                                                BodyMassIndex = vki,
                                                BasalMetabolismRate = bmhWoman,
                                                IsActive = true,
                                                IsSportsman = chkSportsman.Checked ? true : false
                                            };
                                            db.Users.Add(user);
                                            db.SaveChanges();
                                            AppPresentation appPresentation = new AppPresentation();
                                            this.Hide();
                                            appPresentation.Show();
                                        }
                                        MessageBox.Show("Kayıt Başarılı!");
                                    }
                                    else
                                        MessageBox.Show("Mail adresi formatı yanlış! Lütfen ...@...com olarak giriniz!");
                                }
                                else
                                    MessageBox.Show("Şifreler birbirine uymuyor!");
                            }
                            else
                                MessageBox.Show("Girilen şifre en az 6 karakter uzunluğunda bir büyük,bir küçük harf, bir sayı,özel karakter($@._,!%*?+#&'()[=\"€) içermeli, Türkçe karakter içermemelidir! ");
                        }
                        else
                            MessageBox.Show("Kullanıcı 18 yaşından küçük olamaz!");
                    }
                    else
                        MessageBox.Show("Boy ve kilo 0 olamaz!");
                }
                else
                    MessageBox.Show("Bu kullanıcı adı daha önce alınmış!");
            }
            else
                MessageBox.Show("Tüm alanlara bilgi girişi yapılması zorunludur!");
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                txtPassword.PasswordChar = txtPasswordAgain.PasswordChar = default;
            else
                txtPassword.PasswordChar = txtPasswordAgain.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
