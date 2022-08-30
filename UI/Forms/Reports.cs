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
    public partial class ReportsPage : Form
    {
        Context db;
        public ReportsPage(string datas)
        {
            InitializeComponent();
            lblHold3.Text = datas;
        }

        private void ReportsPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBackReportToMain_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(lblHold3.Text);
            this.Hide();
            mainPage.Show();
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            dgvWeeklyReport.Rows.Clear();
            int b = 1;
            int userID = UserIdFill2();
            for (int i = 7; i > 0; i--)
            {
                DateTime end = DateTime.Now.Date.AddDays(i - 6);
                DateTime start = DateTime.Now.Date.AddDays(i - 7);
                try
                {
                    if (db.MealFoods.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).Sum(x => x.FoodsMeal.Calories) != 0)
                    {
                        double avgCalories = db.MealFoods.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).Sum(x => x.FoodsMeal.Calories);
                        dgvWeeklyReport.Rows.Add((8-b) + " .gün", avgCalories.ToString());
                        b++;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(8-b + ".günde haftalık öğün bilginiz bulunmamaktadır!");
                    b++;
                    continue;
                }
            }
        }
        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            int n = 4;
            int b = 1;
            dgvMonthlyReport.Rows.Clear();
            int userID = UserIdFill2();
            for (int i = 28; i > 0; i -= +7)
            {
                DateTime end = DateTime.Now.Date.AddDays(-i + 7);
                DateTime start = DateTime.Now.Date.AddDays(-i);
                try
                {
                    if (db.MealFoods.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).Sum(x => x.FoodsMeal.Calories) != 0)
                    {
                        double avgCalories = db.MealFoods.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).Sum(x => x.FoodsMeal.Calories);
                        dgvMonthlyReport.Rows.Add(n + " .hafta", avgCalories.ToString());
                    }
                    n--;
                }
                catch (Exception)
                {
                    MessageBox.Show(b + ".Haftada aylık öğün bilginiz bulunmamaktadır!");
                    b++;
                    continue;
                }
            }
        }

        private void btnMostEatFoodsOnMeals_Click(object sender, EventArgs e)
        {
            string morning = FindFoodName("Sabah");
            string snack1 = FindFoodName("Ara Öğün 1");
            string lunch = FindFoodName("Öğle");
            string snack2 = FindFoodName("Ara Öğün 2");
            string dinner = FindFoodName("Akşam");
            lstBreakfast.Items.Add(morning);
            lstSnack1.Items.Add(snack1);
            lstLunch.Items.Add(lunch);
            lstSnack2.Items.Add(snack2);
            lstDinner.Items.Add(dinner);
        }

        private string FindFoodName(string mealTime)
        {
            int userID = UserIdFill2();
            int mealCount = db.Meals.Where(x => x.MealID.ToString() != null).Count();
            string food = string.Empty;
            try
            {
                for (int i = 0; i < mealCount; i++)
                {
                    if (db.MealFoods.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate != null && x.UserID == userID && x.MealsFood.MealTime == mealTime) != null)
                    {
                        int result = db.MealFoods.Where(x => x.MealsFood.MealTime == mealTime&& x.UserID == userID)
                   .GroupBy(f => f.FoodID)
                   .Select(g => new { foodID = g.Key, count = g.Count() })
                   .OrderByDescending(x => x.count).Take(1).First().foodID;
                        food = db.Foods.Where(x => x.FoodID == result).FirstOrDefault().FoodName;
                    }
                    else
                    {
                        MessageBox.Show("Henüz " + mealTime + " öğün girişi yapılmaldı!");
                        return string.Empty;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Henüz " + mealTime + " öğün girişi yapılmaldı!");
            }
            
            return food;
        }

        private void ReportsPage_Load(object sender, EventArgs e)
        {
            db = new Context();
        }
        private int UserIdFill2()
        {
            int userID = 0;
            if (lblHold3.Text.Trim() != "")
                return userID = db.Users.Where(x => x.UserName == lblHold3.Text).FirstOrDefault().UserID;
            else
            {
                MessageBox.Show("Hata oluştu lütfen tekrar deneyiniz");
                Application.Exit();
                return 0;
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
