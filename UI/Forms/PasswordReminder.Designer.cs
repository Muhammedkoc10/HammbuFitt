
namespace UI
{
    partial class PasswordReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordReminder));
            this.grpPasswordReminder = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserNameReminder = new System.Windows.Forms.TextBox();
            this.btnPasswordReminder = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtEmailReminder = new System.Windows.Forms.TextBox();
            this.btnBackToLoginPage = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.grpPasswordReminder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPasswordReminder
            // 
            this.grpPasswordReminder.BackColor = System.Drawing.Color.Transparent;
            this.grpPasswordReminder.Controls.Add(this.label2);
            this.grpPasswordReminder.Controls.Add(this.label1);
            this.grpPasswordReminder.Controls.Add(this.txtUserNameReminder);
            this.grpPasswordReminder.Controls.Add(this.btnPasswordReminder);
            this.grpPasswordReminder.Controls.Add(this.txtEmailReminder);
            this.grpPasswordReminder.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPasswordReminder.Location = new System.Drawing.Point(56, 48);
            this.grpPasswordReminder.Name = "grpPasswordReminder";
            this.grpPasswordReminder.Size = new System.Drawing.Size(310, 231);
            this.grpPasswordReminder.TabIndex = 0;
            this.grpPasswordReminder.TabStop = false;
            this.grpPasswordReminder.Text = "Şifremi Unuttum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtUserNameReminder
            // 
            this.txtUserNameReminder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameReminder.Location = new System.Drawing.Point(20, 50);
            this.txtUserNameReminder.Name = "txtUserNameReminder";
            this.txtUserNameReminder.Size = new System.Drawing.Size(287, 25);
            this.txtUserNameReminder.TabIndex = 1;
            this.txtUserNameReminder.Tag = "";
            // 
            // btnPasswordReminder
            // 
            this.btnPasswordReminder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPasswordReminder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordReminder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasswordReminder.ImageIndex = 2;
            this.btnPasswordReminder.ImageList = this.ımageList1;
            this.btnPasswordReminder.Location = new System.Drawing.Point(61, 164);
            this.btnPasswordReminder.Name = "btnPasswordReminder";
            this.btnPasswordReminder.Size = new System.Drawing.Size(205, 42);
            this.btnPasswordReminder.TabIndex = 3;
            this.btnPasswordReminder.Text = "ŞİFREMİ HATIRLAT";
            this.btnPasswordReminder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPasswordReminder.UseVisualStyleBackColor = false;
            this.btnPasswordReminder.Click += new System.EventHandler(this.btnPasswordReminder_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "60577.png");
            this.ımageList1.Images.SetKeyName(1, "cross.png");
            this.ımageList1.Images.SetKeyName(2, "signup-icon-21.jpg");
            // 
            // txtEmailReminder
            // 
            this.txtEmailReminder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailReminder.Location = new System.Drawing.Point(20, 118);
            this.txtEmailReminder.Name = "txtEmailReminder";
            this.txtEmailReminder.Size = new System.Drawing.Size(287, 25);
            this.txtEmailReminder.TabIndex = 2;
            // 
            // btnBackToLoginPage
            // 
            this.btnBackToLoginPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBackToLoginPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLoginPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToLoginPage.ImageKey = "60577.png";
            this.btnBackToLoginPage.ImageList = this.ımageList1;
            this.btnBackToLoginPage.Location = new System.Drawing.Point(151, 285);
            this.btnBackToLoginPage.Name = "btnBackToLoginPage";
            this.btnBackToLoginPage.Size = new System.Drawing.Size(131, 42);
            this.btnBackToLoginPage.TabIndex = 4;
            this.btnBackToLoginPage.Text = "GERİ DÖN";
            this.btnBackToLoginPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackToLoginPage.UseVisualStyleBackColor = false;
            this.btnBackToLoginPage.Click += new System.EventHandler(this.btnBackToLoginPage_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ImageIndex = 1;
            this.btnCloseApp.ImageList = this.ımageList1;
            this.btnCloseApp.Location = new System.Drawing.Point(395, -1);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(37, 37);
            this.btnCloseApp.TabIndex = 29;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // PasswordReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 341);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnBackToLoginPage);
            this.Controls.Add(this.grpPasswordReminder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifremi Unuttum";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PasswordReminder_FormClosed);
            this.Load += new System.EventHandler(this.PasswordReminder_Load);
            this.grpPasswordReminder.ResumeLayout(false);
            this.grpPasswordReminder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPasswordReminder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserNameReminder;
        private System.Windows.Forms.Button btnPasswordReminder;
        private System.Windows.Forms.TextBox txtEmailReminder;
        private System.Windows.Forms.Button btnBackToLoginPage;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnCloseApp;
    }
}