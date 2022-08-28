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
    public partial class Raporlar : Form
    {
        Context db;
        public Raporlar(string datas)
        {
            InitializeComponent();
            lblHold3.Text = datas;
        }

        private void Raporlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBackReportToMain_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa(lblHold3.Text);
            this.Hide();
            anaSayfa.Show();
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {

            dgvWeeklyReport.Rows.Clear();
            int userID = UserIdFill2();
            for (int i = 7; i > 0; i--)
            {
                DateTime end = DateTime.Now.Date.AddDays(-i + 1);
                DateTime start = DateTime.Now.Date.AddDays(-i);
                try
                {
                    if (db.ÖğünYemekleri.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).Sum(x => x.FoodsMeal.Calories) != 0)
                    {
                        double avgCalories = db.ÖğünYemekleri.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).Sum(x => x.FoodsMeal.Calories);
                        dgvWeeklyReport.Rows.Add(8 - i + " .gün", avgCalories.ToString());
                    }
                }
                catch (Exception)
                {
                    i--;
                }

            }
        }
        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            int n = 1;
            dgvMonthlyReport.Rows.Clear();
            int userID = UserIdFill2();
            for (int i = 28; i >= 0; i -= +7)
            {
                DateTime end = DateTime.Now.Date.AddDays(-i + 7);
                DateTime start = DateTime.Now.Date.AddDays(-i);
                try
                {
                    if (db.ÖğünYemekleri.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).Sum(x => x.FoodsMeal.Calories) != 0)
                    {
                        double avgCalories = db.ÖğünYemekleri.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).Sum(x => x.FoodsMeal.Calories);
                        dgvMonthlyReport.Rows.Add(n + " .hafta", avgCalories.ToString());
                    }
                    n++;
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        private void btnMostEatFoodsOnMeals_Click(object sender, EventArgs e)
        {
            ////var ss = db.ÖğünYemekleri.GroupBy(x => x.MealsFood.MealTime).Select(x => x.Key);
            ////MessageBox.Show(ss.ToString());
            ////var allMeals = new List<int>();
            //var meal1 = new List<string>();
            //var meal = db.ÖğünYemekleri.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.MealTime == "Öğle" && x.MealsFood.AddedDate < DateTime.Now).Select(x => x.MealID).ToList();
            //foreach (var item in meal)
            //{
            //   var q= db.ÖğünYemekleri.Include("MealsFood").Include("FoodsMeal").Where(x=>x.MealID== item).GroupBy(x=>x.FoodID).Take(1).Select(x => x.Key.Count());
               
            //        //dgvMostEatingFoodByMeal.Rows.Add(meal12);
            //}
            
            ////MessageBox.Show(meal.ToString());
            ////var xxx= db.ÖğünYemekleri.Where(x => x.MealsFood.MealTime == "Sabah").Select(x => x.FoodID).Count();
            ////foreach (var item in meal)
            ////{
            ////    dgvMostEatingFoodByMeal.Rows.Add(item);
            ////}

        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            db = new Context();
        }
        private int UserIdFill2()
        {

            int userID = 0;
            if (lblHold3.Text.Trim() != "")
                return userID = db.Kullacınılar.Where(x => x.UserName == lblHold3.Text).FirstOrDefault().UserID;
            else
            {
                MessageBox.Show("Hata oluştu lütfen tekrar deneyiniz");
                Application.Exit();
                return 0;
            }
        }

    }
}
