﻿using HammbuuFittDal;
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
        
        private void Giriş_Load(object sender, EventArgs e)
        {
            db = new Context();
            txtLoginPassword.PasswordChar = '*';
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtLoginUserName.Text.Trim()!="")
            {
                if (db.Kullacınılar.FirstOrDefault(x => x.UserName == txtLoginUserName.Text) != null && db.Kullacınılar.FirstOrDefault(x => x.Password == txtLoginPassword.Text) != null)
                {
                    AnaSayfa anaform = new AnaSayfa(txtLoginUserName.Text);
                    this.Hide();
                    anaform.Show();
                }
                else
                    MessageBox.Show("Lütfen kullanıcı adı veya şifrenizi doğru giriniz!");
            }
            else
                MessageBox.Show("Lütfen kullanıcı adı ve şifre bölümlerini boş bırakmayınız ");
            // temizle metodu
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            KayitOl kayit = new KayitOl();
            this.Hide();
            kayit.Show();
        }

        private void lblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            this.Hide();
            sifremiUnuttum.Show();
        }

        private void Giriş_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                txtLoginPassword.PasswordChar =  default;
            else
                txtLoginPassword.PasswordChar = '*';
        }
    }
}
