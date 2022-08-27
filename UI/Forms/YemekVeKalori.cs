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
        byte[] bytes = null;
        private void YemekVeKalori_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnYemekVeKaloriGeriDon_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa("");
            this.Hide();
            anaSayfa.Show();
            //cmbKaloriVeBesinBesinSec.Enabled = false;
        }

        private void YemekVeKalori_Load(object sender, EventArgs e)
        {
            FillKaloriBesin();
            cmbKaloriVeBesinBesinSec.Enabled = false;
        }

        private void FillKaloriBesin(int SelectedCategory = -1)
        {
            db = new Context();
            List<Category> kategoriler = db.Kategoriler.ToList();
            List<Category> kategoriler2 = db.Kategoriler.ToList();
            cmbKaloriVeBesinKategoriSec.DataSource = kategoriler;
            cmbKategoriEkleKategoriSec.DataSource = kategoriler2;
            cmbKaloriVeBesinKategoriSec.DisplayMember = "CategoryName";
            cmbKategoriEkleKategoriSec.DisplayMember = "CategoryName";
            cmbKaloriVeBesinKategoriSec.ValueMember = "CategoryID";
            cmbKategoriEkleKategoriSec.ValueMember = "CategoryID";

            //cmbKaloriVeBesinBesinSec.SelectedValue = SelectedCategory;
            cmbKaloriVeBesinKategoriSec.SelectedValue = SelectedCategory;
            cmbKategoriEkleKategoriSec.SelectedValue = SelectedCategory;
        }

        private void cmbKaloriVeBesinKategoriSec_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbKaloriVeBesinKategoriSec.Items.Count; i++)
            {
                if (cmbKaloriVeBesinKategoriSec.SelectedIndex == i)
                    CmbFill(i + 1);
            }
            if (cmbKaloriVeBesinKategoriSec.SelectedIndex>-1)
            {
                cmbKaloriVeBesinBesinSec.Enabled = true;
            }
        }
        void CmbFill(int x,int FoodID=0)
        {
            List<Food> foods = db.Yemekler.Where(w => w.CategoryID == x).ToList();
            //foreach (Food item in foods)
            //{
            //    cmbKaloriVeBesinBesinSec.Items.Add(item.FoodName);
            //}

            cmbKaloriVeBesinBesinSec.DataSource = foods;
            cmbKaloriVeBesinBesinSec.DisplayMember = "FoodName";
            cmbKaloriVeBesinBesinSec.ValueMember = "FoodID";
            cmbKaloriVeBesinBesinSec.SelectedValue = FoodID;
        }

        private void btnKaloriVeBesinGoster_Click(object sender, EventArgs e)
        {
            if (cmbKaloriVeBesinBesinSec.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Kategori ve yemek kısımlarını seçiniz");
            }
            else
                Show();
            //temizle
        }

        private void Show(int CategoryId=0)
        {
            int secilenBesin = int.Parse(cmbKaloriVeBesinBesinSec.SelectedValue.ToString());
            string Path = db.Yemekler.Where(x => x.FoodID == secilenBesin).FirstOrDefault().PhotoPath;
            if (Path != string.Empty)
            {
                try
                {
                    pbKaloriVeBesinResim.Image = null;
                    pbKaloriVeBesinResim.Image = Image.FromFile(Path);
                }
                catch
                {

                }
                finally
                {
                    var foodCalories = db.Yemekler.Where(w => w.FoodName == cmbKaloriVeBesinBesinSec.Text).Select(x => new { x.FoodName, x.Calories }).ToList();
                    dgvYemekKalori.DataSource = foodCalories;
                }
            }
            else
            {
                var foodCalories = db.Yemekler.Where(w => w.FoodName == cmbKaloriVeBesinBesinSec.Text).Select(x => new { x.FoodName, x.Calories }).ToList();
                dgvYemekKalori.DataSource = foodCalories;
            }
        }

        private void btnKategoriEkleEkle_Click(object sender, EventArgs e)
        {
            if (txtAddFood.Text.Trim()!=""&&cmbKategoriEkleKategoriSec.SelectedIndex!=-1)
            {
                int selectedCategory = int.Parse(cmbKategoriEkleKategoriSec.SelectedValue.ToString());
                Food food = db.Yemekler.Where(x => x.FoodID == selectedCategory).FirstOrDefault();
                food = new Food()
                {
                    CategoryID = cmbKategoriEkleKategoriSec.SelectedIndex + 1,
                    FoodName = txtAddFood.Text,
                    Calories = (int)numAddCalories.Value,
                    PhotoPath = lbl1.Text,
                    Photo = bytes,
                    IsActive = true
                };

                db.Yemekler.Add(food);
                db.SaveChanges();
                int id = food.FoodID;
                MessageBox.Show("Ekleme işlemi başarılı!");
                pbOnizleme.Image = null;
                int SelectedCategory = int.Parse(cmbKategoriEkleKategoriSec.SelectedValue.ToString());
                FillKaloriBesin(SelectedCategory);
                CmbFill(SelectedCategory,id);
                Show(SelectedCategory);
                //temizle
            }
            else
                MessageBox.Show("Yemek adını boş geçmeyiniz!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Text=SaveImage(pbOnizleme, txtResimYolu.Text);
            bytes = ImageToByteArray(pbOnizleme.Image);
        }
        public static string SaveImage(PictureBox pictureBox, string firstName)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.bmp; *.png; *.jpg)| *.bmp; *.png; *.jpg";
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
                if (imageIn!=null)
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
                else
                {
                    return null;
                }
            }
        }

        public Image ByteArrayToImage(byte[] bytesArr)
        {
            using (var ms = new MemoryStream(bytesArr))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnKategoriEkleSil_Click(object sender, EventArgs e)
        {
            //TEMİZLE
        }

        private void grbKategoriEkle_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
