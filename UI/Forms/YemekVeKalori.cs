using HammbuuFittDal;
using HammbuuFittData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        Context db;
        private void YemekVeKalori_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnYemekVeKaloriGeriDon_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private void YemekVeKalori_Load(object sender, EventArgs e)
        {
            db = new Context();
            List<Category> kategoriler = db.Kategoriler.ToList();
            foreach (Category item in kategoriler)
            {
                cmbKaloriVeBesinKategoriSec.Items.Add(item.CategoryName);
                cmbKategoriEkleKategoriSec.Items.Add(item.CategoryName);
            }
        }

        private void cmbKaloriVeBesinKategoriSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKaloriVeBesinBesinSec.Items.Clear();
            cmbKaloriVeBesinBesinSec.Text = "";
            for (int i = 0; i < cmbKaloriVeBesinKategoriSec.Items.Count; i++)
            {
                if (cmbKaloriVeBesinKategoriSec.SelectedIndex == i)
                    CmbFill(i + 1);
            }
        }
        void CmbFill(int x)
        {
            List<Food> foods = db.Yemekler.Where(w => w.CategoryID == x).ToList();
            foreach (Food item in foods)
            {
                cmbKaloriVeBesinBesinSec.Items.Add(item.FoodName);
            }
        }

        private void btnKaloriVeBesinGoster_Click(object sender, EventArgs e)
        {
            //pbKaloriVeBesinResim.Image = ByteArrayToImage(db.Yemekler.FirstOrDefault(x => x.FoodID == cmbKaloriVeBesinBesinSec.SelectedIndex).Photo);
            var foodCalories = db.Yemekler.Where(w => w.FoodName == cmbKaloriVeBesinBesinSec.Text).Select(x => new { x.FoodName, x.Calories }).ToList();
            dgvYemekKalori.DataSource = foodCalories;

            
        }

        private void btnKategoriEkleEkle_Click(object sender, EventArgs e)
        {
            Food food = db.Yemekler.Where(x => x.FoodID == cmbKategoriEkleKategoriSec.SelectedIndex).FirstOrDefault();
            food = new Food()
            {
                CategoryID = cmbKategoriEkleKategoriSec.SelectedIndex + 1,
                FoodName = txtKategoriEkleEklenecekBesin.Text,
                Calories = (int)numKategoriEkleKalori.Value,
                PhotoPath = SaveImage(pbOnizleme, txtResimYolu.Text),
                Photo = ImageToByteArray(pbOnizleme.Image),
                IsActive = true
            };
            
            db.Yemekler.Add(food);
            db.SaveChanges();

        }

        public static string SaveImage(PictureBox pictureBox, string firstName)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(.jpg;.jpeg; .gif;.bmp; .png)|.jpg; .jpeg;.gif; .bmp;.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(Application.StartupPath + "/images"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "/images");
                }
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = new Bitmap(open.FileName);

                string fileName = firstName + Guid.NewGuid().ToString().Substring(1, 6).Replace("-", string.Empty);
                string imagePath = Application.StartupPath + "/images" + fileName + ".jpeg";
                pictureBox.Image.Save(imagePath, ImageFormat.Jpeg);
                return imagePath;
            }
            return "";
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] bytesArr)
        {
            using (var ms = new MemoryStream(bytesArr))
            {
                return Image.FromStream(ms);
            }
        }
        private void btnKategoriEkleResimSec_Click(object sender, EventArgs e)
        {
            //// open file dialog
            //OpenFileDialog open = new OpenFileDialog();
            //// image filters
            //open.Filter = "Image Files(.jpg;.jpeg; .gif;.bmp)|.jpg;.jpeg; .gif;.bmp";
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    // display image in picture box
            //    pbOnizleme.Image = new Bitmap(open.FileName);
            //    // image file path
            //    txtResimYolu.Text = open.FileName;
            //}
        }
    }
}
