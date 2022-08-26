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
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBackReportToMain_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {

        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {

        }

        private void btnMostEatFoodsOnMeals_Click(object sender, EventArgs e)
        {

        }
    }
}
