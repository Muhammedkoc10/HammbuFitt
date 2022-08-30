
namespace UI.Forms
{
    partial class MealPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealPage));
            this.grpAddMeal = new System.Windows.Forms.GroupBox();
            this.lstShowMeal = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbMealSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMealFoodSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMealCategorySelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMealBackToMain = new System.Windows.Forms.Button();
            this.lblHold1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDailyMealInfo = new System.Windows.Forms.Button();
            this.btnDailyCalories = new System.Windows.Forms.Button();
            this.dgvMealDaily = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMealReport = new System.Windows.Forms.GroupBox();
            this.lblHold5 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.grpAddMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealDaily)).BeginInit();
            this.grpMealReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddMeal
            // 
            this.grpAddMeal.BackColor = System.Drawing.Color.Transparent;
            this.grpAddMeal.Controls.Add(this.lstShowMeal);
            this.grpAddMeal.Controls.Add(this.btnAddMeal);
            this.grpAddMeal.Controls.Add(this.cmbMealSelect);
            this.grpAddMeal.Controls.Add(this.label3);
            this.grpAddMeal.Controls.Add(this.cmbMealFoodSelect);
            this.grpAddMeal.Controls.Add(this.label2);
            this.grpAddMeal.Controls.Add(this.cmbMealCategorySelect);
            this.grpAddMeal.Controls.Add(this.label1);
            this.grpAddMeal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddMeal.Location = new System.Drawing.Point(45, 56);
            this.grpAddMeal.Name = "grpAddMeal";
            this.grpAddMeal.Size = new System.Drawing.Size(358, 350);
            this.grpAddMeal.TabIndex = 0;
            this.grpAddMeal.TabStop = false;
            this.grpAddMeal.Text = "Öğün Ekleme";
            // 
            // lstShowMeal
            // 
            this.lstShowMeal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstShowMeal.GridLines = true;
            this.lstShowMeal.HideSelection = false;
            this.lstShowMeal.Location = new System.Drawing.Point(19, 131);
            this.lstShowMeal.Name = "lstShowMeal";
            this.lstShowMeal.Size = new System.Drawing.Size(317, 156);
            this.lstShowMeal.TabIndex = 12;
            this.lstShowMeal.UseCompatibleStateImageBehavior = false;
            this.lstShowMeal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategorisi:";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yemeği:";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Öğünü:";
            this.columnHeader3.Width = 68;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddMeal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMeal.ImageIndex = 2;
            this.btnAddMeal.ImageList = this.ımageList1;
            this.btnAddMeal.Location = new System.Drawing.Point(191, 293);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(145, 42);
            this.btnAddMeal.TabIndex = 4;
            this.btnAddMeal.Text = "ÖĞÜN EKLE";
            this.btnAddMeal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMeal.UseVisualStyleBackColor = false;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cross.png");
            this.ımageList1.Images.SetKeyName(1, "60577.png");
            this.ımageList1.Images.SetKeyName(2, "icon-add-0.jpg");
            // 
            // cmbMealSelect
            // 
            this.cmbMealSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealSelect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMealSelect.FormattingEnabled = true;
            this.cmbMealSelect.Items.AddRange(new object[] {
            "Sabah",
            "Ara Öğün 1",
            "Öğle",
            "Ara Öğün 2",
            "Akşam"});
            this.cmbMealSelect.Location = new System.Drawing.Point(139, 81);
            this.cmbMealSelect.Name = "cmbMealSelect";
            this.cmbMealSelect.Size = new System.Drawing.Size(213, 25);
            this.cmbMealSelect.TabIndex = 3;
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
            // cmbMealFoodSelect
            // 
            this.cmbMealFoodSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealFoodSelect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMealFoodSelect.FormattingEnabled = true;
            this.cmbMealFoodSelect.Location = new System.Drawing.Point(139, 50);
            this.cmbMealFoodSelect.Name = "cmbMealFoodSelect";
            this.cmbMealFoodSelect.Size = new System.Drawing.Size(213, 25);
            this.cmbMealFoodSelect.TabIndex = 2;
            this.cmbMealFoodSelect.SelectedIndexChanged += new System.EventHandler(this.cmbMealFoodSelect_SelectedIndexChanged);
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
            // cmbMealCategorySelect
            // 
            this.cmbMealCategorySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealCategorySelect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMealCategorySelect.FormattingEnabled = true;
            this.cmbMealCategorySelect.Location = new System.Drawing.Point(139, 19);
            this.cmbMealCategorySelect.Name = "cmbMealCategorySelect";
            this.cmbMealCategorySelect.Size = new System.Drawing.Size(213, 25);
            this.cmbMealCategorySelect.TabIndex = 1;
            this.cmbMealCategorySelect.SelectedIndexChanged += new System.EventHandler(this.cmbMealCategorySelect_SelectedIndexChanged);
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
            // btnMealBackToMain
            // 
            this.btnMealBackToMain.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMealBackToMain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMealBackToMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMealBackToMain.ImageIndex = 1;
            this.btnMealBackToMain.ImageList = this.ımageList1;
            this.btnMealBackToMain.Location = new System.Drawing.Point(347, 412);
            this.btnMealBackToMain.Name = "btnMealBackToMain";
            this.btnMealBackToMain.Size = new System.Drawing.Size(131, 42);
            this.btnMealBackToMain.TabIndex = 7;
            this.btnMealBackToMain.Text = "GERİ DÖN";
            this.btnMealBackToMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMealBackToMain.UseVisualStyleBackColor = false;
            this.btnMealBackToMain.Click += new System.EventHandler(this.btnMealBackToMain_Click);
            // 
            // lblHold1
            // 
            this.lblHold1.AutoSize = true;
            this.lblHold1.Location = new System.Drawing.Point(297, 426);
            this.lblHold1.Name = "lblHold1";
            this.lblHold1.Size = new System.Drawing.Size(0, 13);
            this.lblHold1.TabIndex = 30;
            this.lblHold1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Günlük Öğünler";
            // 
            // btnDailyMealInfo
            // 
            this.btnDailyMealInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDailyMealInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyMealInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDailyMealInfo.Location = new System.Drawing.Point(16, 280);
            this.btnDailyMealInfo.Name = "btnDailyMealInfo";
            this.btnDailyMealInfo.Size = new System.Drawing.Size(161, 55);
            this.btnDailyMealInfo.TabIndex = 5;
            this.btnDailyMealInfo.Text = "GÜNLÜK ÖĞÜNLER BİLGİSİ";
            this.btnDailyMealInfo.UseVisualStyleBackColor = false;
            this.btnDailyMealInfo.Click += new System.EventHandler(this.btnDailyMealInfo_Click);
            // 
            // btnDailyCalories
            // 
            this.btnDailyCalories.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDailyCalories.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyCalories.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDailyCalories.Location = new System.Drawing.Point(204, 280);
            this.btnDailyCalories.Name = "btnDailyCalories";
            this.btnDailyCalories.Size = new System.Drawing.Size(161, 55);
            this.btnDailyCalories.TabIndex = 6;
            this.btnDailyCalories.Text = "GÜNLÜK TOPLAM ALDIĞINIZ KALORİ";
            this.btnDailyCalories.UseVisualStyleBackColor = false;
            this.btnDailyCalories.Click += new System.EventHandler(this.btnDailyCalories_Click);
            // 
            // dgvMealDaily
            // 
            this.dgvMealDaily.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMealDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealDaily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvMealDaily.Location = new System.Drawing.Point(16, 42);
            this.dgvMealDaily.Name = "dgvMealDaily";
            this.dgvMealDaily.ReadOnly = true;
            this.dgvMealDaily.Size = new System.Drawing.Size(335, 220);
            this.dgvMealDaily.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Öğün";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Yemek";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kalori";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // grpMealReport
            // 
            this.grpMealReport.BackColor = System.Drawing.Color.Transparent;
            this.grpMealReport.Controls.Add(this.dgvMealDaily);
            this.grpMealReport.Controls.Add(this.btnDailyCalories);
            this.grpMealReport.Controls.Add(this.btnDailyMealInfo);
            this.grpMealReport.Controls.Add(this.label4);
            this.grpMealReport.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMealReport.Location = new System.Drawing.Point(409, 56);
            this.grpMealReport.Name = "grpMealReport";
            this.grpMealReport.Size = new System.Drawing.Size(377, 350);
            this.grpMealReport.TabIndex = 1;
            this.grpMealReport.TabStop = false;
            this.grpMealReport.Text = "Öğün Raporu";
            // 
            // lblHold5
            // 
            this.lblHold5.AutoSize = true;
            this.lblHold5.Location = new System.Drawing.Point(75, 382);
            this.lblHold5.Name = "lblHold5";
            this.lblHold5.Size = new System.Drawing.Size(0, 13);
            this.lblHold5.TabIndex = 31;
            this.lblHold5.Visible = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ImageIndex = 0;
            this.btnCloseApp.ImageList = this.ımageList1;
            this.btnCloseApp.Location = new System.Drawing.Point(804, -1);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(36, 36);
            this.btnCloseApp.TabIndex = 36;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // MealPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 466);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.lblHold5);
            this.Controls.Add(this.lblHold1);
            this.Controls.Add(this.btnMealBackToMain);
            this.Controls.Add(this.grpMealReport);
            this.Controls.Add(this.grpAddMeal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MealPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Meal_FormClosed);
            this.Load += new System.EventHandler(this.Meal_Load);
            this.grpAddMeal.ResumeLayout(false);
            this.grpAddMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealDaily)).EndInit();
            this.grpMealReport.ResumeLayout(false);
            this.grpMealReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddMeal;
        private System.Windows.Forms.ComboBox cmbMealSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMealFoodSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMealCategorySelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Button btnMealBackToMain;
        private System.Windows.Forms.Label lblHold1;
        private System.Windows.Forms.ListView lstShowMeal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDailyMealInfo;
        private System.Windows.Forms.Button btnDailyCalories;
        private System.Windows.Forms.DataGridView dgvMealDaily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox grpMealReport;
        private System.Windows.Forms.Label lblHold5;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnCloseApp;
    }
}