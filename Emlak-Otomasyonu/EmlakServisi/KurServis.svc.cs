using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmlakServisi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KurServis" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select KurServis.svc or KurServis.svc.cs at the Solution Explorer and start debugging.
    public class KurServis : IKurServis
    {
        public List<double> KurlariGetir(string kurTipi)
        {
          Random randomKur = new Random();
          List<double> kurlarListesi = new List<double>();
          for(var i =0; i<30;i++)
          {
           kurlarListesi.Add(randomKur.NextDouble() +15540);
          }

          return kurlarListesi;
        }

        public List<string> ParaBirimleriGetir()
        {
            List<string> Sehirler = new List<string>();
            Sehirler.Add("Adana");
            Sehirler.Add("Adıyaman");
            Sehirler.Add("Afyonkarahisar");
            Sehirler.Add("Ağrı");
            Sehirler.Add("Aksaray");
            Sehirler.Add("Amasya");
            Sehirler.Add("Ankara");
            Sehirler.Add("Antalya");
            Sehirler.Add("Ardahan");
            Sehirler.Add("Artvin");
            Sehirler.Add("Aydın");
            Sehirler.Add("Balıkesir");
            Sehirler.Add("Bartın");
            Sehirler.Add("Batman");
            Sehirler.Add("Bayburt");
            Sehirler.Add("Bilecik");
            Sehirler.Add("Bingöl");
            Sehirler.Add("Bitlis");
            Sehirler.Add("Bolu");
            Sehirler.Add("Burdur");
            Sehirler.Add("Bursa");
            Sehirler.Add("Çanakkale");
            Sehirler.Add("Çankırı");
            Sehirler.Add("Çorum");
            Sehirler.Add("Denizli");
            Sehirler.Add("Diyarbakır");
            Sehirler.Add("Düzce");
            Sehirler.Add("Edirne");
            Sehirler.Add("Elazığ");
            Sehirler.Add("Erzincan");
            Sehirler.Add("Erzurum");
            Sehirler.Add("Eskişehir");
            Sehirler.Add("Gaziantep");
            Sehirler.Add("Giresun");
            Sehirler.Add("Gümüşhane");
            Sehirler.Add("Hakkari");
            Sehirler.Add("Hatay");
            Sehirler.Add("Iğdır");
            Sehirler.Add("Isparta");
            Sehirler.Add("İstanbul");
            Sehirler.Add("İzmir");
            Sehirler.Add("Kahramanmaraş");
            Sehirler.Add("Karabük");
            Sehirler.Add("Kahraman");
            Sehirler.Add("Kars");
            Sehirler.Add("Kastamonu");
            Sehirler.Add("Kayseri");
            Sehirler.Add("Kırıkkale");
            Sehirler.Add("Kırklareli");
            Sehirler.Add("Kırşehir");
            Sehirler.Add("Kilis");
            Sehirler.Add("Kocaeli");
            Sehirler.Add("Konya");
            Sehirler.Add("Kütahya");
            Sehirler.Add("Malatya");
            Sehirler.Add("Manisa");
            Sehirler.Add("Mardin"); 
            Sehirler.Add("Mersin");
            Sehirler.Add("Muğla");
            Sehirler.Add("Muş");
            Sehirler.Add("Nevşehir");
            Sehirler.Add("Niğde");
            Sehirler.Add("Ordu");
            Sehirler.Add("Osmaniye");
            Sehirler.Add("Rize");
            Sehirler.Add("Sakarya");
            Sehirler.Add("Samsun");
            Sehirler.Add("Siirt");
            Sehirler.Add("Sinop");
            Sehirler.Add("Sivas");
            Sehirler.Add("Şanlıurfa");
            Sehirler.Add("Şırnak");
            Sehirler.Add("Tekirdağ");
            Sehirler.Add("Tokat");
            Sehirler.Add("Trabzon");
            Sehirler.Add("Tunceli");
            Sehirler.Add("Uşak");
            Sehirler.Add("Van");
            Sehirler.Add("Yalova");
            Sehirler.Add("Yozgat");
            Sehirler.Add("Zonguldak");




            return Sehirler;
        }
    }
}
