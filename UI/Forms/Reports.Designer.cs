
namespace UI.Forms
{
    partial class ReportsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsPage));
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
            this.lstSnack1 = new System.Windows.Forms.ListBox();
            this.lstDinner = new System.Windows.Forms.ListBox();
            this.lstSnack2 = new System.Windows.Forms.ListBox();
            this.lstLunch = new System.Windows.Forms.ListBox();
            this.lstBreakfast = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sabah = new System.Windows.Forms.Label();
            this.btnMostEatFoodsOnMeals = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBackReportToMain = new System.Windows.Forms.Button();
            this.lblHold3 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.grbHaftlikRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyReport)).BeginInit();
            this.grbAylikRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReport)).BeginInit();
            this.grbEncokTuketilen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHaftlikRapor
            // 
            this.grbHaftlikRapor.BackColor = System.Drawing.Color.Transparent;
            this.grbHaftlikRapor.Controls.Add(this.btnWeeklyReport);
            this.grbHaftlikRapor.Controls.Add(this.dgvWeeklyReport);
            this.grbHaftlikRapor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHaftlikRapor.Location = new System.Drawing.Point(29, 45);
            this.grbHaftlikRapor.Name = "grbHaftlikRapor";
            this.grbHaftlikRapor.Size = new System.Drawing.Size(277, 295);
            this.grbHaftlikRapor.TabIndex = 0;
            this.grbHaftlikRapor.TabStop = false;
            this.grbHaftlikRapor.Text = "Haftalık Rapor";
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnWeeklyReport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyReport.Location = new System.Drawing.Point(54, 233);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(161, 42);
            this.btnWeeklyReport.TabIndex = 1;
            this.btnWeeklyReport.Text = "HAFTALIK RAPOR";
            this.btnWeeklyReport.UseVisualStyleBackColor = false;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // dgvWeeklyReport
            // 
            this.dgvWeeklyReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeklyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Günler,
            this.KaloriOrtalamasi});
            this.dgvWeeklyReport.Location = new System.Drawing.Point(16, 21);
            this.dgvWeeklyReport.Name = "dgvWeeklyReport";
            this.dgvWeeklyReport.ReadOnly = true;
            this.dgvWeeklyReport.Size = new System.Drawing.Size(247, 191);
            this.dgvWeeklyReport.TabIndex = 0;
            // 
            // Günler
            // 
            this.Günler.HeaderText = "Günler";
            this.Günler.Name = "Günler";
            this.Günler.ReadOnly = true;
            // 
            // KaloriOrtalamasi
            // 
            this.KaloriOrtalamasi.HeaderText = "Kalori Ortalaması";
            this.KaloriOrtalamasi.Name = "KaloriOrtalamasi";
            this.KaloriOrtalamasi.ReadOnly = true;
            // 
            // grbAylikRapor
            // 
            this.grbAylikRapor.BackColor = System.Drawing.Color.Transparent;
            this.grbAylikRapor.Controls.Add(this.btnMonthlyReport);
            this.grbAylikRapor.Controls.Add(this.dgvMonthlyReport);
            this.grbAylikRapor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAylikRapor.Location = new System.Drawing.Point(332, 45);
            this.grbAylikRapor.Name = "grbAylikRapor";
            this.grbAylikRapor.Size = new System.Drawing.Size(265, 295);
            this.grbAylikRapor.TabIndex = 1;
            this.grbAylikRapor.TabStop = false;
            this.grbAylikRapor.Text = "Aylık Rapor";
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMonthlyReport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyReport.Location = new System.Drawing.Point(57, 233);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(161, 42);
            this.btnMonthlyReport.TabIndex = 2;
            this.btnMonthlyReport.Text = "AYLIK RAPOR";
            this.btnMonthlyReport.UseVisualStyleBackColor = false;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // dgvMonthlyReport
            // 
            this.dgvMonthlyReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Haftalar,
            this.Kalori});
            this.dgvMonthlyReport.Location = new System.Drawing.Point(6, 19);
            this.dgvMonthlyReport.Name = "dgvMonthlyReport";
            this.dgvMonthlyReport.ReadOnly = true;
            this.dgvMonthlyReport.Size = new System.Drawing.Size(243, 191);
            this.dgvMonthlyReport.TabIndex = 1;
            // 
            // Haftalar
            // 
            this.Haftalar.HeaderText = "Haftalar";
            this.Haftalar.Name = "Haftalar";
            this.Haftalar.ReadOnly = true;
            // 
            // Kalori
            // 
            this.Kalori.HeaderText = "Kalori Ortalaması";
            this.Kalori.Name = "Kalori";
            this.Kalori.ReadOnly = true;
            // 
            // grbEncokTuketilen
            // 
            this.grbEncokTuketilen.BackColor = System.Drawing.Color.Transparent;
            this.grbEncokTuketilen.Controls.Add(this.lstSnack1);
            this.grbEncokTuketilen.Controls.Add(this.lstDinner);
            this.grbEncokTuketilen.Controls.Add(this.lstSnack2);
            this.grbEncokTuketilen.Controls.Add(this.lstLunch);
            this.grbEncokTuketilen.Controls.Add(this.lstBreakfast);
            this.grbEncokTuketilen.Controls.Add(this.label5);
            this.grbEncokTuketilen.Controls.Add(this.label4);
            this.grbEncokTuketilen.Controls.Add(this.label3);
            this.grbEncokTuketilen.Controls.Add(this.label2);
            this.grbEncokTuketilen.Controls.Add(this.Sabah);
            this.grbEncokTuketilen.Controls.Add(this.btnMostEatFoodsOnMeals);
            this.grbEncokTuketilen.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEncokTuketilen.Location = new System.Drawing.Point(603, 46);
            this.grbEncokTuketilen.Name = "grbEncokTuketilen";
            this.grbEncokTuketilen.Size = new System.Drawing.Size(271, 294);
            this.grbEncokTuketilen.TabIndex = 2;
            this.grbEncokTuketilen.TabStop = false;
            this.grbEncokTuketilen.Text = "Öğünlere Göre En Çok Tüketilen Besinler";
            // 
            // lstSnack1
            // 
            this.lstSnack1.FormattingEnabled = true;
            this.lstSnack1.ItemHeight = 16;
            this.lstSnack1.Location = new System.Drawing.Point(80, 64);
            this.lstSnack1.Name = "lstSnack1";
            this.lstSnack1.Size = new System.Drawing.Size(169, 36);
            this.lstSnack1.TabIndex = 11;
            // 
            // lstDinner
            // 
            this.lstDinner.FormattingEnabled = true;
            this.lstDinner.ItemHeight = 16;
            this.lstDinner.Location = new System.Drawing.Point(80, 190);
            this.lstDinner.Name = "lstDinner";
            this.lstDinner.Size = new System.Drawing.Size(169, 36);
            this.lstDinner.TabIndex = 11;
            // 
            // lstSnack2
            // 
            this.lstSnack2.FormattingEnabled = true;
            this.lstSnack2.ItemHeight = 16;
            this.lstSnack2.Location = new System.Drawing.Point(80, 148);
            this.lstSnack2.Name = "lstSnack2";
            this.lstSnack2.Size = new System.Drawing.Size(169, 36);
            this.lstSnack2.TabIndex = 11;
            // 
            // lstLunch
            // 
            this.lstLunch.FormattingEnabled = true;
            this.lstLunch.ItemHeight = 16;
            this.lstLunch.Location = new System.Drawing.Point(80, 106);
            this.lstLunch.Name = "lstLunch";
            this.lstLunch.Size = new System.Drawing.Size(169, 36);
            this.lstLunch.TabIndex = 11;
            // 
            // lstBreakfast
            // 
            this.lstBreakfast.FormattingEnabled = true;
            this.lstBreakfast.ItemHeight = 16;
            this.lstBreakfast.Location = new System.Drawing.Point(80, 22);
            this.lstBreakfast.Name = "lstBreakfast";
            this.lstBreakfast.Size = new System.Drawing.Size(169, 36);
            this.lstBreakfast.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Akşam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ara Öğün2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Öğle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ara Öğün1";
            // 
            // Sabah
            // 
            this.Sabah.AutoSize = true;
            this.Sabah.Location = new System.Drawing.Point(18, 33);
            this.Sabah.Name = "Sabah";
            this.Sabah.Size = new System.Drawing.Size(45, 16);
            this.Sabah.TabIndex = 10;
            this.Sabah.Text = "Sabah";
            // 
            // btnMostEatFoodsOnMeals
            // 
            this.btnMostEatFoodsOnMeals.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMostEatFoodsOnMeals.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostEatFoodsOnMeals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostEatFoodsOnMeals.ImageIndex = 1;
            this.btnMostEatFoodsOnMeals.ImageList = this.ımageList1;
            this.btnMostEatFoodsOnMeals.Location = new System.Drawing.Point(136, 232);
            this.btnMostEatFoodsOnMeals.Name = "btnMostEatFoodsOnMeals";
            this.btnMostEatFoodsOnMeals.Size = new System.Drawing.Size(113, 42);
            this.btnMostEatFoodsOnMeals.TabIndex = 3;
            this.btnMostEatFoodsOnMeals.Text = "GÖSTER";
            this.btnMostEatFoodsOnMeals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostEatFoodsOnMeals.UseVisualStyleBackColor = false;
            this.btnMostEatFoodsOnMeals.Click += new System.EventHandler(this.btnMostEatFoodsOnMeals_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "60577.png");
            this.ımageList1.Images.SetKeyName(1, "indir.png");
            this.ımageList1.Images.SetKeyName(2, "cross.png");
            // 
            // btnBackReportToMain
            // 
            this.btnBackReportToMain.BackColor = System.Drawing.Color.Transparent;
            this.btnBackReportToMain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackReportToMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackReportToMain.ImageIndex = 0;
            this.btnBackReportToMain.ImageList = this.ımageList1;
            this.btnBackReportToMain.Location = new System.Drawing.Point(399, 346);
            this.btnBackReportToMain.Name = "btnBackReportToMain";
            this.btnBackReportToMain.Size = new System.Drawing.Size(131, 42);
            this.btnBackReportToMain.TabIndex = 4;
            this.btnBackReportToMain.Text = "GERİ DÖN";
            this.btnBackReportToMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackReportToMain.UseVisualStyleBackColor = false;
            this.btnBackReportToMain.Click += new System.EventHandler(this.btnBackReportToMain_Click);
            // 
            // lblHold3
            // 
            this.lblHold3.AutoSize = true;
            this.lblHold3.Location = new System.Drawing.Point(270, 358);
            this.lblHold3.Name = "lblHold3";
            this.lblHold3.Size = new System.Drawing.Size(0, 13);
            this.lblHold3.TabIndex = 30;
            this.lblHold3.Visible = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ImageIndex = 2;
            this.btnCloseApp.ImageList = this.ımageList1;
            this.btnCloseApp.Location = new System.Drawing.Point(880, -1);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(37, 37);
            this.btnCloseApp.TabIndex = 31;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // ReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 398);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.lblHold3);
            this.Controls.Add(this.btnBackReportToMain);
            this.Controls.Add(this.grbEncokTuketilen);
            this.Controls.Add(this.grbAylikRapor);
            this.Controls.Add(this.grbHaftlikRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportsPage_FormClosed);
            this.Load += new System.EventHandler(this.ReportsPage_Load);
            this.grbHaftlikRapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyReport)).EndInit();
            this.grbAylikRapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReport)).EndInit();
            this.grbEncokTuketilen.ResumeLayout(false);
            this.grbEncokTuketilen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHaftlikRapor;
        private System.Windows.Forms.DataGridView dgvWeeklyReport;
        private System.Windows.Forms.GroupBox grbAylikRapor;
        private System.Windows.Forms.GroupBox grbEncokTuketilen;
        private System.Windows.Forms.DataGridView dgvMonthlyReport;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Button btnMostEatFoodsOnMeals;
        private System.Windows.Forms.Button btnBackReportToMain;
        private System.Windows.Forms.Label lblHold3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Günler;
        private System.Windows.Forms.DataGridViewTextBoxColumn KaloriOrtalamasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haftalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kalori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Sabah;
        private System.Windows.Forms.ListBox lstBreakfast;
        private System.Windows.Forms.ListBox lstSnack1;
        private System.Windows.Forms.ListBox lstDinner;
        private System.Windows.Forms.ListBox lstSnack2;
        private System.Windows.Forms.ListBox lstLunch;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnCloseApp;
    }
}