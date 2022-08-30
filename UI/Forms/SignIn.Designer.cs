
namespace UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblPasswordReminder = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnCloseApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUserName.Location = new System.Drawing.Point(30, 64);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(287, 25);
            this.txtLoginUserName.TabIndex = 1;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(30, 132);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(287, 25);
            this.txtLoginPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre: ";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(40, 40);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(335, 147);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignIn.ImageKey = "154346.png";
            this.btnSignIn.ImageList = this.ımageList1;
            this.btnSignIn.Location = new System.Drawing.Point(187, 213);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(127, 42);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "GİRİŞ YAP";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "signup-icon-29.jpg");
            this.ımageList1.Images.SetKeyName(1, "154346.png");
            this.ımageList1.Images.SetKeyName(2, "cross.png");
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSignUp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.ImageIndex = 0;
            this.btnSignUp.ImageList = this.ımageList1;
            this.btnSignUp.Location = new System.Drawing.Point(30, 213);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(130, 42);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "KAYIT OL";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblPasswordReminder
            // 
            this.lblPasswordReminder.AutoSize = true;
            this.lblPasswordReminder.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordReminder.ImageList = this.ımageList1;
            this.lblPasswordReminder.Location = new System.Drawing.Point(197, 284);
            this.lblPasswordReminder.Name = "lblPasswordReminder";
            this.lblPasswordReminder.Size = new System.Drawing.Size(114, 17);
            this.lblPasswordReminder.TabIndex = 7;
            this.lblPasswordReminder.Text = "Şifremi Unuttum";
            this.lblPasswordReminder.Click += new System.EventHandler(this.lblPasswordReminder_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.Transparent;
            this.grpLogin.Controls.Add(this.chkShowPassword);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.lblPasswordReminder);
            this.grpLogin.Controls.Add(this.txtLoginUserName);
            this.grpLogin.Controls.Add(this.btnSignUp);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.btnSignIn);
            this.grpLogin.Controls.Add(this.txtLoginPassword);
            this.grpLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.Location = new System.Drawing.Point(40, 193);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(335, 333);
            this.grpLogin.TabIndex = 8;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Giriş";
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(198, 174);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(122, 21);
            this.chkShowPassword.TabIndex = 3;
            this.chkShowPassword.Text = "Şifremi Göster";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ImageIndex = 2;
            this.btnCloseApp.ImageList = this.ımageList1;
            this.btnCloseApp.Location = new System.Drawing.Point(389, -1);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(36, 36);
            this.btnCloseApp.TabIndex = 28;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnSignIn;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 532);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblPasswordReminder;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.CheckBox chkShowPassword;
        public System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnCloseApp;
    }
}

