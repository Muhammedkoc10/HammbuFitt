
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordReminder));
            this.grpPasswordReminder = new System.Windows.Forms.GroupBox();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserNameReminder = new System.Windows.Forms.TextBox();
            this.btnPasswordReminder = new System.Windows.Forms.Button();
            this.txtEmailReminder = new System.Windows.Forms.TextBox();
            this.grpPasswordReminder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPasswordReminder
            // 
            this.grpPasswordReminder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpPasswordReminder.Controls.Add(this.btnBackToMainPage);
            this.grpPasswordReminder.Controls.Add(this.label2);
            this.grpPasswordReminder.Controls.Add(this.label1);
            this.grpPasswordReminder.Controls.Add(this.txtUserNameReminder);
            this.grpPasswordReminder.Controls.Add(this.btnPasswordReminder);
            this.grpPasswordReminder.Controls.Add(this.txtEmailReminder);
            this.grpPasswordReminder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPasswordReminder.Location = new System.Drawing.Point(12, 12);
            this.grpPasswordReminder.Name = "grpPasswordReminder";
            this.grpPasswordReminder.Size = new System.Drawing.Size(310, 273);
            this.grpPasswordReminder.TabIndex = 0;
            this.grpPasswordReminder.TabStop = false;
            this.grpPasswordReminder.Text = "Şifremi Unuttum";
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.BackColor = System.Drawing.Color.Pink;
            this.btnBackToMainPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainPage.Location = new System.Drawing.Point(173, 225);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(131, 42);
            this.btnBackToMainPage.TabIndex = 28;
            this.btnBackToMainPage.Text = "GERİ DÖN";
            this.btnBackToMainPage.UseVisualStyleBackColor = false;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnPasswordReminder_Click);
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
            // txtUserNameReminder
            // 
            this.txtUserNameReminder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameReminder.Location = new System.Drawing.Point(20, 50);
            this.txtUserNameReminder.Name = "txtUserNameReminder";
            this.txtUserNameReminder.Size = new System.Drawing.Size(287, 25);
            this.txtUserNameReminder.TabIndex = 8;
            this.txtUserNameReminder.Tag = "";
            // 
            // btnPasswordReminder
            // 
            this.btnPasswordReminder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordReminder.Location = new System.Drawing.Point(76, 158);
            this.btnPasswordReminder.Name = "btnPasswordReminder";
            this.btnPasswordReminder.Size = new System.Drawing.Size(166, 42);
            this.btnPasswordReminder.TabIndex = 11;
            this.btnPasswordReminder.Text = "ŞİFREMİ HATIRLAT";
            this.btnPasswordReminder.UseVisualStyleBackColor = true;
            this.btnPasswordReminder.Click += new System.EventHandler(this.btnPasswordReminder_Click);
            // 
            // txtEmailReminder
            // 
            this.txtEmailReminder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailReminder.Location = new System.Drawing.Point(20, 118);
            this.txtEmailReminder.Name = "txtEmailReminder";
            this.txtEmailReminder.Size = new System.Drawing.Size(287, 25);
            this.txtEmailReminder.TabIndex = 10;
            // 
            // PasswordReminder
            // 
            this.AcceptButton = this.btnPasswordReminder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(334, 297);
            this.Controls.Add(this.grpPasswordReminder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordReminder";
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
        private System.Windows.Forms.Button btnBackToMainPage;
    }
}