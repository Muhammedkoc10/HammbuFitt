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
    public partial class MealPage : Form
    {
        Context db;
        public MealPage(string datas)
        {
            InitializeComponent();
            lblHold1.Text = datas;
        }

        private void Meal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMealBackToMain_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(lblHold1.Text);
            this.Hide();
            mainPage.Show();
        }

        private void Meal_Load(object sender, EventArgs e)
        {
            FillCategory();
            cmbMealFoodSelect.Enabled = false;
            cmbMealSelect.Enabled = false;

        }
        private void FillCategory(int SelectedCategory = -1)
        {
            db = new Context();
            List<Category> categories = db.Categories.ToList();
            cmbMealCategorySelect.DataSource = categories;
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
            List<Food> foods = db.Foods.Where(w => w.CategoryID == x).ToList();
            cmbMealFoodSelect.DataSource = foods;
            cmbMealFoodSelect.DisplayMember = "FoodName";
            cmbMealFoodSelect.ValueMember = "FoodID";
            cmbMealFoodSelect.SelectedValue = -1;
        }

        private void cmbMealFoodSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMealCategorySelect.Enabled == true && cmbMealFoodSelect.Enabled == true)
            {
                cmbMealSelect.Enabled = true;
            }
        }

        private void btnDailyMealInfo_Click(object sender, EventArgs e)
        {
            dgvMealDaily.Rows.Clear();
            int userID = UserIdFill();
            DateTime end = DateTime.Now;
            DateTime start = DateTime.Now.Date;
            try
            {
                var allMeals = db.MealFoods.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).ToList();
                if (allMeals.Count!=0)
                {
                    foreach (var item in allMeals)
                    {
                        dgvMealDaily.Rows.Add(item.MealsFood.MealTime, item.FoodsMeal.FoodName, item.FoodsMeal.Calories);
                    }
                }
                else
                {
                    MessageBox.Show("Günlük öğün bilginiz bulunmamaktadır.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Günlük öğün bilginiz bulunmamaktadır.");
            }
        }

        private int UserIdFill()
        {
            int userID = 0;
            if (lblHold1.Text.Trim() != "")
                return userID = db.Users.Where(x => x.UserName == lblHold1.Text).FirstOrDefault().UserID;
            else
            {
                MessageBox.Show("Hata oluştu lütfen tekrar deneyiniz.");
                Application.Exit();
                return 0;
            }
        }

        private void btnDailyCalories_Click(object sender, EventArgs e)
        {
            DateTime end = DateTime.Now;
            DateTime start = DateTime.Now.Date;
            int userID = UserIdFill();

            try
            {
                double result = db.MealFoods.Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).Sum(x => x.FoodsMeal.Calories);//düzelt
                if (db.MealFoods.Where(x => x.UsersMeal.UserID == userID).FirstOrDefault().UsersMeal.BasalMetabolismRate > (decimal)result)
                    MessageBox.Show("Şu ana kadar günlük almanız gereken kalorinin altındasınız!");
                else
                    MessageBox.Show("Şu ana kadar günlük almanız gereken kaloriyi geçtiniz!");
                MessageBox.Show("Şu ana kadar aldığınız toplam kalori: " + result.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Günlük öğün bilginiz bulunamadı.");
            }
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            if (cmbMealCategorySelect.SelectedIndex < 0 || cmbMealFoodSelect.SelectedIndex < 0 || cmbMealSelect.SelectedIndex < 0)
            {
                MessageBox.Show("Hata! Lütfen tüm alanları doldurun..");
            }
            else
            {
                int mealID;
                if (db.Meals.OrderByDescending(x => x.AddedDate).Take(1).FirstOrDefault() == null)
                {
                    mealID = 0;
                }
                else
                {
                    mealID = db.Meals.OrderByDescending(x => x.AddedDate).Take(1).FirstOrDefault().MealID;
                }

                int userID = UserIdFill();
                Meal meal;
                string selectedMeal = (cmbMealSelect.Text);
                meal = new Meal()
                {
                    MealTime = selectedMeal,
                    AddedDate = DateTime.Now
                };
                db.Meals.Add(meal);
                int selectedFood = int.Parse(cmbMealFoodSelect.SelectedValue.ToString());
                FoodMeal foodMeal;
                foodMeal = new FoodMeal()
                {
                    FoodsMeal = db.Foods.Where(x => x.FoodID == (int)cmbMealFoodSelect.SelectedValue).FirstOrDefault(),
                    MealsFood = db.Meals.Where(x => x.MealID == mealID + 1).FirstOrDefault(),
                    UsersMeal = db.Users.Where(x => x.UserID == userID).FirstOrDefault(),
                };
                db.MealFoods.Add(foodMeal);

                db.SaveChanges();
                MessageBox.Show("Öğün ekleme işlemi başarılı");
                ListViewItem lvi = new ListViewItem();
                lvi.Text = cmbMealCategorySelect.Text;
                lvi.SubItems.Add(cmbMealFoodSelect.Text);
                lvi.SubItems.Add(cmbMealSelect.Text);
                lstShowMeal.Items.Add(lvi);
                Methods.Clear(grpAddMeal);
                cmbMealFoodSelect.Enabled = false;
                cmbMealSelect.Enabled = false;
                cmbMealSelect.Text = "";
;            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
