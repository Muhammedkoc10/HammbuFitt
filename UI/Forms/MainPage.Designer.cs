
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
            this.btnDietList = new System.Windows.Forms.Button();
            this.grpMainPage = new System.Windows.Forms.GroupBox();
            this.btnBackLoginPage = new System.Windows.Forms.Button();
            this.btnReportsPage = new System.Windows.Forms.Button();
            this.btnMealPage = new System.Windows.Forms.Button();
            this.btnFoodCalorisPage = new System.Windows.Forms.Button();
            this.lblHold2 = new System.Windows.Forms.Label();
            this.lblHold4 = new System.Windows.Forms.Label();
            this.grpMainPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDietList
            // 
            this.btnDietList.BackColor = System.Drawing.Color.Magenta;
            this.btnDietList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDietList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDietList.Location = new System.Drawing.Point(42, 21);
            this.btnDietList.Name = "btnDietList";
            this.btnDietList.Size = new System.Drawing.Size(173, 42);
            this.btnDietList.TabIndex = 7;
            this.btnDietList.Text = "DİYET LİSTELERİ";
            this.btnDietList.UseVisualStyleBackColor = false;
            this.btnDietList.Click += new System.EventHandler(this.btnDietList_Click);
            // 
            // grpMainPage
            // 
            this.grpMainPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpMainPage.Controls.Add(this.btnBackLoginPage);
            this.grpMainPage.Controls.Add(this.btnReportsPage);
            this.grpMainPage.Controls.Add(this.btnMealPage);
            this.grpMainPage.Controls.Add(this.btnFoodCalorisPage);
            this.grpMainPage.Controls.Add(this.btnDietList);
            this.grpMainPage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMainPage.Location = new System.Drawing.Point(8, 20);
            this.grpMainPage.Name = "grpMainPage";
            this.grpMainPage.Size = new System.Drawing.Size(274, 325);
            this.grpMainPage.TabIndex = 8;
            this.grpMainPage.TabStop = false;
            this.grpMainPage.Text = "Ana Sayfa";
            // 
            // btnBackLoginPage
            // 
            this.btnBackLoginPage.BackColor = System.Drawing.Color.Pink;
            this.btnBackLoginPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLoginPage.Location = new System.Drawing.Point(19, 278);
            this.btnBackLoginPage.Name = "btnBackLoginPage";
            this.btnBackLoginPage.Size = new System.Drawing.Size(218, 42);
            this.btnBackLoginPage.TabIndex = 27;
            this.btnBackLoginPage.Text = "GİRİŞ SAYFAYA DÖN";
            this.btnBackLoginPage.UseVisualStyleBackColor = false;
            this.btnBackLoginPage.Click += new System.EventHandler(this.btnBackLoginPage_Click);
            // 
            // btnReportsPage
            // 
            this.btnReportsPage.BackColor = System.Drawing.Color.Magenta;
            this.btnReportsPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportsPage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReportsPage.Location = new System.Drawing.Point(42, 221);
            this.btnReportsPage.Name = "btnReportsPage";
            this.btnReportsPage.Size = new System.Drawing.Size(173, 42);
            this.btnReportsPage.TabIndex = 11;
            this.btnReportsPage.Text = "RAPORLAR";
            this.btnReportsPage.UseVisualStyleBackColor = false;
            this.btnReportsPage.Click += new System.EventHandler(this.btnReportsPage_Click);
            // 
            // btnMealPage
            // 
            this.btnMealPage.BackColor = System.Drawing.Color.Magenta;
            this.btnMealPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMealPage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMealPage.Location = new System.Drawing.Point(42, 159);
            this.btnMealPage.Name = "btnMealPage";
            this.btnMealPage.Size = new System.Drawing.Size(173, 42);
            this.btnMealPage.TabIndex = 10;
            this.btnMealPage.Text = "ÖĞÜN TAKİP";
            this.btnMealPage.UseVisualStyleBackColor = false;
            this.btnMealPage.Click += new System.EventHandler(this.btnMealPage_Click);
            // 
            // btnFoodCalorisPage
            // 
            this.btnFoodCalorisPage.BackColor = System.Drawing.Color.Magenta;
            this.btnFoodCalorisPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodCalorisPage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFoodCalorisPage.Location = new System.Drawing.Point(42, 86);
            this.btnFoodCalorisPage.Name = "btnFoodCalorisPage";
            this.btnFoodCalorisPage.Size = new System.Drawing.Size(173, 50);
            this.btnFoodCalorisPage.TabIndex = 9;
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
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(286, 351);
            this.Controls.Add(this.lblHold4);
            this.Controls.Add(this.lblHold2);
            this.Controls.Add(this.grpMainPage);
            this.Name = "MainPage";
            this.Text = "AnaSyfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.grpMainPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDietList;
        private System.Windows.Forms.GroupBox grpMainPage;
        private System.Windows.Forms.Button btnReportsPage;
        private System.Windows.Forms.Button btnMealPage;
        private System.Windows.Forms.Button btnFoodCalorisPage;
        private System.Windows.Forms.Button btnBackLoginPage;
        private System.Windows.Forms.Label lblHold2;
        private System.Windows.Forms.Label lblHold4;
    }
}