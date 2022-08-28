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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        Context db;
        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            db = new Context();
        }

        private void btnSifremiUnuttumGeriDon_Click(object sender, EventArgs e)
        {
            Login giris = new Login();
            this.Hide();
            giris.Show();
        }

        private void SifremiUnuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSifremiHatirlat_Click(object sender, EventArgs e)
        {
            
            
            if(db.Kullacınılar.Where(x => x.UserID == db.Kullacınılar.FirstOrDefault(y => y.UserName == txtSifreKullaniciAdi.Text).UserID).FirstOrDefault() != null)
            {
                if (db.Kullacınılar.Where(x=>x.MailAddress==txtSifreEmail.Text).FirstOrDefault()!=null)
                {
                    string y =db.Kullacınılar.Where(x => x.UserID == db.Kullacınılar.FirstOrDefault(z => z.UserName == txtSifreKullaniciAdi.Text).UserID).FirstOrDefault().Password.ToString();
                    MessageBox.Show("Şifreniz : "+ y);
                    //temizle
                }
                else
                    MessageBox.Show("Bu kullanıcı adının mail adresi doğru değil!");
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız yanlış!");
            }
        }
    }
}
