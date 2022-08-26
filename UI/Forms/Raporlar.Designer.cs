
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbAylikRapor = new System.Windows.Forms.GroupBox();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grbEncokTuketilen = new System.Windows.Forms.GroupBox();
            this.btnMostEatFoodsOnMeals = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnBackReportToMain = new System.Windows.Forms.Button();
            this.grbHaftlikRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbAylikRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grbEncokTuketilen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHaftlikRapor
            // 
            this.grbHaftlikRapor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbHaftlikRapor.Controls.Add(this.btnWeeklyReport);
            this.grbHaftlikRapor.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // grbAylikRapor
            // 
            this.grbAylikRapor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbAylikRapor.Controls.Add(this.btnMonthlyReport);
            this.grbAylikRapor.Controls.Add(this.dataGridView2);
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(285, 191);
            this.dataGridView2.TabIndex = 1;
            // 
            // grbEncokTuketilen
            // 
            this.grbEncokTuketilen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbEncokTuketilen.Controls.Add(this.btnMostEatFoodsOnMeals);
            this.grbEncokTuketilen.Controls.Add(this.dataGridView3);
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
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(285, 191);
            this.dataGridView3.TabIndex = 2;
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
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(919, 350);
            this.Controls.Add(this.btnBackReportToMain);
            this.Controls.Add(this.grbEncokTuketilen);
            this.Controls.Add(this.grbAylikRapor);
            this.Controls.Add(this.grbHaftlikRapor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Raporlar_FormClosed);
            this.grbHaftlikRapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbAylikRapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grbEncokTuketilen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHaftlikRapor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbAylikRapor;
        private System.Windows.Forms.GroupBox grbEncokTuketilen;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Button btnMostEatFoodsOnMeals;
        private System.Windows.Forms.Button btnBackReportToMain;
    }
}