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
    public partial class DietSuggestionPage : Form
    {
        public DietSuggestionPage(string data)
        {
            InitializeComponent();
            lblHold.Text = data;
        }
        Context db;
        private void DietSuggestionPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DietSuggestionPage_Load(object sender, EventArgs e)
        {

            db = new Context();
            int userId = UserIdFill();
            if (db.Users.Where(x => x.UserID == userId && x.IsSportsman == true && x.BasalMetabolismRate < 25) != null)
            {
                pb1.Show();
                MessageBox.Show("ye");
            }
                
            else if (db.Users.Where(x => x.UserID == userId && x.IsSportsman == true && x.BasalMetabolismRate < 25) != null)
                pb2.Show();
            else if (db.Users.Where(x => x.UserID == userId && x.IsSportsman == true && x.BasalMetabolismRate < 25) != null)
                pb2.Show();
            else if (db.Users.Where(x => x.UserID == userId && x.IsSportsman == true && x.BasalMetabolismRate < 25) != null)
                pb2.Show();
            else if (db.Users.Where(x => x.UserID == userId && x.IsSportsman == true && x.BasalMetabolismRate < 25) != null)
                pb2.Show();
        }
        
        private void btnBackMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(lblHold.Text);
            this.Hide();
            mainPage.Show();
        }
        private int UserIdFill()
        {
            int userID = 0;
            if (lblHold.Text.Trim() != "")
                return userID = db.Users.Where(x => x.UserName == lblHold.Text).FirstOrDefault().UserID;
            else
            {
                MessageBox.Show("Hata oluştu lütfen tekrar deneyiniz.");
                Application.Exit();
                return 0;
            }
        }
    }
}
