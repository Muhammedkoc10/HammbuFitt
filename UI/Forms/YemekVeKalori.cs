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

        private void YemekVeKalori_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
