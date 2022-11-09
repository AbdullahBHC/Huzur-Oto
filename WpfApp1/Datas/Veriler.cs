using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media.Imaging;

namespace WpfApp1.Datas
{
    public static class Veriler
    {
        public static ObservableCollection<Araba> Arabalar = new ObservableCollection<Araba>();
        public static ObservableCollection<Kasko> Kaskolar = new ObservableCollection<Kasko>();
        //public static ObservableCollection<Gelir> Gelir = new ObservableCollection<Gelir>(); 
        //public static ObservableCollection<Gider> Gider = new ObservableCollection<Gider>();

        static Veriler()
        {
            Arabalar.Add(new Araba()
            {
                Marka = "Bmw",
                Model = "5.20d",
                Yil = 2015,
                Boyanan_Parcalar = { "Arka Tampon", "Ön Tampon", "Sol Ön Çamurluk", "Sol Ön Kapı" },
                Toplam_Tutar = 5000,
                Resim = new BitmapImage(new Uri("/Images/bmw520.png", UriKind.Relative)),
                Kaskodan_Mi_Yapildi=false,
                Elden_Mi_Yapildi=true
            });

            Arabalar.Add(new Araba()
            {
                Marka = "Peugeot",
                Model = "301",
                Yil = 2013,
                Boyanan_Parcalar = {"Sağ Ön Çamurluk" },
                Değişen_Parcalar = { "Kaput","Ön Tampon" },
                Toplam_Tutar = 5000,
                Resim = new BitmapImage(new Uri("/Images/peugeot301.png", UriKind.Relative)),
                Kaskodan_Mi_Yapildi = true,
                Elden_Mi_Yapildi = false
            });

            Kaskolar.Add(new Kasko()
            {
                Sigorta_Sirketi = "Allianz Sigorta",
                Dosya_No = "0123456789",
                Police_No = "0123456789",
                Arac_Sahibi = "Mehmet Bahçeci",
                Telefon_No = "0532 740 26 27",
                Plaka = "34 ANA 530",
                Tc_No = "012345678912",
                Belge_Seri_No = "0123456789",
                Kaza_Tarihi = new DateTime(2022,01,01),
                Kaza_Adresi="Kağıthane / İstanbul",
                Vuran_Surucu="Adile Bahçeci",
                Vuran_Tc="21987654321",
                Vuran_Telefon_No="0507 082 98 08",
                Eksper_Adi =" Abdullah Bahçeci",
                Eksper_Telefon_No="0507 045 56 53",
                Araba = Arabalar[1]
            });
            //Gelir.Add(new Gelir(){ });
            //Gider.Add(new Gider(){ });
        }
    }
}
