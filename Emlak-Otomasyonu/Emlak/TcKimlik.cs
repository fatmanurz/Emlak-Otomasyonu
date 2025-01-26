using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Emlak.TCKimlikDogrulama;
namespace Emlak
{
    public partial class TcKimlik : Form
    {
        public TcKimlik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long TcKimlikNo = Convert.ToInt64(txtTCKimlikNo.Text);
            string Ad = txtAd.Text.ToUpper();
            string Soyad = txtSoyad.Text.ToUpper();
            int DogumYili = Convert.ToInt32(txtDogumYili.Text);
            KPSPublicSoapClient servis = new KPSPublicSoapClient();
            bool sonuc = servis.TCKimlikNoDogrula(TcKimlikNo, Ad, Soyad, DogumYili);
            if (sonuc == true)
            {       MessageBox.Show("Kullanıcı gerçek kişi", "Doğrulama başarılı!!");

            // Yeni formu aç
            GirisEkrani loginForm = new GirisEkrani();
            loginForm.Show();

            // Bu formu kapat
            this.Hide();
       
            }// Alternatif olarak this.Close() kullanılabilir
            else
            MessageBox.Show("Kullanıcı yok", "Doğrulama başarısız!!");
            
            this.Hide();
        }
    }
}
