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

namespace UI.Forms
{
    public partial class DiyetOnerisi : Form
    {
        public DiyetOnerisi()
        {
            InitializeComponent();
        }
        Context db;
        private void DiyetOnerisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DiyetOnerisi_Load(object sender, EventArgs e)
        {
            Giriş giris = new Giriş();
            int userID = 1;
            db = new Context();
            if (db.Kullacınılar.FirstOrDefault(x => x.UserID == userID).IsSportsman)
            {
                grbProfesyonelKullanici.Visible = true;
                grbGunlukKullanici.Visible = false;
            }
            if (db.Kullacınılar.FirstOrDefault(x => x.UserID == userID).IsSportsman==false)
            {
                grbProfesyonelKullanici.Visible = false;
                grbGunlukKullanici.Visible = true;
            }
            // VKİ'ye göre diyet önerisi!
        }

        private void btnDiyetOnerisiGeriDon_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa("");
            this.Hide();
            anaSayfa.Show();
        }
    }
}
