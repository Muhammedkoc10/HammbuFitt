
namespace UI
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.grbSifremiUnuttum = new System.Windows.Forms.GroupBox();
            this.btnSifremiUnuttumGeriDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifreKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnSifremiHatirlat = new System.Windows.Forms.Button();
            this.txtSifreEmail = new System.Windows.Forms.TextBox();
            this.grbSifremiUnuttum.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSifremiUnuttum
            // 
            this.grbSifremiUnuttum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbSifremiUnuttum.Controls.Add(this.btnSifremiUnuttumGeriDon);
            this.grbSifremiUnuttum.Controls.Add(this.label2);
            this.grbSifremiUnuttum.Controls.Add(this.label1);
            this.grbSifremiUnuttum.Controls.Add(this.txtSifreKullaniciAdi);
            this.grbSifremiUnuttum.Controls.Add(this.btnSifremiHatirlat);
            this.grbSifremiUnuttum.Controls.Add(this.txtSifreEmail);
            this.grbSifremiUnuttum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSifremiUnuttum.Location = new System.Drawing.Point(12, 12);
            this.grbSifremiUnuttum.Name = "grbSifremiUnuttum";
            this.grbSifremiUnuttum.Size = new System.Drawing.Size(310, 273);
            this.grbSifremiUnuttum.TabIndex = 0;
            this.grbSifremiUnuttum.TabStop = false;
            this.grbSifremiUnuttum.Text = "Şifremi Unuttum";
            // 
            // btnSifremiUnuttumGeriDon
            // 
            this.btnSifremiUnuttumGeriDon.BackColor = System.Drawing.Color.Pink;
            this.btnSifremiUnuttumGeriDon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifremiUnuttumGeriDon.Location = new System.Drawing.Point(173, 225);
            this.btnSifremiUnuttumGeriDon.Name = "btnSifremiUnuttumGeriDon";
            this.btnSifremiUnuttumGeriDon.Size = new System.Drawing.Size(131, 42);
            this.btnSifremiUnuttumGeriDon.TabIndex = 28;
            this.btnSifremiUnuttumGeriDon.Text = "GERİ DÖN";
            this.btnSifremiUnuttumGeriDon.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttumGeriDon.Click += new System.EventHandler(this.btnSifremiUnuttumGeriDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtSifreKullaniciAdi
            // 
            this.txtSifreKullaniciAdi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifreKullaniciAdi.Location = new System.Drawing.Point(20, 50);
            this.txtSifreKullaniciAdi.Name = "txtSifreKullaniciAdi";
            this.txtSifreKullaniciAdi.Size = new System.Drawing.Size(287, 25);
            this.txtSifreKullaniciAdi.TabIndex = 8;
            this.txtSifreKullaniciAdi.Tag = "";
            // 
            // btnSifremiHatirlat
            // 
            this.btnSifremiHatirlat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifremiHatirlat.Location = new System.Drawing.Point(76, 158);
            this.btnSifremiHatirlat.Name = "btnSifremiHatirlat";
            this.btnSifremiHatirlat.Size = new System.Drawing.Size(166, 42);
            this.btnSifremiHatirlat.TabIndex = 11;
            this.btnSifremiHatirlat.Text = "ŞİFREMİ HATIRLAT";
            this.btnSifremiHatirlat.UseVisualStyleBackColor = true;
            this.btnSifremiHatirlat.Click += new System.EventHandler(this.btnSifremiHatirlat_Click);
            // 
            // txtSifreEmail
            // 
            this.txtSifreEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifreEmail.Location = new System.Drawing.Point(20, 118);
            this.txtSifreEmail.Name = "txtSifreEmail";
            this.txtSifreEmail.Size = new System.Drawing.Size(287, 25);
            this.txtSifreEmail.TabIndex = 10;
            // 
            // SifremiUnuttum
            // 
            this.AcceptButton = this.btnSifremiHatirlat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(334, 297);
            this.Controls.Add(this.grbSifremiUnuttum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifremiUnuttum";
            this.Text = "Sifremi Unuttum";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SifremiUnuttum_FormClosed);
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            this.grbSifremiUnuttum.ResumeLayout(false);
            this.grbSifremiUnuttum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSifremiUnuttum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifreKullaniciAdi;
        private System.Windows.Forms.Button btnSifremiHatirlat;
        private System.Windows.Forms.TextBox txtSifreEmail;
        private System.Windows.Forms.Button btnSifremiUnuttumGeriDon;
    }
}