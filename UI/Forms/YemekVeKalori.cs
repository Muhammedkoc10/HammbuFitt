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
    public partial class YemekVeKalori : Form
    {
        public YemekVeKalori()
        {
            InitializeComponent();
        }
        Context db;
        private void YemekVeKalori_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnYemekVeKaloriGeriDon_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private void YemekVeKalori_Load(object sender, EventArgs e)
        {
            db = new Context();
            List<Category> kategoriler = db.Kategoriler.ToList();
            foreach (Category item in kategoriler)
            {
                cmbKaloriVeBesinKategoriSec.Items.Add(item.CategoryName);
                cmbKategoriEkleKategoriSec.Items.Add(item.CategoryName);
            }
        }

        private void cmbKaloriVeBesinKategoriSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKaloriVeBesinBesinSec.Items.Clear();
            cmbKaloriVeBesinBesinSec.Text = "";
            for (int i = 0; i < cmbKaloriVeBesinKategoriSec.Items.Count; i++)
            {
                if (cmbKaloriVeBesinKategoriSec.SelectedIndex == i)
                    CmbFill(i + 1);
            }
        }
        void CmbFill(int x)
        {
            List<Food> foods = db.Yemekler.Where(w => w.CategoryID == x).ToList();
            foreach (Food item in foods)
            {
                cmbKaloriVeBesinBesinSec.Items.Add(item.FoodName);
            }
        }

        private void btnKaloriVeBesinGoster_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbKaloriVeBesinBesinSec.Items.Count; i++)
            {
                if (cmbKaloriVeBesinBesinSec.SelectedIndex==i)
                {
                    DgvFill(i+1);
                }
            }
            
        }

        private void DgvFill(int v)
        {
            var foodCalories = db.Yemekler.Where(w => w.FoodID == v).Select(x=>new {x.FoodName, x.Calories }).ToList();
            dgvYemekKalori.DataSource = (foodCalories);

        }
    }
}
