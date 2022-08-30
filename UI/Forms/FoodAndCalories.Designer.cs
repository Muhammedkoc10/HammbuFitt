
namespace UI.Forms
{
    partial class FoodsAndCalories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodsAndCalories));
            this.grpFoodCaloriesSelect = new System.Windows.Forms.GroupBox();
            this.dgvFoodCalories = new System.Windows.Forms.DataGridView();
            this.btnShowFoodsAndCalories = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbFoodSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFoodsCalories = new System.Windows.Forms.PictureBox();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.grpAddFoods = new System.Windows.Forms.GroupBox();
            this.txtPhotoPath = new System.Windows.Forms.TextBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numAddCalories = new System.Windows.Forms.NumericUpDown();
            this.txtAddFood = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoryAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbTutulan = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblHold = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.grpFoodCaloriesSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodsCalories)).BeginInit();
            this.grpAddFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutulan)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFoodCaloriesSelect
            // 
            this.grpFoodCaloriesSelect.BackColor = System.Drawing.Color.Transparent;
            this.grpFoodCaloriesSelect.Controls.Add(this.dgvFoodCalories);
            this.grpFoodCaloriesSelect.Controls.Add(this.btnShowFoodsAndCalories);
            this.grpFoodCaloriesSelect.Controls.Add(this.cmbFoodSelect);
            this.grpFoodCaloriesSelect.Controls.Add(this.label2);
            this.grpFoodCaloriesSelect.Controls.Add(this.cmbSelectCategory);
            this.grpFoodCaloriesSelect.Controls.Add(this.label1);
            this.grpFoodCaloriesSelect.Controls.Add(this.pbFoodsCalories);
            this.grpFoodCaloriesSelect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFoodCaloriesSelect.Location = new System.Drawing.Point(35, 43);
            this.grpFoodCaloriesSelect.Name = "grpFoodCaloriesSelect";
            this.grpFoodCaloriesSelect.Size = new System.Drawing.Size(301, 367);
            this.grpFoodCaloriesSelect.TabIndex = 0;
            this.grpFoodCaloriesSelect.TabStop = false;
            this.grpFoodCaloriesSelect.Text = "Kalori ve Besin";
            // 
            // dgvFoodCalories
            // 
            this.dgvFoodCalories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodCalories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvFoodCalories.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFoodCalories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodCalories.Location = new System.Drawing.Point(6, 129);
            this.dgvFoodCalories.Name = "dgvFoodCalories";
            this.dgvFoodCalories.ReadOnly = true;
            this.dgvFoodCalories.Size = new System.Drawing.Size(284, 59);
            this.dgvFoodCalories.TabIndex = 7;
            // 
            // btnShowFoodsAndCalories
            // 
            this.btnShowFoodsAndCalories.BackColor = System.Drawing.Color.Transparent;
            this.btnShowFoodsAndCalories.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFoodsAndCalories.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowFoodsAndCalories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowFoodsAndCalories.ImageKey = "indir.png";
            this.btnShowFoodsAndCalories.ImageList = this.ımageList1;
            this.btnShowFoodsAndCalories.Location = new System.Drawing.Point(84, 307);
            this.btnShowFoodsAndCalories.Name = "btnShowFoodsAndCalories";
            this.btnShowFoodsAndCalories.Size = new System.Drawing.Size(131, 42);
            this.btnShowFoodsAndCalories.TabIndex = 3;
            this.btnShowFoodsAndCalories.Text = "GÖSTER";
            this.btnShowFoodsAndCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowFoodsAndCalories.UseVisualStyleBackColor = false;
            this.btnShowFoodsAndCalories.Click += new System.EventHandler(this.btnShowFoodsAndCalories_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "310679.png");
            this.ımageList1.Images.SetKeyName(1, "60577.png");
            this.ımageList1.Images.SetKeyName(2, "cross.png");
            this.ımageList1.Images.SetKeyName(3, "signup-icon-11.jpg");
            this.ımageList1.Images.SetKeyName(4, "icon-add-0.jpg");
            this.ımageList1.Images.SetKeyName(5, "310679.png");
            this.ımageList1.Images.SetKeyName(6, "two_towers_4k_eye_of_sauron.jpg");
            this.ımageList1.Images.SetKeyName(7, "indir.png");
            // 
            // cmbFoodSelect
            // 
            this.cmbFoodSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoodSelect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFoodSelect.FormattingEnabled = true;
            this.cmbFoodSelect.Location = new System.Drawing.Point(113, 249);
            this.cmbFoodSelect.Name = "cmbFoodSelect";
            this.cmbFoodSelect.Size = new System.Drawing.Size(168, 25);
            this.cmbFoodSelect.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Besin Seç:";
            // 
            // cmbSelectCategory
            // 
            this.cmbSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCategory.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectCategory.FormattingEnabled = true;
            this.cmbSelectCategory.Location = new System.Drawing.Point(113, 205);
            this.cmbSelectCategory.Name = "cmbSelectCategory";
            this.cmbSelectCategory.Size = new System.Drawing.Size(168, 25);
            this.cmbSelectCategory.TabIndex = 1;
            this.cmbSelectCategory.SelectedValueChanged += new System.EventHandler(this.cmbSelectCategory_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Seç:";
            // 
            // pbFoodsCalories
            // 
            this.pbFoodsCalories.Location = new System.Drawing.Point(6, 19);
            this.pbFoodsCalories.Name = "pbFoodsCalories";
            this.pbFoodsCalories.Size = new System.Drawing.Size(284, 104);
            this.pbFoodsCalories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodsCalories.TabIndex = 0;
            this.pbFoodsCalories.TabStop = false;
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToMainPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToMainPage.ImageIndex = 1;
            this.btnBackToMainPage.ImageList = this.ımageList1;
            this.btnBackToMainPage.Location = new System.Drawing.Point(119, 429);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(131, 42);
            this.btnBackToMainPage.TabIndex = 11;
            this.btnBackToMainPage.Text = "GERİ DÖN";
            this.btnBackToMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackToMainPage.UseVisualStyleBackColor = false;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // grpAddFoods
            // 
            this.grpAddFoods.BackColor = System.Drawing.Color.Transparent;
            this.grpAddFoods.Controls.Add(this.txtPhotoPath);
            this.grpAddFoods.Controls.Add(this.btnAddFood);
            this.grpAddFoods.Controls.Add(this.btnSelectPhoto);
            this.grpAddFoods.Controls.Add(this.label7);
            this.grpAddFoods.Controls.Add(this.numAddCalories);
            this.grpAddFoods.Controls.Add(this.txtAddFood);
            this.grpAddFoods.Controls.Add(this.btnClear);
            this.grpAddFoods.Controls.Add(this.label6);
            this.grpAddFoods.Controls.Add(this.label5);
            this.grpAddFoods.Controls.Add(this.cmbCategoryAdd);
            this.grpAddFoods.Controls.Add(this.label4);
            this.grpAddFoods.Controls.Add(this.label3);
            this.grpAddFoods.Controls.Add(this.pbPreview);
            this.grpAddFoods.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddFoods.Location = new System.Drawing.Point(355, 43);
            this.grpAddFoods.Name = "grpAddFoods";
            this.grpAddFoods.Size = new System.Drawing.Size(325, 428);
            this.grpAddFoods.TabIndex = 2;
            this.grpAddFoods.TabStop = false;
            this.grpAddFoods.Text = "Kategoriye Ekleme";
            // 
            // txtPhotoPath
            // 
            this.txtPhotoPath.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhotoPath.Location = new System.Drawing.Point(151, 280);
            this.txtPhotoPath.Name = "txtPhotoPath";
            this.txtPhotoPath.Size = new System.Drawing.Size(168, 25);
            this.txtPhotoPath.TabIndex = 7;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.ImageKey = "icon-add-0.jpg";
            this.btnAddFood.ImageList = this.ımageList1;
            this.btnAddFood.Location = new System.Drawing.Point(218, 368);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(101, 42);
            this.btnAddFood.TabIndex = 9;
            this.btnAddFood.Text = "EKLE";
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectPhoto.ImageIndex = 3;
            this.btnSelectPhoto.ImageList = this.ımageList1;
            this.btnSelectPhoto.Location = new System.Drawing.Point(218, 312);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(101, 37);
            this.btnSelectPhoto.TabIndex = 8;
            this.btnSelectPhoto.Text = "RESİM SEÇ";
            this.btnSelectPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Resim Önizleme";
            // 
            // numAddCalories
            // 
            this.numAddCalories.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddCalories.Location = new System.Drawing.Point(151, 235);
            this.numAddCalories.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAddCalories.Name = "numAddCalories";
            this.numAddCalories.Size = new System.Drawing.Size(168, 25);
            this.numAddCalories.TabIndex = 6;
            // 
            // txtAddFood
            // 
            this.txtAddFood.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddFood.Location = new System.Drawing.Point(151, 187);
            this.txtAddFood.Name = "txtAddFood";
            this.txtAddFood.Size = new System.Drawing.Size(168, 25);
            this.txtAddFood.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.ImageKey = "310679.png";
            this.btnClear.ImageList = this.ımageList1;
            this.btnClear.Location = new System.Drawing.Point(33, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 42);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "TEMİZLE";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Resim Yolu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kalori / 100 Gram:";
            // 
            // cmbCategoryAdd
            // 
            this.cmbCategoryAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryAdd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryAdd.FormattingEnabled = true;
            this.cmbCategoryAdd.Location = new System.Drawing.Point(151, 138);
            this.cmbCategoryAdd.Name = "cmbCategoryAdd";
            this.cmbCategoryAdd.Size = new System.Drawing.Size(168, 25);
            this.cmbCategoryAdd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Eklenecek Besin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori Seç:";
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(6, 19);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(313, 104);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(857, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 8;
            // 
            // pbTutulan
            // 
            this.pbTutulan.Location = new System.Drawing.Point(45, 652);
            this.pbTutulan.Name = "pbTutulan";
            this.pbTutulan.Size = new System.Drawing.Size(100, 50);
            this.pbTutulan.TabIndex = 30;
            this.pbTutulan.TabStop = false;
            this.pbTutulan.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(301, 689);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 31;
            this.lbl1.Text = "label8";
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(210, 678);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 32;
            this.lbl2.Text = "label8";
            this.lbl2.Visible = false;
            // 
            // lblHold
            // 
            this.lblHold.AutoSize = true;
            this.lblHold.Location = new System.Drawing.Point(222, 427);
            this.lblHold.Name = "lblHold";
            this.lblHold.Size = new System.Drawing.Size(0, 13);
            this.lblHold.TabIndex = 33;
            this.lblHold.Visible = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ImageIndex = 2;
            this.btnCloseApp.ImageList = this.ımageList1;
            this.btnCloseApp.Location = new System.Drawing.Point(689, -1);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(36, 36);
            this.btnCloseApp.TabIndex = 34;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // FoodsAndCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 494);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.lblHold);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.pbTutulan);
            this.Controls.Add(this.grpAddFoods);
            this.Controls.Add(this.grpFoodCaloriesSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodsAndCalories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemek Ve Kalori";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FoodsAndCalories_FormClosed);
            this.Load += new System.EventHandler(this.FoodsAndCalories_Load);
            this.grpFoodCaloriesSelect.ResumeLayout(false);
            this.grpFoodCaloriesSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodsCalories)).EndInit();
            this.grpAddFoods.ResumeLayout(false);
            this.grpAddFoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutulan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFoodCaloriesSelect;
        private System.Windows.Forms.PictureBox pbFoodsCalories;
        private System.Windows.Forms.GroupBox grpAddFoods;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddFood;
        private System.Windows.Forms.NumericUpDown numAddCalories;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvFoodCalories;
        private System.Windows.Forms.PictureBox pbTutulan;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        public System.Windows.Forms.ComboBox cmbFoodSelect;
        public System.Windows.Forms.Button btnShowFoodsAndCalories;
        public System.Windows.Forms.ComboBox cmbCategoryAdd;
        internal System.Windows.Forms.ComboBox cmbSelectCategory;
        private System.Windows.Forms.Label lblHold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.TextBox txtPhotoPath;
        private System.Windows.Forms.Label label6;
    }
}