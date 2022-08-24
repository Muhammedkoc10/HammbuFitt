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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnAnaSayfaGirisEkraninaDon_Click(object sender, EventArgs e)
        {
            Giriş giris = new Giriş();
            this.Hide();
            giris.Show();
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaSayfaDiyetListeleri_Click(object sender, EventArgs e)
        {
            DiyetOnerisi diyetOnerisi = new DiyetOnerisi();
            this.Hide();
            diyetOnerisi.Show();
        }

        private void btnAnaSayfaYemekKalori_Click(object sender, EventArgs e)
        {
            YemekVeKalori yemekVeKalori = new YemekVeKalori();
            this.Hide();
            yemekVeKalori.Show();
        }

        private void btnAnaSayfaOgunTakip_Click(object sender, EventArgs e)
        {
            Ogun ogun = new Ogun();
            this.Hide();
            ogun.Show();
        }

        private void btnAnaSayfaRaporlar_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            this.Hide();
            raporlar.Show();
        }
    }
}
