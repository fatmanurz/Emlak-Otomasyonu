namespace Emlak
{
    partial class AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.button_Ev_Ekleme = new System.Windows.Forms.Button();
            this.button_Ev_Sorgulama = new System.Windows.Forms.Button();
            this.button_Satilan_kiralanan_evler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Ev_Ekleme
            // 
            this.button_Ev_Ekleme.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_Ev_Ekleme.Location = new System.Drawing.Point(16, 15);
            this.button_Ev_Ekleme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Ev_Ekleme.Name = "button_Ev_Ekleme";
            this.button_Ev_Ekleme.Size = new System.Drawing.Size(303, 245);
            this.button_Ev_Ekleme.TabIndex = 0;
            this.button_Ev_Ekleme.Text = "Ev Ekleme";
            this.button_Ev_Ekleme.UseVisualStyleBackColor = false;
            this.button_Ev_Ekleme.Click += new System.EventHandler(this.button_Ev_Ekleme_Click);
            // 
            // button_Ev_Sorgulama
            // 
            this.button_Ev_Sorgulama.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_Ev_Sorgulama.Location = new System.Drawing.Point(327, 15);
            this.button_Ev_Sorgulama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Ev_Sorgulama.Name = "button_Ev_Sorgulama";
            this.button_Ev_Sorgulama.Size = new System.Drawing.Size(303, 245);
            this.button_Ev_Sorgulama.TabIndex = 0;
            this.button_Ev_Sorgulama.Text = "Ev Sorgulama / Ev Listeleme";
            this.button_Ev_Sorgulama.UseVisualStyleBackColor = false;
            this.button_Ev_Sorgulama.Click += new System.EventHandler(this.button_Ev_Sorgulama_Click);
            // 
            // button_Satilan_kiralanan_evler
            // 
            this.button_Satilan_kiralanan_evler.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_Satilan_kiralanan_evler.Location = new System.Drawing.Point(16, 267);
            this.button_Satilan_kiralanan_evler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Satilan_kiralanan_evler.Name = "button_Satilan_kiralanan_evler";
            this.button_Satilan_kiralanan_evler.Size = new System.Drawing.Size(613, 245);
            this.button_Satilan_kiralanan_evler.TabIndex = 0;
            this.button_Satilan_kiralanan_evler.Text = "Satılan veya Kiralanan Evler";
            this.button_Satilan_kiralanan_evler.UseVisualStyleBackColor = false;
            this.button_Satilan_kiralanan_evler.Click += new System.EventHandler(this.button_Satilan_kiralanan_evler_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(648, 518);
            this.Controls.Add(this.button_Ev_Sorgulama);
            this.Controls.Add(this.button_Satilan_kiralanan_evler);
            this.Controls.Add(this.button_Ev_Ekleme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emlakçı Ana Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaMenu_FormClosing);
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Ev_Ekleme;
        private System.Windows.Forms.Button button_Ev_Sorgulama;
        private System.Windows.Forms.Button button_Satilan_kiralanan_evler;
    }
}