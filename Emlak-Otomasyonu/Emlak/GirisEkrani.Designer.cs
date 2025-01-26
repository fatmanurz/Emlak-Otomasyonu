namespace Emlak
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.button_girisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Kullanici_ad = new System.Windows.Forms.TextBox();
            this.textBox_kullanici_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_girisYap
            // 
            this.button_girisYap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_girisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_girisYap.Location = new System.Drawing.Point(163, 118);
            this.button_girisYap.Margin = new System.Windows.Forms.Padding(4);
            this.button_girisYap.Name = "button_girisYap";
            this.button_girisYap.Size = new System.Drawing.Size(280, 108);
            this.button_girisYap.TabIndex = 0;
            this.button_girisYap.Text = "Giriş Yap";
            this.button_girisYap.UseVisualStyleBackColor = false;
            this.button_girisYap.Click += new System.EventHandler(this.button_girisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Kullanici_ad
            // 
            this.textBox_Kullanici_ad.Location = new System.Drawing.Point(207, 28);
            this.textBox_Kullanici_ad.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Kullanici_ad.Name = "textBox_Kullanici_ad";
            this.textBox_Kullanici_ad.Size = new System.Drawing.Size(276, 22);
            this.textBox_Kullanici_ad.TabIndex = 2;
            this.textBox_Kullanici_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_kullanici_sifre
            // 
            this.textBox_kullanici_sifre.Location = new System.Drawing.Point(207, 68);
            this.textBox_kullanici_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_kullanici_sifre.Name = "textBox_kullanici_sifre";
            this.textBox_kullanici_sifre.PasswordChar = '*';
            this.textBox_kullanici_sifre.Size = new System.Drawing.Size(276, 22);
            this.textBox_kullanici_sifre.TabIndex = 2;
            this.textBox_kullanici_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(135, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(451, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Kayit
            // 
            this.button_Kayit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Kayit.Location = new System.Drawing.Point(2, 118);
            this.button_Kayit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Kayit.Name = "button_Kayit";
            this.button_Kayit.Size = new System.Drawing.Size(160, 108);
            this.button_Kayit.TabIndex = 0;
            this.button_Kayit.Text = "Kayıt";
            this.button_Kayit.UseVisualStyleBackColor = false;
            this.button_Kayit.Click += new System.EventHandler(this.button_Kayit_Click_1);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 239);
            this.ControlBox = false;
            this.Controls.Add(this.button_Kayit);
            this.Controls.Add(this.textBox_kullanici_sifre);
            this.Controls.Add(this.textBox_Kullanici_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_girisYap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(603, 286);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(603, 286);
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Emlak Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_girisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Kullanici_ad;
        private System.Windows.Forms.TextBox textBox_kullanici_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Kayit;
    }
}

