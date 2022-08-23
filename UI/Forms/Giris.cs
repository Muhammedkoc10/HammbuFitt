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
    public partial class Giriş : Form
    {
        
        public Giriş()
        {
            InitializeComponent();
        }

        Context db;
        
        private void Giriş_Load(object sender, EventArgs e)
        {
            db = new Context();
            txtGirisSifre.PasswordChar = '*';
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (db.Kullacınılar.FirstOrDefault(x => x.UserName == txtGirisKullaniciAdi.Text)!=null&& db.Kullacınılar.FirstOrDefault(x => x.Password == txtGirisSifre.Text)!=null)
            {
                AnaSayfa anaform = new AnaSayfa();
                this.Hide();
                anaform.Show();
            }
            else
                MessageBox.Show("Lütfen kullanıcı adı veya şifrenizi doğru giriniz!");
            // temizle metodu
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayit = new KayitOl(this);
            this.Hide();
            kayit.Show();
        }

        private void lblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum(this);
            this.Hide();
            sifremiUnuttum.Show();
        }

        private void Giriş_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked)
                txtGirisSifre.PasswordChar =  default;
            else
                txtGirisSifre.PasswordChar = '*';
        }
    }
}
