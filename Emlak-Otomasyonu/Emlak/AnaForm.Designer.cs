namespace Emlak
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tcKimlikEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evSatışıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılanVeyaKiralananEvlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralıkEvRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılıkEvRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üstÜsteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcKimlikEkranıToolStripMenuItem,
            this.anaMenüToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tcKimlikEkranıToolStripMenuItem
            // 
            this.tcKimlikEkranıToolStripMenuItem.Name = "tcKimlikEkranıToolStripMenuItem";
            this.tcKimlikEkranıToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.tcKimlikEkranıToolStripMenuItem.Text = "Tc Kimlik doğrulama ekranı";
            this.tcKimlikEkranıToolStripMenuItem.Click += new System.EventHandler(this.tcKimlikEkranıToolStripMenuItem_Click);
            // 
            // anaMenüToolStripMenuItem
            // 
            this.anaMenüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evEklemeToolStripMenuItem,
            this.evSorgulamaToolStripMenuItem,
            this.satılanVeyaKiralananEvlerToolStripMenuItem});
            this.anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            this.anaMenüToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.anaMenüToolStripMenuItem.Text = "Ana Menü";
            this.anaMenüToolStripMenuItem.Click += new System.EventHandler(this.anaMenüToolStripMenuItem_Click);
            // 
            // evEklemeToolStripMenuItem
            // 
            this.evEklemeToolStripMenuItem.Name = "evEklemeToolStripMenuItem";
            this.evEklemeToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.evEklemeToolStripMenuItem.Text = "Ev ekleme";
            this.evEklemeToolStripMenuItem.Click += new System.EventHandler(this.evEklemeToolStripMenuItem_Click);
            // 
            // evSorgulamaToolStripMenuItem
            // 
            this.evSorgulamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evSatışıToolStripMenuItem});
            this.evSorgulamaToolStripMenuItem.Name = "evSorgulamaToolStripMenuItem";
            this.evSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.evSorgulamaToolStripMenuItem.Text = "Ev sorgulama /Ev listeleme";
            this.evSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.evSorgulamaToolStripMenuItem_Click);
            // 
            // evSatışıToolStripMenuItem
            // 
            this.evSatışıToolStripMenuItem.Name = "evSatışıToolStripMenuItem";
            this.evSatışıToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.evSatışıToolStripMenuItem.Text = "Ev satışı";
            this.evSatışıToolStripMenuItem.Click += new System.EventHandler(this.evSatışıToolStripMenuItem_Click);
            // 
            // satılanVeyaKiralananEvlerToolStripMenuItem
            // 
            this.satılanVeyaKiralananEvlerToolStripMenuItem.Name = "satılanVeyaKiralananEvlerToolStripMenuItem";
            this.satılanVeyaKiralananEvlerToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.satılanVeyaKiralananEvlerToolStripMenuItem.Text = "Satılan veya kiralanan evler";
            this.satılanVeyaKiralananEvlerToolStripMenuItem.Click += new System.EventHandler(this.satılanVeyaKiralananEvlerToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evRaporuToolStripMenuItem,
            this.kiralıkEvRaporuToolStripMenuItem,
            this.satılıkEvRaporuToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // evRaporuToolStripMenuItem
            // 
            this.evRaporuToolStripMenuItem.Name = "evRaporuToolStripMenuItem";
            this.evRaporuToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.evRaporuToolStripMenuItem.Text = "Ev Raporu";
            this.evRaporuToolStripMenuItem.Click += new System.EventHandler(this.evRaporuToolStripMenuItem_Click);
            // 
            // kiralıkEvRaporuToolStripMenuItem
            // 
            this.kiralıkEvRaporuToolStripMenuItem.Name = "kiralıkEvRaporuToolStripMenuItem";
            this.kiralıkEvRaporuToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.kiralıkEvRaporuToolStripMenuItem.Text = "Kiralık ev raporu";
            this.kiralıkEvRaporuToolStripMenuItem.Click += new System.EventHandler(this.kiralıkEvRaporuToolStripMenuItem_Click);
            // 
            // satılıkEvRaporuToolStripMenuItem
            // 
            this.satılıkEvRaporuToolStripMenuItem.Name = "satılıkEvRaporuToolStripMenuItem";
            this.satılıkEvRaporuToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.satılıkEvRaporuToolStripMenuItem.Text = "Satılık ev raporu";
            this.satılıkEvRaporuToolStripMenuItem.Click += new System.EventHandler(this.satılıkEvRaporuToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yatayToolStripMenuItem,
            this.dikeyToolStripMenuItem,
            this.üstÜsteToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // yatayToolStripMenuItem
            // 
            this.yatayToolStripMenuItem.Name = "yatayToolStripMenuItem";
            this.yatayToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.yatayToolStripMenuItem.Text = "Yatay ";
            this.yatayToolStripMenuItem.Click += new System.EventHandler(this.yatayToolStripMenuItem_Click);
            // 
            // dikeyToolStripMenuItem
            // 
            this.dikeyToolStripMenuItem.Name = "dikeyToolStripMenuItem";
            this.dikeyToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.dikeyToolStripMenuItem.Text = "Dikey";
            this.dikeyToolStripMenuItem.Click += new System.EventHandler(this.dikeyToolStripMenuItem_Click);
            // 
            // üstÜsteToolStripMenuItem
            // 
            this.üstÜsteToolStripMenuItem.Name = "üstÜsteToolStripMenuItem";
            this.üstÜsteToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.üstÜsteToolStripMenuItem.Text = "Üst üste";
            this.üstÜsteToolStripMenuItem.Click += new System.EventHandler(this.üstÜsteToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 641);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tcKimlikEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaMenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılanVeyaKiralananEvlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evSatışıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralıkEvRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılıkEvRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üstÜsteToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}