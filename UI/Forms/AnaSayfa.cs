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
        public AnaSayfa(string data)
        {
            InitializeComponent();
            lblHold2.Text = data;
        }
        
        private void btnAnaSayfaGirisEkraninaDon_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaSayfaDiyetListeleri_Click(object sender, EventArgs e)
        {
            DiyetOnerisi diyetOnerisi = new DiyetOnerisi(lblHold2.Text);
            this.Hide();
            diyetOnerisi.Show();
        }

        private void btnAnaSayfaYemekKalori_Click(object sender, EventArgs e)
        {
            YemekVeKalori yemekVeKalori = new YemekVeKalori(lblHold2.Text);
            this.Hide();
            yemekVeKalori.Show();
        }

        private void btnAnaSayfaOgunTakip_Click(object sender, EventArgs e)
        {
            Ogun ogun = new Ogun(lblHold2.Text);
            this.Hide();
            ogun.Show();
        }

        private void btnAnaSayfaRaporlar_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar(lblHold2.Text);
            this.Hide();
            raporlar.Show();
        }
    }
}
