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
    public partial class MainPage : Form
    {
        public MainPage(string data)
        {
            InitializeComponent();
            lblHold2.Text = data;
        }
        
        private void btnBackLoginPage_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDietList_Click(object sender, EventArgs e)
        {
            DietSuggestionPage dietSuggestion = new DietSuggestionPage(lblHold2.Text);
            this.Hide();
            dietSuggestion.Show();
        }

        private void btnFoodCalorisPage_Click(object sender, EventArgs e)
        {
            FoodsAndCalories foodsAndCalories = new FoodsAndCalories(lblHold2.Text);
            this.Hide();
            foodsAndCalories.Show();
        }

        private void btnMealPage_Click(object sender, EventArgs e)
        {
            MealPage meal = new MealPage(lblHold2.Text);
            this.Hide();
            meal.Show();
        }

        private void btnReportsPage_Click(object sender, EventArgs e)
        {
            ReportsPage reports = new ReportsPage(lblHold2.Text);
            this.Hide();
            reports.Show();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
