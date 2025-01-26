using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void girişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tcKimlikEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tcKimlik = new TcKimlik();

            FormAc(ref tcKimlik);
        }

        private void girişEkranıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Form girisEkrani = new GirisEkrani();

            FormAc(ref girisEkrani);
         
        
        }

        void FormAc(ref Form form)
        {
            Form f = form;
             foreach (Form mdiChild in MdiChildren)
            {
                if (mdiChild.Text == f.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
              
            }

            f.MdiParent = this;
            f.Show();
        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kayıtEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form kayitEkrani = new Kayit();

            FormAc(ref kayitEkrani);
        }

        private void evEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form evEkleme = new EvEkleme();

            FormAc(ref evEkleme);
        }

        private void evSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form evSorgu = new EvListelemeSorgulama();

            FormAc(ref evSorgu);
        }

        private void satılanVeyaKiralananEvlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form satilikKiralik = new SatilanKiralananEvler();

            FormAc(ref satilikKiralik);
        }

        private void evSatışıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form evSatis = new MusteriEvSatis();

            FormAc(ref evSatis);
        }

        private void girişEkranıToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form kayitEkrani = new Kayit();

            FormAc(ref kayitEkrani);
        }

        private void evRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form evrapor = new Rapor1();

            FormAc(ref evrapor);
        }

        private void kiralıkEvRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form kiralik = new Rapor2();

            FormAc(ref kiralik);
        }

        private void satılıkEvRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form satilik = new Rapor3();

            FormAc(ref satilik);
        }

        private void üstÜsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void dikeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void evDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
