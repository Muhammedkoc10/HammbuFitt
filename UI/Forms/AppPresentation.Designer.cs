
namespace UI.Forms
{
    partial class AppPresentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppPresentation));
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.pbYemekEkleme = new System.Windows.Forms.PictureBox();
            this.pbSaglikliYiyecekler = new System.Windows.Forms.PictureBox();
            this.pbKaloriVeYemekEkleme = new System.Windows.Forms.PictureBox();
            this.pbSporcuVeGunluk = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbYemekEkleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaglikliYiyecekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKaloriVeYemekEkleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSporcuVeGunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToMainPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToMainPage.ImageIndex = 1;
            this.btnBackToMainPage.ImageList = this.ımageList1;
            this.btnBackToMainPage.Location = new System.Drawing.Point(342, 493);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(131, 42);
            this.btnBackToMainPage.TabIndex = 1;
            this.btnBackToMainPage.Text = "GERİ DÖN";
            this.btnBackToMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackToMainPage.UseVisualStyleBackColor = false;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cross.png");
            this.ımageList1.Images.SetKeyName(1, "60577.png");
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ImageIndex = 0;
            this.btnCloseApp.ImageList = this.ımageList1;
            this.btnCloseApp.Location = new System.Drawing.Point(743, 0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(36, 36);
            this.btnCloseApp.TabIndex = 28;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // pbYemekEkleme
            // 
            this.pbYemekEkleme.Image = ((System.Drawing.Image)(resources.GetObject("pbYemekEkleme.Image")));
            this.pbYemekEkleme.Location = new System.Drawing.Point(56, 259);
            this.pbYemekEkleme.Name = "pbYemekEkleme";
            this.pbYemekEkleme.Size = new System.Drawing.Size(276, 144);
            this.pbYemekEkleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYemekEkleme.TabIndex = 1;
            this.pbYemekEkleme.TabStop = false;
            // 
            // pbSaglikliYiyecekler
            // 
            this.pbSaglikliYiyecekler.Image = ((System.Drawing.Image)(resources.GetObject("pbSaglikliYiyecekler.Image")));
            this.pbSaglikliYiyecekler.Location = new System.Drawing.Point(419, 259);
            this.pbSaglikliYiyecekler.Name = "pbSaglikliYiyecekler";
            this.pbSaglikliYiyecekler.Size = new System.Drawing.Size(276, 144);
            this.pbSaglikliYiyecekler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSaglikliYiyecekler.TabIndex = 2;
            this.pbSaglikliYiyecekler.TabStop = false;
            // 
            // pbKaloriVeYemekEkleme
            // 
            this.pbKaloriVeYemekEkleme.Image = ((System.Drawing.Image)(resources.GetObject("pbKaloriVeYemekEkleme.Image")));
            this.pbKaloriVeYemekEkleme.Location = new System.Drawing.Point(419, 50);
            this.pbKaloriVeYemekEkleme.Name = "pbKaloriVeYemekEkleme";
            this.pbKaloriVeYemekEkleme.Size = new System.Drawing.Size(276, 144);
            this.pbKaloriVeYemekEkleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKaloriVeYemekEkleme.TabIndex = 3;
            this.pbKaloriVeYemekEkleme.TabStop = false;
            // 
            // pbSporcuVeGunluk
            // 
            this.pbSporcuVeGunluk.Image = ((System.Drawing.Image)(resources.GetObject("pbSporcuVeGunluk.Image")));
            this.pbSporcuVeGunluk.Location = new System.Drawing.Point(56, 50);
            this.pbSporcuVeGunluk.Name = "pbSporcuVeGunluk";
            this.pbSporcuVeGunluk.Size = new System.Drawing.Size(276, 144);
            this.pbSporcuVeGunluk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSporcuVeGunluk.TabIndex = 0;
            this.pbSporcuVeGunluk.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(56, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sporcu ve Günlük Kullanıcılar için farklı diyet önerileri";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(415, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Günlük/Haftalık/Aylık Kalori ve Yemek Takibi";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(415, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 63);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcılarımız ve kullanıcı olan ünlü sporcularımızın en çok tükettiği sağlıklı" +
    " yiyecekler";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(56, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 79);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ana yemeklerin, içeceklerin, atıştırmalıkların kalori takibi ve ekstradan kullanı" +
    "cının yemek ve kalori verilerini ekleyeceği ekran.";
            // 
            // AppPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 547);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSporcuVeGunluk);
            this.Controls.Add(this.pbYemekEkleme);
            this.Controls.Add(this.pbKaloriVeYemekEkleme);
            this.Controls.Add(this.pbSaglikliYiyecekler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppPresentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uygulama Tanıtım";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppPresentation_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbYemekEkleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaglikliYiyecekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKaloriVeYemekEkleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSporcuVeGunluk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.PictureBox pbYemekEkleme;
        private System.Windows.Forms.PictureBox pbSaglikliYiyecekler;
        private System.Windows.Forms.PictureBox pbKaloriVeYemekEkleme;
        private System.Windows.Forms.PictureBox pbSporcuVeGunluk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}