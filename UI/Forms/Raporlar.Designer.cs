
namespace UI.Forms
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.grbHaftlikRapor = new System.Windows.Forms.GroupBox();
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.dgvWeeklyReport = new System.Windows.Forms.DataGridView();
            this.Günler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KaloriOrtalamasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAylikRapor = new System.Windows.Forms.GroupBox();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.dgvMonthlyReport = new System.Windows.Forms.DataGridView();
            this.Haftalar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kalori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEncokTuketilen = new System.Windows.Forms.GroupBox();
            this.btnMostEatFoodsOnMeals = new System.Windows.Forms.Button();
            this.dgvMostEatingFoodByMeal = new System.Windows.Forms.DataGridView();
            this.btnBackReportToMain = new System.Windows.Forms.Button();
            this.lblHold3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbHaftlikRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyReport)).BeginInit();
            this.grbAylikRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReport)).BeginInit();
            this.grbEncokTuketilen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostEatingFoodByMeal)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHaftlikRapor
            // 
            this.grbHaftlikRapor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbHaftlikRapor.Controls.Add(this.btnWeeklyReport);
            this.grbHaftlikRapor.Controls.Add(this.dgvWeeklyReport);
            this.grbHaftlikRapor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHaftlikRapor.Location = new System.Drawing.Point(12, 12);
            this.grbHaftlikRapor.Name = "grbHaftlikRapor";
            this.grbHaftlikRapor.Size = new System.Drawing.Size(297, 281);
            this.grbHaftlikRapor.TabIndex = 0;
            this.grbHaftlikRapor.TabStop = false;
            this.grbHaftlikRapor.Text = "Haftalık Rapor";
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.BackColor = System.Drawing.Color.Lavender;
            this.btnWeeklyReport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyReport.Location = new System.Drawing.Point(51, 216);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(161, 42);
            this.btnWeeklyReport.TabIndex = 6;
            this.btnWeeklyReport.Text = "HAFTALIK RAPOR";
            this.btnWeeklyReport.UseVisualStyleBackColor = false;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // dgvWeeklyReport
            // 
            this.dgvWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeklyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Günler,
            this.KaloriOrtalamasi});
            this.dgvWeeklyReport.Location = new System.Drawing.Point(6, 19);
            this.dgvWeeklyReport.Name = "dgvWeeklyReport";
            this.dgvWeeklyReport.Size = new System.Drawing.Size(247, 191);
            this.dgvWeeklyReport.TabIndex = 0;
            // 
            // Günler
            // 
            this.Günler.HeaderText = "Günler";
            this.Günler.Name = "Günler";
            // 
            // KaloriOrtalamasi
            // 
            this.KaloriOrtalamasi.HeaderText = "Kalori Ortalaması";
            this.KaloriOrtalamasi.Name = "KaloriOrtalamasi";
            // 
            // grbAylikRapor
            // 
            this.grbAylikRapor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbAylikRapor.Controls.Add(this.btnMonthlyReport);
            this.grbAylikRapor.Controls.Add(this.dgvMonthlyReport);
            this.grbAylikRapor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAylikRapor.Location = new System.Drawing.Point(315, 12);
            this.grbAylikRapor.Name = "grbAylikRapor";
            this.grbAylikRapor.Size = new System.Drawing.Size(297, 281);
            this.grbAylikRapor.TabIndex = 1;
            this.grbAylikRapor.TabStop = false;
            this.grbAylikRapor.Text = "Aylık Rapor";
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.BackColor = System.Drawing.Color.Lavender;
            this.btnMonthlyReport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyReport.Location = new System.Drawing.Point(68, 216);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(161, 42);
            this.btnMonthlyReport.TabIndex = 7;
            this.btnMonthlyReport.Text = "AYLIK RAPOR";
            this.btnMonthlyReport.UseVisualStyleBackColor = false;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // dgvMonthlyReport
            // 
            this.dgvMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Haftalar,
            this.Kalori});
            this.dgvMonthlyReport.Location = new System.Drawing.Point(6, 19);
            this.dgvMonthlyReport.Name = "dgvMonthlyReport";
            this.dgvMonthlyReport.Size = new System.Drawing.Size(285, 191);
            this.dgvMonthlyReport.TabIndex = 1;
            // 
            // Haftalar
            // 
            this.Haftalar.HeaderText = "Haftalar";
            this.Haftalar.Name = "Haftalar";
            // 
            // Kalori
            // 
            this.Kalori.HeaderText = "Kalori Ortalaması";
            this.Kalori.Name = "Kalori";
            // 
            // grbEncokTuketilen
            // 
            this.grbEncokTuketilen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbEncokTuketilen.Controls.Add(this.btnMostEatFoodsOnMeals);
            this.grbEncokTuketilen.Controls.Add(this.dgvMostEatingFoodByMeal);
            this.grbEncokTuketilen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEncokTuketilen.Location = new System.Drawing.Point(618, 12);
            this.grbEncokTuketilen.Name = "grbEncokTuketilen";
            this.grbEncokTuketilen.Size = new System.Drawing.Size(297, 281);
            this.grbEncokTuketilen.TabIndex = 2;
            this.grbEncokTuketilen.TabStop = false;
            this.grbEncokTuketilen.Text = "Öğünere Göre En Çok Tükerilen Besinler";
            // 
            // btnMostEatFoodsOnMeals
            // 
            this.btnMostEatFoodsOnMeals.BackColor = System.Drawing.Color.Lavender;
            this.btnMostEatFoodsOnMeals.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostEatFoodsOnMeals.Location = new System.Drawing.Point(6, 216);
            this.btnMostEatFoodsOnMeals.Name = "btnMostEatFoodsOnMeals";
            this.btnMostEatFoodsOnMeals.Size = new System.Drawing.Size(283, 42);
            this.btnMostEatFoodsOnMeals.TabIndex = 8;
            this.btnMostEatFoodsOnMeals.Text = "ÖĞÜNLERE GÖRE EN ÇOK TÜKETİLEN BESİNLER";
            this.btnMostEatFoodsOnMeals.UseVisualStyleBackColor = false;
            this.btnMostEatFoodsOnMeals.Click += new System.EventHandler(this.btnMostEatFoodsOnMeals_Click);
            // 
            // dgvMostEatingFoodByMeal
            // 
            this.dgvMostEatingFoodByMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostEatingFoodByMeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvMostEatingFoodByMeal.Location = new System.Drawing.Point(6, 19);
            this.dgvMostEatingFoodByMeal.Name = "dgvMostEatingFoodByMeal";
            this.dgvMostEatingFoodByMeal.Size = new System.Drawing.Size(285, 191);
            this.dgvMostEatingFoodByMeal.TabIndex = 2;
            // 
            // btnBackReportToMain
            // 
            this.btnBackReportToMain.BackColor = System.Drawing.Color.Pink;
            this.btnBackReportToMain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackReportToMain.Location = new System.Drawing.Point(784, 299);
            this.btnBackReportToMain.Name = "btnBackReportToMain";
            this.btnBackReportToMain.Size = new System.Drawing.Size(131, 42);
            this.btnBackReportToMain.TabIndex = 29;
            this.btnBackReportToMain.Text = "GERİ DÖN";
            this.btnBackReportToMain.UseVisualStyleBackColor = false;
            this.btnBackReportToMain.Click += new System.EventHandler(this.btnBackReportToMain_Click);
            // 
            // lblHold3
            // 
            this.lblHold3.AutoSize = true;
            this.lblHold3.Location = new System.Drawing.Point(253, 325);
            this.lblHold3.Name = "lblHold3";
            this.lblHold3.Size = new System.Drawing.Size(0, 13);
            this.lblHold3.TabIndex = 30;
            this.lblHold3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(919, 350);
            this.Controls.Add(this.lblHold3);
            this.Controls.Add(this.btnBackReportToMain);
            this.Controls.Add(this.grbEncokTuketilen);
            this.Controls.Add(this.grbAylikRapor);
            this.Controls.Add(this.grbHaftlikRapor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Raporlar_FormClosed);
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.grbHaftlikRapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyReport)).EndInit();
            this.grbAylikRapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReport)).EndInit();
            this.grbEncokTuketilen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostEatingFoodByMeal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHaftlikRapor;
        private System.Windows.Forms.DataGridView dgvWeeklyReport;
        private System.Windows.Forms.GroupBox grbAylikRapor;
        private System.Windows.Forms.GroupBox grbEncokTuketilen;
        private System.Windows.Forms.DataGridView dgvMonthlyReport;
        private System.Windows.Forms.DataGridView dgvMostEatingFoodByMeal;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Button btnMostEatFoodsOnMeals;
        private System.Windows.Forms.Button btnBackReportToMain;
        private System.Windows.Forms.Label lblHold3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Günler;
        private System.Windows.Forms.DataGridViewTextBoxColumn KaloriOrtalamasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haftalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kalori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}