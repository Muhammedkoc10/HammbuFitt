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
    public partial class FoodsAndCalories : Form
    {
        public FoodsAndCalories(string datas)
        {
            InitializeComponent();
            lblHold.Text = datas;
        }
        Context db;
        byte[] bytes = null;
        private void FoodsAndCalories_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(lblHold.Text);
            this.Hide();
            mainPage.Show();
        }

        private void FoodsAndCalories_Load(object sender, EventArgs e)
        {
            FillFoodsCalories();
            cmbFoodSelect.Enabled = false;
        }

        private void FillFoodsCalories(int SelectedCategory = -1)
        {
            db = new Context();
            List<Category> categories1 = db.Categories.ToList();
            List<Category> categories2 = db.Categories.ToList();
            cmbSelectCategory.DataSource = categories1;
            cmbCategoryAdd.DataSource = categories2;
            cmbSelectCategory.DisplayMember = "CategoryName";
            cmbCategoryAdd.DisplayMember = "CategoryName";
            cmbSelectCategory.ValueMember = "CategoryID";
            cmbCategoryAdd.ValueMember = "CategoryID";

            cmbSelectCategory.SelectedValue = SelectedCategory;
            cmbCategoryAdd.SelectedValue = SelectedCategory;
        }

        private void cmbSelectCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbSelectCategory.Items.Count; i++)
            {
                if (cmbSelectCategory.SelectedIndex == i)
                    CmbFill(i + 1);
            }
            if (cmbSelectCategory.SelectedIndex > -1)
            {
                cmbFoodSelect.Enabled = true;
            }
        }
        void CmbFill(int x, int FoodID = 0)
        {
            List<Food> foods = db.Foods.Where(w => w.CategoryID == x).ToList();
            cmbFoodSelect.DataSource = foods;
            cmbFoodSelect.DisplayMember = "FoodName";
            cmbFoodSelect.ValueMember = "FoodID";
            cmbFoodSelect.SelectedValue = FoodID;
        }

        private void btnShowFoodsAndCalories_Click(object sender, EventArgs e)
        {
            if (cmbFoodSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Kategori ve yemek kısımlarını seçiniz");
            }
            else
                Show();
            cmbSelectCategory.SelectedValue = -1;
            cmbFoodSelect.SelectedValue = -1;
        }

        private void Show(int CategoryId = 0)
        {
            int selectedFood = int.Parse(cmbFoodSelect.SelectedValue.ToString());
            string Path = db.Foods.Where(x => x.FoodID == selectedFood).FirstOrDefault().PhotoPath;
            if (Path != string.Empty)
            {
                try
                {
                    pbFoodsCalories.Image = null;
                    pbFoodsCalories.Image = Image.FromFile(Path);
                }
                catch
                {

                }
                finally
                {
                    var foodCalories = db.Foods.Where(w => w.FoodName == cmbFoodSelect.Text).Select(x => new { x.FoodName, x.Calories }).ToList();
                    dgvFoodCalories.DataSource = foodCalories;
                }
            }
            else
            {
                var foodCalories = db.Foods.Where(w => w.FoodName == cmbFoodSelect.Text).Select(x => new { x.FoodName, x.Calories }).ToList();
                dgvFoodCalories.DataSource = foodCalories;
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (txtAddFood.Text.Trim() != "" && cmbCategoryAdd.SelectedIndex != -1)
            {
                int selectedCategory = int.Parse(cmbCategoryAdd.SelectedValue.ToString());
                Food food = db.Foods.Where(x => x.FoodID == selectedCategory).FirstOrDefault();
                food = new Food()
                {
                    CategoryID = cmbCategoryAdd.SelectedIndex + 1,
                    FoodName = txtAddFood.Text,
                    Calories = (int)numAddCalories.Value,
                    PhotoPath = lbl1.Text,
                    Photo = bytes,
                    IsActive = true
                };

                db.Foods.Add(food);
                db.SaveChanges();
                if (food.PhotoPath == null)
                    pbFoodsCalories.Image = null;

                int id = food.FoodID;
                MessageBox.Show("Ekleme işlemi başarılı!");
                pbPreview.Image = null;
                int SelectedCategory = int.Parse(cmbCategoryAdd.SelectedValue.ToString());
                FillFoodsCalories(SelectedCategory);
                CmbFill(SelectedCategory, id);
                Show(SelectedCategory);
                Methods.Clear(grpAddFoods);
                MessageBox.Show("Yanlış kalori bilgisi ve uygunsuz foto girişi yapıldıysa yemek-kalori bilginiz kaldırılabilir!");
            }
            else
                MessageBox.Show("Yemek adını boş geçmeyiniz!");
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            lbl1.Text = SaveImage(pbPreview, txtPhotoPath.Text);
            bytes = ImageToByteArray(pbPreview.Image);
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
                if (imageIn != null)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Methods.Clear(grpAddFoods);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
