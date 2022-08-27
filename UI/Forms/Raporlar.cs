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
            AnaSayfa anaSayfa = new AnaSayfa("");
            this.Hide();
            anaSayfa.Show();
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            
            dgvWeeklyReport.Rows.Clear();
            int userID = UserIdFill2();
            for (int i = 7; i > 0; i--)
            {
                DateTime end = DateTime.Now.Date.AddDays(-i+1);
                DateTime start = DateTime.Now.Date.AddDays(-i);
                long avgCalories = db.ÖğünYemekleri.Include("MealsFood").Include("FoodsMeal").Where(x => x.MealsFood.AddedDate >= start && x.MealsFood.AddedDate <= end && x.UserID == userID).Sum(x=>x.FoodsMeal.Calories<0? 0: x.FoodsMeal.Calories);
                if (avgCalories!=0)
                {
                    dgvWeeklyReport.Rows.Add(8 - i + " .gün", avgCalories.ToString());
                }
                else
                {
                    MessageBox.Show("tes");
                }
            }
        }
        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {

        }

        private void btnMostEatFoodsOnMeals_Click(object sender, EventArgs e)
        {

        }

        private void Raporlar_Load(object sender, EventArgs e)
        {

        }
        private int UserIdFill2()
        {
            db = new Context();
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
