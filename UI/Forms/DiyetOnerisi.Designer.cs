
namespace UI.Forms
{
    partial class DiyetOnerisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiyetOnerisi));
            this.grbGunlukKullanici = new System.Windows.Forms.GroupBox();
            this.grbProfesyonelKullanici = new System.Windows.Forms.GroupBox();
            this.btnDiyetOnerisiGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grbGunlukKullanici
            // 
            this.grbGunlukKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grbGunlukKullanici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbGunlukKullanici.BackgroundImage")));
            this.grbGunlukKullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbGunlukKullanici.Location = new System.Drawing.Point(12, 12);
            this.grbGunlukKullanici.Name = "grbGunlukKullanici";
            this.grbGunlukKullanici.Size = new System.Drawing.Size(247, 314);
            this.grbGunlukKullanici.TabIndex = 0;
            this.grbGunlukKullanici.TabStop = false;
            this.grbGunlukKullanici.Text = "Günlük Kullanıcı";
            // 
            // grbProfesyonelKullanici
            // 
            this.grbProfesyonelKullanici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbProfesyonelKullanici.BackgroundImage")));
            this.grbProfesyonelKullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbProfesyonelKullanici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbProfesyonelKullanici.Location = new System.Drawing.Point(265, 12);
            this.grbProfesyonelKullanici.Name = "grbProfesyonelKullanici";
            this.grbProfesyonelKullanici.Size = new System.Drawing.Size(247, 314);
            this.grbProfesyonelKullanici.TabIndex = 1;
            this.grbProfesyonelKullanici.TabStop = false;
            this.grbProfesyonelKullanici.Text = "Profesyonel Kullanıcı";
            // 
            // btnDiyetOnerisiGeriDon
            // 
            this.btnDiyetOnerisiGeriDon.BackColor = System.Drawing.Color.Pink;
            this.btnDiyetOnerisiGeriDon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiyetOnerisiGeriDon.Location = new System.Drawing.Point(381, 332);
            this.btnDiyetOnerisiGeriDon.Name = "btnDiyetOnerisiGeriDon";
            this.btnDiyetOnerisiGeriDon.Size = new System.Drawing.Size(131, 42);
            this.btnDiyetOnerisiGeriDon.TabIndex = 29;
            this.btnDiyetOnerisiGeriDon.Text = "GERİ DÖN";
            this.btnDiyetOnerisiGeriDon.UseVisualStyleBackColor = false;
            this.btnDiyetOnerisiGeriDon.Click += new System.EventHandler(this.btnDiyetOnerisiGeriDon_Click);
            // 
            // DiyetOnerisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(514, 381);
            this.Controls.Add(this.btnDiyetOnerisiGeriDon);
            this.Controls.Add(this.grbProfesyonelKullanici);
            this.Controls.Add(this.grbGunlukKullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiyetOnerisi";
            this.Text = "DiyetOnerisi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DiyetOnerisi_FormClosed);
            this.Load += new System.EventHandler(this.DiyetOnerisi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGunlukKullanici;
        private System.Windows.Forms.GroupBox grbProfesyonelKullanici;
        private System.Windows.Forms.Button btnDiyetOnerisiGeriDon;
    }
}