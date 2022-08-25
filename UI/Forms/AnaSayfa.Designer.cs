
namespace UI.Forms
{
    partial class AnaSayfa
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
            this.btnAnaSayfaDiyetListeleri = new System.Windows.Forms.Button();
            this.grbAnaSayfa = new System.Windows.Forms.GroupBox();
            this.btnAnaSayfaGirisEkraninaDon = new System.Windows.Forms.Button();
            this.btnAnaSayfaRaporlar = new System.Windows.Forms.Button();
            this.btnAnaSayfaOgunTakip = new System.Windows.Forms.Button();
            this.btnAnaSayfaYemekKalori = new System.Windows.Forms.Button();
            this.lblHold2 = new System.Windows.Forms.Label();
            this.grbAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnaSayfaDiyetListeleri
            // 
            this.btnAnaSayfaDiyetListeleri.BackColor = System.Drawing.Color.Magenta;
            this.btnAnaSayfaDiyetListeleri.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaSayfaDiyetListeleri.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnaSayfaDiyetListeleri.Location = new System.Drawing.Point(42, 21);
            this.btnAnaSayfaDiyetListeleri.Name = "btnAnaSayfaDiyetListeleri";
            this.btnAnaSayfaDiyetListeleri.Size = new System.Drawing.Size(173, 42);
            this.btnAnaSayfaDiyetListeleri.TabIndex = 7;
            this.btnAnaSayfaDiyetListeleri.Text = "DİYET LİSTELERİ";
            this.btnAnaSayfaDiyetListeleri.UseVisualStyleBackColor = false;
            this.btnAnaSayfaDiyetListeleri.Click += new System.EventHandler(this.btnAnaSayfaDiyetListeleri_Click);
            // 
            // grbAnaSayfa
            // 
            this.grbAnaSayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbAnaSayfa.Controls.Add(this.btnAnaSayfaGirisEkraninaDon);
            this.grbAnaSayfa.Controls.Add(this.btnAnaSayfaRaporlar);
            this.grbAnaSayfa.Controls.Add(this.btnAnaSayfaOgunTakip);
            this.grbAnaSayfa.Controls.Add(this.btnAnaSayfaYemekKalori);
            this.grbAnaSayfa.Controls.Add(this.btnAnaSayfaDiyetListeleri);
            this.grbAnaSayfa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAnaSayfa.Location = new System.Drawing.Point(8, 20);
            this.grbAnaSayfa.Name = "grbAnaSayfa";
            this.grbAnaSayfa.Size = new System.Drawing.Size(274, 325);
            this.grbAnaSayfa.TabIndex = 8;
            this.grbAnaSayfa.TabStop = false;
            this.grbAnaSayfa.Text = "Ana Sayfa";
            // 
            // btnAnaSayfaGirisEkraninaDon
            // 
            this.btnAnaSayfaGirisEkraninaDon.BackColor = System.Drawing.Color.Pink;
            this.btnAnaSayfaGirisEkraninaDon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaSayfaGirisEkraninaDon.Location = new System.Drawing.Point(19, 278);
            this.btnAnaSayfaGirisEkraninaDon.Name = "btnAnaSayfaGirisEkraninaDon";
            this.btnAnaSayfaGirisEkraninaDon.Size = new System.Drawing.Size(218, 42);
            this.btnAnaSayfaGirisEkraninaDon.TabIndex = 27;
            this.btnAnaSayfaGirisEkraninaDon.Text = "GİRİŞ SAYFAYA DÖN";
            this.btnAnaSayfaGirisEkraninaDon.UseVisualStyleBackColor = false;
            this.btnAnaSayfaGirisEkraninaDon.Click += new System.EventHandler(this.btnAnaSayfaGirisEkraninaDon_Click);
            // 
            // btnAnaSayfaRaporlar
            // 
            this.btnAnaSayfaRaporlar.BackColor = System.Drawing.Color.Magenta;
            this.btnAnaSayfaRaporlar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaSayfaRaporlar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnaSayfaRaporlar.Location = new System.Drawing.Point(42, 221);
            this.btnAnaSayfaRaporlar.Name = "btnAnaSayfaRaporlar";
            this.btnAnaSayfaRaporlar.Size = new System.Drawing.Size(173, 42);
            this.btnAnaSayfaRaporlar.TabIndex = 11;
            this.btnAnaSayfaRaporlar.Text = "RAPORLAR";
            this.btnAnaSayfaRaporlar.UseVisualStyleBackColor = false;
            this.btnAnaSayfaRaporlar.Click += new System.EventHandler(this.btnAnaSayfaRaporlar_Click);
            // 
            // btnAnaSayfaOgunTakip
            // 
            this.btnAnaSayfaOgunTakip.BackColor = System.Drawing.Color.Magenta;
            this.btnAnaSayfaOgunTakip.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaSayfaOgunTakip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnaSayfaOgunTakip.Location = new System.Drawing.Point(42, 159);
            this.btnAnaSayfaOgunTakip.Name = "btnAnaSayfaOgunTakip";
            this.btnAnaSayfaOgunTakip.Size = new System.Drawing.Size(173, 42);
            this.btnAnaSayfaOgunTakip.TabIndex = 10;
            this.btnAnaSayfaOgunTakip.Text = "ÖĞÜN TAKİP";
            this.btnAnaSayfaOgunTakip.UseVisualStyleBackColor = false;
            this.btnAnaSayfaOgunTakip.Click += new System.EventHandler(this.btnAnaSayfaOgunTakip_Click);
            // 
            // btnAnaSayfaYemekKalori
            // 
            this.btnAnaSayfaYemekKalori.BackColor = System.Drawing.Color.Magenta;
            this.btnAnaSayfaYemekKalori.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaSayfaYemekKalori.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnaSayfaYemekKalori.Location = new System.Drawing.Point(42, 86);
            this.btnAnaSayfaYemekKalori.Name = "btnAnaSayfaYemekKalori";
            this.btnAnaSayfaYemekKalori.Size = new System.Drawing.Size(173, 50);
            this.btnAnaSayfaYemekKalori.TabIndex = 9;
            this.btnAnaSayfaYemekKalori.Text = "YEMEK - KALORİ BÖLÜMÜ";
            this.btnAnaSayfaYemekKalori.UseVisualStyleBackColor = false;
            this.btnAnaSayfaYemekKalori.Click += new System.EventHandler(this.btnAnaSayfaYemekKalori_Click);
            // 
            // lblHold2
            // 
            this.lblHold2.AutoSize = true;
            this.lblHold2.Location = new System.Drawing.Point(120, 353);
            this.lblHold2.Name = "lblHold2";
            this.lblHold2.Size = new System.Drawing.Size(0, 13);
            this.lblHold2.TabIndex = 9;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(286, 348);
            this.Controls.Add(this.lblHold2);
            this.Controls.Add(this.grbAnaSayfa);
            this.Name = "AnaSayfa";
            this.Text = "AnaSyfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaSayfa_FormClosed);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.grbAnaSayfa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaSayfaDiyetListeleri;
        private System.Windows.Forms.GroupBox grbAnaSayfa;
        private System.Windows.Forms.Button btnAnaSayfaRaporlar;
        private System.Windows.Forms.Button btnAnaSayfaOgunTakip;
        private System.Windows.Forms.Button btnAnaSayfaYemekKalori;
        private System.Windows.Forms.Button btnAnaSayfaGirisEkraninaDon;
        private System.Windows.Forms.Label lblHold2;
    }
}