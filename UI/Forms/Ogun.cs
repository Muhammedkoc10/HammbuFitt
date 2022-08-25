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
    
    public partial class Ogun : Form
    {
        int mealID = 11;
        Context db;
        public Ogun(string datas)
        {
            InitializeComponent();
            lblHold1.Text = datas;
        }

        private void Ogun_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOgunGeriDon_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            if (cmbMealCategorySelect.SelectedIndex<0||cmbMealFoodSelect.SelectedIndex<0||cmbMealSelect.SelectedIndex<0)
            {
                MessageBox.Show("Hata! Lütfen tüm alanları doldurun..");
            }
            else
            {
                int user = db.Kullacınılar.Where(x => x.UserName == lblHold1.Text).FirstOrDefault().UserID;
                mealID = mealID + 1;
                
                Meal meal;
                string selectedMeal = (cmbMealSelect.Text);
                meal = new Meal()
                {
                    MealTime = selectedMeal
                };
                db.Öğünler.Add(meal);
                int selectedFood = int.Parse(cmbMealFoodSelect.SelectedValue.ToString());
                FoodMeal foodMeal;
                foodMeal = new FoodMeal()
                {
                    FoodsMeal=db.Yemekler.Where(x=>x.FoodID==(int)cmbMealFoodSelect.SelectedValue).FirstOrDefault(),
                    MealsFood=db.Öğünler.Where(x=>x.MealID== mealID).FirstOrDefault()
                };
                db.ÖğünYemekleri.Add(foodMeal);
              
                UserMeal userMeal;
                userMeal = new UserMeal()
                {
                    UsersMeal=db.Kullacınılar.Where(x => x.UserID == user).FirstOrDefault(),
                    MealsUser = db.Öğünler.Where(x => x.MealID == mealID).FirstOrDefault()
                };
                db.ÖğünKullanıcıları.Add(userMeal);
                db.SaveChanges();
                MessageBox.Show("Başarılı");
                ListViewItem lvi = new ListViewItem();
                lvi.Text = cmbMealCategorySelect.Text;
                lvi.SubItems.Add(cmbMealFoodSelect.Text);
                lvi.SubItems.Add(cmbMealSelect.Text);
                lstShowMeal.Items.Add(lvi);
            }
        }

        private void Ogun_Load(object sender, EventArgs e)
        {
            FillCategory();
            cmbMealFoodSelect.Enabled = false;
            cmbMealSelect.Enabled = false;
        }
        private void FillCategory(int SelectedCategory = -1)
        {
            db = new Context();
            List<Category> kategoriler = db.Kategoriler.ToList();
            cmbMealCategorySelect.DataSource = kategoriler;
            cmbMealCategorySelect.DisplayMember = "CategoryName";
            cmbMealCategorySelect.ValueMember = "CategoryID";
            cmbMealCategorySelect.SelectedValue = SelectedCategory;
        }

        private void cmbMealCategorySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbMealCategorySelect.Items.Count; i++)
            {
                if (cmbMealCategorySelect.SelectedIndex == i)
                    FoodFill(i + 1);
            }
            if (cmbMealCategorySelect.SelectedIndex > -1)
                cmbMealFoodSelect.Enabled = true;
        }
        public void FoodFill(int x)
        {
            List<Food> foods = db.Yemekler.Where(w => w.CategoryID == x).ToList();
            cmbMealFoodSelect.DataSource = foods;
            cmbMealFoodSelect.DisplayMember = "FoodName";
            cmbMealFoodSelect.ValueMember = "FoodID";
            cmbMealFoodSelect.SelectedValue = -1;
        }

        private void cmbMealFoodSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMealCategorySelect.Enabled==true&&cmbMealFoodSelect.Enabled==true)
            {
                cmbMealSelect.Enabled = true;
            }
        }
    }
}
