
namespace UI.Forms
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnDietList = new System.Windows.Forms.Button();
            this.btnBackLoginPage = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnReportsPage = new System.Windows.Forms.Button();
            this.btnMealPage = new System.Windows.Forms.Button();
            this.btnFoodCalorisPage = new System.Windows.Forms.Button();
            this.lblHold2 = new System.Windows.Forms.Label();
            this.lblHold4 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDietList
            // 
            this.btnDietList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDietList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDietList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDietList.Location = new System.Drawing.Point(28, 49);
            this.btnDietList.Name = "btnDietList";
            this.btnDietList.Size = new System.Drawing.Size(173, 46);
            this.btnDietList.TabIndex = 1;
            this.btnDietList.Text = "DİYET LİSTELERİ";
            this.btnDietList.UseVisualStyleBackColor = false;
            this.btnDietList.Click += new System.EventHandler(this.btnDietList_Click);
            // 
            // btnBackLoginPage
            // 
            this.btnBackLoginPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBackLoginPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLoginPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackLoginPage.ImageIndex = 1;
            this.btnBackLoginPage.ImageList = this.ımageList1;
            this.btnBackLoginPage.Location = new System.Drawing.Point(107, 184);
            this.btnBackLoginPage.Name = "btnBackLoginPage";
            this.btnBackLoginPage.Size = new System.Drawing.Size(218, 42);
            this.btnBackLoginPage.TabIndex = 5;
            this.btnBackLoginPage.Text = "GİRİŞ SAYFAYA DÖN";
            this.btnBackLoginPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackLoginPage.UseVisualStyleBackColor = false;
            this.btnBackLoginPage.Click += new System.EventHandler(this.btnBackLoginPage_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cross.png");
            this.ımageList1.Images.SetKeyName(1, "60577.png");
            // 
            // btnReportsPage
            // 
            this.btnReportsPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReportsPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportsPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReportsPage.Location = new System.Drawing.Point(28, 124);
            this.btnReportsPage.Name = "btnReportsPage";
            this.btnReportsPage.Size = new System.Drawing.Size(173, 42);
            this.btnReportsPage.TabIndex = 3;
            this.btnReportsPage.Text = "RAPORLAR";
            this.btnReportsPage.UseVisualStyleBackColor = false;
            this.btnReportsPage.Click += new System.EventHandler(this.btnReportsPage_Click);
            // 
            // btnMealPage
            // 
            this.btnMealPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMealPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMealPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMealPage.Location = new System.Drawing.Point(228, 124);
            this.btnMealPage.Name = "btnMealPage";
            this.btnMealPage.Size = new System.Drawing.Size(173, 42);
            this.btnMealPage.TabIndex = 4;
            this.btnMealPage.Text = "ÖĞÜN TAKİP";
            this.btnMealPage.UseVisualStyleBackColor = false;
            this.btnMealPage.Click += new System.EventHandler(this.btnMealPage_Click);
            // 
            // btnFoodCalorisPage
            // 
            this.btnFoodCalorisPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFoodCalorisPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodCalorisPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFoodCalorisPage.Location = new System.Drawing.Point(228, 49);
            this.btnFoodCalorisPage.Name = "btnFoodCalorisPage";
            this.btnFoodCalorisPage.Size = new System.Drawing.Size(173, 46);
            this.btnFoodCalorisPage.TabIndex = 2;
            this.btnFoodCalorisPage.Text = "YEMEK - KALORİ BÖLÜMÜ";
            this.btnFoodCalorisPage.UseVisualStyleBackColor = false;
            this.btnFoodCalorisPage.Click += new System.EventHandler(this.btnFoodCalorisPage_Click);
            // 
            // lblHold2
            // 
            this.lblHold2.AutoSize = true;
            this.lblHold2.Location = new System.Drawing.Point(120, 353);
            this.lblHold2.Name = "lblHold2";
            this.lblHold2.Size = new System.Drawing.Size(0, 13);
            this.lblHold2.TabIndex = 9;
            this.lblHold2.Visible = false;
            // 
            // lblHold4
            // 
            this.lblHold4.AutoSize = true;
            this.lblHold4.Location = new System.Drawing.Point(187, 371);
            this.lblHold4.Name = "lblHold4";
            this.lblHold4.Size = new System.Drawing.Size(0, 13);
            this.lblHold4.TabIndex = 10;
            this.lblHold4.Visible = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ImageIndex = 0;
            this.btnCloseApp.ImageList = this.ımageList1;
            this.btnCloseApp.Location = new System.Drawing.Point(404, -1);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(36, 36);
            this.btnCloseApp.TabIndex = 35;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 245);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnBackLoginPage);
            this.Controls.Add(this.lblHold4);
            this.Controls.Add(this.btnReportsPage);
            this.Controls.Add(this.btnMealPage);
            this.Controls.Add(this.lblHold2);
            this.Controls.Add(this.btnFoodCalorisPage);
            this.Controls.Add(this.btnDietList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSyfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDietList;
        private System.Windows.Forms.Button btnReportsPage;
        private System.Windows.Forms.Button btnMealPage;
        private System.Windows.Forms.Button btnFoodCalorisPage;
        private System.Windows.Forms.Button btnBackLoginPage;
        private System.Windows.Forms.Label lblHold2;
        private System.Windows.Forms.Label lblHold4;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnCloseApp;
    }
}