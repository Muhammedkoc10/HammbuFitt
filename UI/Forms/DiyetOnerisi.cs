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
    public partial class DiyetOnerisi : Form
    {
        public DiyetOnerisi()
        {
            InitializeComponent();
        }

        private void DiyetOnerisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DiyetOnerisi_Load(object sender, EventArgs e)
        {
            // VKİ'ye göre diyet önerisi!
        }
    }
}
