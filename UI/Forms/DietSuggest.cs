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
            bool usersSportman = db.Users.Where(x => x.UserID == userId).FirstOrDefault().IsSportsman;
            decimal usersBodyMassIndex = db.Users.Where(x => x.UserID == userId).FirstOrDefault().BodyMassIndex;
            if (usersSportman == true && usersBodyMassIndex <= 18)
                pb1.Show();
            else if (usersSportman == false && usersBodyMassIndex <= 18)
                pb2.Show();
            else if (usersSportman == true && usersBodyMassIndex > 18 && usersBodyMassIndex <= 23)
                pb3.Show();
            else if (usersSportman == false && usersBodyMassIndex > 18 && usersBodyMassIndex <= 23)
                pb4.Show();
            else if (usersSportman == true && usersBodyMassIndex >23)
                pb5.Show();
            else if (usersSportman == false && usersBodyMassIndex > 23)
                pb6.Show();
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

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
