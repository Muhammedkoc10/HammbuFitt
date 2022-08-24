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
    public partial class KayitOl : Form
    {
        Giriş anaForm;
        public KayitOl(Giriş ana)
        {
            anaForm = ana;
            InitializeComponent();
        }
        Context db;
        private void KayitOl_Load(object sender, EventArgs e)
        {
            db = new Context();
            rbKayitOlErkek.Checked = true;
            txtKayitOlSifre.PasswordChar = '*';
            txtKayitOlSifreTekrari.PasswordChar = '*';
            
        }

        private void btnKayitOlAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            Giriş giris = new Giriş();
            this.Hide();
            giris.Show();
        }

        private void KayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnKayitOlIptal_Click(object sender, EventArgs e)
        {
            //temizle
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            int yas = (DateTime.Now.Year - dtpKayitOlDogumTarihi.Value.Year);
            if (txtKayitOlIsim.Text.Trim() != "" && txtKayitOlSoyIsim.Text.Trim() != "" && txtKayitOlKullaniciAdi.Text.Trim() != "" && txtKayitOlMail.Text.Trim() != "" && txtKayitOlSifre.Text.Trim() != "" && txtKayitOlSifreTekrari.Text.Trim() != "")
            {
                User kullanici = db.Kullacınılar.FirstOrDefault(x => x.UserName == txtKayitOlKullaniciAdi.Text);
                if (kullanici == null)
                {
                    if (numKayitOlKilo.Value > 0 && numKayitOlBoy.Value > 0)
                    {
                        decimal bmhErkek = (66.5m + (13.75m * Convert.ToDecimal(numKayitOlBoy.Value)) + (5.03m * Convert.ToDecimal(numKayitOlKilo.Value)) - (6.75m * Convert.ToDecimal(yas)));
                        decimal bmhKadin = (65.5m + (9.56m * Convert.ToDecimal(numKayitOlBoy.Value)) + (1.85m * Convert.ToDecimal(numKayitOlKilo.Value)) - (4.68m * Convert.ToDecimal(yas)));
                        decimal vki = (numKayitOlKilo.Value) / (Convert.ToDecimal(Math.Pow((double)(numKayitOlBoy.Value / 100m), 2)));
                        if (yas > 18)
                        {
                            if (RegexUtilities.IsPasswordValid(txtKayitOlSifre.Text))
                            {
                                if (txtKayitOlSifre.Text == txtKayitOlSifreTekrari.Text)
                                {
                                    if (RegexUtilities.IsValidEmail(txtKayitOlMail.Text))
                                    {
                                        if (rbKayitOlErkek.Checked)
                                        {
                                            kullanici = new User()
                                            {
                                                UserName = txtKayitOlKullaniciAdi.Text,
                                                MailAddress = txtKayitOlMail.Text,
                                                Password = txtKayitOlSifre.Text,
                                                FirstName = txtKayitOlIsim.Text,
                                                LastName = txtKayitOlSoyIsim.Text,
                                                Gender = true,
                                                Age = (yas),
                                                BodyMassIndex = vki,
                                                BasalMetabolismRate = bmhErkek,
                                                IsActive = true,
                                                IsSportsman = chkSporcu.Checked ? true : false
                                            };
                                            db.Kullacınılar.Add(kullanici);
                                            db.SaveChanges();
                                            UygulamaTanitim uygulamaTanitim = new UygulamaTanitim();
                                            this.Hide();
                                            uygulamaTanitim.Show();
                                        }
                                        else
                                        {
                                            kullanici = new User()
                                            {
                                                UserName = txtKayitOlKullaniciAdi.Text,
                                                MailAddress = txtKayitOlMail.Text,
                                                Password = txtKayitOlSifre.Text,
                                                FirstName = txtKayitOlIsim.Text,
                                                LastName = txtKayitOlSoyIsim.Text,
                                                Gender = false,
                                                Age = (yas),
                                                BodyMassIndex = vki,
                                                BasalMetabolismRate = bmhKadin,
                                                IsActive = true,
                                                IsSportsman = chkSporcu.Checked ? true : false
                                            };
                                            db.Kullacınılar.Add(kullanici);
                                            db.SaveChanges();
                                            UygulamaTanitim uygulamaTanitim = new UygulamaTanitim();
                                            this.Hide();
                                            uygulamaTanitim.Show();
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
                                MessageBox.Show("Girilen şifre en az 6 karakter uzunluğunda bir büyük,bir küçük harf, bir sayı ve özel karakter($@._,!%*?+#&'()[=\"€) içermek zorundadır!");
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
            //temizle!
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked)
                txtKayitOlSifre.PasswordChar = txtKayitOlSifreTekrari.PasswordChar = default;
            else
                txtKayitOlSifre.PasswordChar = txtKayitOlSifreTekrari.PasswordChar = '*';
        }
    }
}
