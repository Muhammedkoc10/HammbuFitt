
namespace UI.Forms
{
    partial class Ogun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogun));
            this.grbOgunEkle = new System.Windows.Forms.GroupBox();
            this.btnOgunEkle = new System.Windows.Forms.Button();
            this.dgvKategorıYemekOgun = new System.Windows.Forms.DataGridView();
            this.cmbOgunOgunSec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOgunYemekSec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOgunKategoriSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbOgunRapor = new System.Windows.Forms.GroupBox();
            this.btnAylikKaloriOrtalamasi = new System.Windows.Forms.Button();
            this.btnGunlukOgunlerBilgisi = new System.Windows.Forms.Button();
            this.dgvHaftalikVeAylikKalori = new System.Windows.Forms.DataGridView();
            this.dgvGunlukOgunler = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOgunGeriDon = new System.Windows.Forms.Button();
            this.grbOgunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorıYemekOgun)).BeginInit();
            this.grbOgunRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaftalikVeAylikKalori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunlukOgunler)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOgunEkle
            // 
            this.grbOgunEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbOgunEkle.Controls.Add(this.btnOgunEkle);
            this.grbOgunEkle.Controls.Add(this.dgvKategorıYemekOgun);
            this.grbOgunEkle.Controls.Add(this.cmbOgunOgunSec);
            this.grbOgunEkle.Controls.Add(this.label3);
            this.grbOgunEkle.Controls.Add(this.cmbOgunYemekSec);
            this.grbOgunEkle.Controls.Add(this.label2);
            this.grbOgunEkle.Controls.Add(this.cmbOgunKategoriSec);
            this.grbOgunEkle.Controls.Add(this.label1);
            this.grbOgunEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOgunEkle.Location = new System.Drawing.Point(12, 12);
            this.grbOgunEkle.Name = "grbOgunEkle";
            this.grbOgunEkle.Size = new System.Drawing.Size(358, 350);
            this.grbOgunEkle.TabIndex = 0;
            this.grbOgunEkle.TabStop = false;
            this.grbOgunEkle.Text = "Öğün Ekleme";
            // 
            // btnOgunEkle
            // 
            this.btnOgunEkle.BackColor = System.Drawing.Color.Lime;
            this.btnOgunEkle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgunEkle.Location = new System.Drawing.Point(191, 293);
            this.btnOgunEkle.Name = "btnOgunEkle";
            this.btnOgunEkle.Size = new System.Drawing.Size(161, 42);
            this.btnOgunEkle.TabIndex = 11;
            this.btnOgunEkle.Text = "ÖĞÜN EKLE";
            this.btnOgunEkle.UseVisualStyleBackColor = false;
            // 
            // dgvKategorıYemekOgun
            // 
            this.dgvKategorıYemekOgun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorıYemekOgun.Location = new System.Drawing.Point(6, 112);
            this.dgvKategorıYemekOgun.Name = "dgvKategorıYemekOgun";
            this.dgvKategorıYemekOgun.Size = new System.Drawing.Size(346, 164);
            this.dgvKategorıYemekOgun.TabIndex = 10;
            // 
            // cmbOgunOgunSec
            // 
            this.cmbOgunOgunSec.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOgunOgunSec.FormattingEnabled = true;
            this.cmbOgunOgunSec.Location = new System.Drawing.Point(139, 81);
            this.cmbOgunOgunSec.Name = "cmbOgunOgunSec";
            this.cmbOgunOgunSec.Size = new System.Drawing.Size(213, 25);
            this.cmbOgunOgunSec.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Öğün Seç:";
            // 
            // cmbOgunYemekSec
            // 
            this.cmbOgunYemekSec.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOgunYemekSec.FormattingEnabled = true;
            this.cmbOgunYemekSec.Location = new System.Drawing.Point(139, 50);
            this.cmbOgunYemekSec.Name = "cmbOgunYemekSec";
            this.cmbOgunYemekSec.Size = new System.Drawing.Size(213, 25);
            this.cmbOgunYemekSec.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yemek Seç:";
            // 
            // cmbOgunKategoriSec
            // 
            this.cmbOgunKategoriSec.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOgunKategoriSec.FormattingEnabled = true;
            this.cmbOgunKategoriSec.Location = new System.Drawing.Point(139, 19);
            this.cmbOgunKategoriSec.Name = "cmbOgunKategoriSec";
            this.cmbOgunKategoriSec.Size = new System.Drawing.Size(213, 25);
            this.cmbOgunKategoriSec.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori Seç:";
            // 
            // grbOgunRapor
            // 
            this.grbOgunRapor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbOgunRapor.Controls.Add(this.btnAylikKaloriOrtalamasi);
            this.grbOgunRapor.Controls.Add(this.btnGunlukOgunlerBilgisi);
            this.grbOgunRapor.Controls.Add(this.dgvHaftalikVeAylikKalori);
            this.grbOgunRapor.Controls.Add(this.dgvGunlukOgunler);
            this.grbOgunRapor.Controls.Add(this.label4);
            this.grbOgunRapor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOgunRapor.Location = new System.Drawing.Point(376, 12);
            this.grbOgunRapor.Name = "grbOgunRapor";
            this.grbOgunRapor.Size = new System.Drawing.Size(554, 350);
            this.grbOgunRapor.TabIndex = 1;
            this.grbOgunRapor.TabStop = false;
            this.grbOgunRapor.Text = "Öğün Raporu";
            // 
            // btnAylikKaloriOrtalamasi
            // 
            this.btnAylikKaloriOrtalamasi.BackColor = System.Drawing.Color.DarkRed;
            this.btnAylikKaloriOrtalamasi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAylikKaloriOrtalamasi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAylikKaloriOrtalamasi.Location = new System.Drawing.Point(357, 280);
            this.btnAylikKaloriOrtalamasi.Name = "btnAylikKaloriOrtalamasi";
            this.btnAylikKaloriOrtalamasi.Size = new System.Drawing.Size(161, 55);
            this.btnAylikKaloriOrtalamasi.TabIndex = 13;
            this.btnAylikKaloriOrtalamasi.Text = "AYLIK KALORİ ORTALAMASI";
            this.btnAylikKaloriOrtalamasi.UseVisualStyleBackColor = false;
            // 
            // btnGunlukOgunlerBilgisi
            // 
            this.btnGunlukOgunlerBilgisi.BackColor = System.Drawing.Color.DarkRed;
            this.btnGunlukOgunlerBilgisi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGunlukOgunlerBilgisi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGunlukOgunlerBilgisi.Location = new System.Drawing.Point(67, 280);
            this.btnGunlukOgunlerBilgisi.Name = "btnGunlukOgunlerBilgisi";
            this.btnGunlukOgunlerBilgisi.Size = new System.Drawing.Size(161, 55);
            this.btnGunlukOgunlerBilgisi.TabIndex = 12;
            this.btnGunlukOgunlerBilgisi.Text = "GÜNLÜK ÖĞÜNLER BİLGİSİ";
            this.btnGunlukOgunlerBilgisi.UseVisualStyleBackColor = false;
            // 
            // dgvHaftalikVeAylikKalori
            // 
            this.dgvHaftalikVeAylikKalori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHaftalikVeAylikKalori.Location = new System.Drawing.Point(319, 45);
            this.dgvHaftalikVeAylikKalori.Name = "dgvHaftalikVeAylikKalori";
            this.dgvHaftalikVeAylikKalori.Size = new System.Drawing.Size(229, 231);
            this.dgvHaftalikVeAylikKalori.TabIndex = 7;
            // 
            // dgvGunlukOgunler
            // 
            this.dgvGunlukOgunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGunlukOgunler.Location = new System.Drawing.Point(7, 45);
            this.dgvGunlukOgunler.Name = "dgvGunlukOgunler";
            this.dgvGunlukOgunler.Size = new System.Drawing.Size(306, 231);
            this.dgvGunlukOgunler.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Günlük Öğünler";
            // 
            // btnOgunGeriDon
            // 
            this.btnOgunGeriDon.BackColor = System.Drawing.Color.Pink;
            this.btnOgunGeriDon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgunGeriDon.Location = new System.Drawing.Point(799, 368);
            this.btnOgunGeriDon.Name = "btnOgunGeriDon";
            this.btnOgunGeriDon.Size = new System.Drawing.Size(131, 42);
            this.btnOgunGeriDon.TabIndex = 29;
            this.btnOgunGeriDon.Text = "GERİ DÖN";
            this.btnOgunGeriDon.UseVisualStyleBackColor = false;
            this.btnOgunGeriDon.Click += new System.EventHandler(this.btnOgunGeriDon_Click);
            // 
            // Ogun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(942, 422);
            this.Controls.Add(this.btnOgunGeriDon);
            this.Controls.Add(this.grbOgunRapor);
            this.Controls.Add(this.grbOgunEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ogun";
            this.Text = "Ogun";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ogun_FormClosed);
            this.grbOgunEkle.ResumeLayout(false);
            this.grbOgunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorıYemekOgun)).EndInit();
            this.grbOgunRapor.ResumeLayout(false);
            this.grbOgunRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaftalikVeAylikKalori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunlukOgunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOgunEkle;
        private System.Windows.Forms.GroupBox grbOgunRapor;
        private System.Windows.Forms.DataGridView dgvKategorıYemekOgun;
        private System.Windows.Forms.ComboBox cmbOgunOgunSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOgunYemekSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOgunKategoriSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgunEkle;
        private System.Windows.Forms.Button btnAylikKaloriOrtalamasi;
        private System.Windows.Forms.Button btnGunlukOgunlerBilgisi;
        private System.Windows.Forms.DataGridView dgvHaftalikVeAylikKalori;
        private System.Windows.Forms.DataGridView dgvGunlukOgunler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOgunGeriDon;
    }
}