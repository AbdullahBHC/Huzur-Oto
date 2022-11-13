using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Datas;

namespace WpfApp1.Pages
{
    /// <summary>
    /// ArabaEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class ArabaEkle : Page
    {
        Araba Araba;
        Kasko Kasko;
        public ArabaEkle()
        {
            InitializeComponent();
            LbBoya.MouseEnter += (s, e) => LbBoya.Height = 100;
            LbBoya.MouseLeave += (s, e) => LbBoya.Height = 20;
            LbDegisen.MouseEnter += (s, e) => LbDegisen.Height = 100;
            LbDegisen.MouseLeave += (s, e) => LbDegisen.Height = 20;
            CbMarka.ItemsSource = new string[] 
            {
                "Alfa Romeo",
"Anadol",
"Aston Martin",
"Audi",
"Bentley",
"BMW",
"Bugatti",
"Buick",
"Cadillac",
"Chery",
"Chevrolet",
"Chrysler",
"Citroën",
"Dacia",
"Daewoo",
"Daihatsu",
"Dodge",
"DS Automobiles",
"Eagle",
"Ferrari",
"Fiat",
"Fisker",
"Ford",
"Geely",
"Honda",
"Hyundai",
"Ikco",
"Infiniti",
"Jaguar",
"Kia",
"Lada",
"Lamborghini",
"Lancia",
"Leapmotor",
"Lexus",
"Lincoln",
"Lotus",
"Marcos",
"Maserati",
"Maybach",
"Mazda",
"Mercedes - Benz",
"Mercury",
"MG",
"Mini",
"Mitsubishi",
"Moskwitsch",
"Nissan",
"Opel",
"Peugeot",
"Plymouth",
"Polestar",
"Pontiac",
"Porsche",
"Proton",
"Ravon",
"Renault",
"RKS",
"Rolls-Royce",
"Rover",
"Saab",
"Seat",
"Skoda",
"Smart",
"Subaru",
"Suzuki",
"Tata",
"Tesla",
"Tofaş",
"Toyota",
"Volkswagen",
"Volvo",
"XEV",
            };
            //this.Araba = araba;
            //if (araba != null)
            //{
            //    TxMarka.Text = araba.Marka;
            //    TxModel.Text = araba.Model;
            //    TxYıl.Text = araba.Yil.ToString();
            //    TxFiyat.Text = araba.Toplam_Tutar.ToString();
            //    ImgAraba.Source = araba.Resim;
            //}

            BtnGözat.Click += BtnGözat_Click;
            BtnTemizle.Click += BtnTemizle_Click;
            BtnKaydet.Click += BtnKaydet_Click;
            RbKasko.Checked += (s, e) => SpKaskoBilgileri.Visibility = Visibility.Visible;
            RbElden.Checked += (s, e) => SpKaskoBilgileri.Visibility = Visibility.Collapsed;
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxYıl.Text, out int yil);
            if (Araba == null)
            {
                Kasko = new Kasko()
                {
                    Sigorta_Sirketi = TxSigortaSirketi.Text,
                    Dosya_No = TxDosyaNumarasi.Text,
                    Police_No = TxPoliceNumarasi.Text,
                    Arac_Sahibi = TxAracSahibi.Text,
                    Telefon_No = TxTelefonNo.Text,
                    Plaka = TxPlaka.Text,
                    Tc_No = TxTcNo.Text,
                    Belge_Seri_No = TxBelgeSeriNo.Text,
                    Kaza_Tarihi = DpKazaTarihi.SelectedDate.Value,
                    Kaza_Adresi = TxKazaAdresi.Text,
                    Vuran_Surucu = TxVuranSurucu.Text,
                    Vuran_Tc = TxVuranTcNo.Text,
                    Vuran_Telefon_No = TxVuranTelefonNo.Text,
                    Eksper_Adi = TxEksperAdi.Text,
                    Eksper_Telefon_No = TxTelefonNo.Text,
                };
                Araba = new Araba()
                {
                    Marka = CbMarka.SelectedItem.ToString(),
                    Model = TxModel.Text,
                    Yil = yil,
                    Resim = (BitmapImage)ImgAraba.Source,
                    Kasko = Kasko
                };
                TxSigortaSirketi.Text = Kasko.Sigorta_Sirketi;
                if (CbTavanBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Tavan");
                if (CbKaputBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Kaput");
                if (CbOnTamponBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Ön Tampon");
                if (CbSolOnCamurlukBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Sol Ön Çamurluk");
                if (CbSolOnKapiBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Sol Ön Kapı");
                if (CbSolArkaKapiBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Sol Arka Kapı");
                if (CbSolArkaCamurlukBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Sol Arka Çamurluk");
                if (CbBagajBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Bagaj");
                if (CbArkaTamponBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Arka Tampon");
                if (CbSagOnCamurlukBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Sağ Ön Çamurluk");
                if (CbSagOnKapiBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Sağ Ön Kapı");
                if (CbSagArkaKapiBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Sağ Arka Kapı");
                if (CbSagArkaCamurlukBoya.IsChecked == true) Araba.Boyanan_Parcalar.Add("Sağ Arka Çamurluk");

                if (CbTavanDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Tavan");
                if (CbKaputDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Kaput");
                if (CbOnTamponDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Ön Tampon");
                if (CbSolOnCamurlukDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Sol Ön Çamurluk");
                if (CbSolOnKapiDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Sol Ön Kapı");
                if (CbSolArkaKapiDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Sol Arka Kapı");
                if (CbSolArkaCamurlukDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Sol Arka Çamurluk");
                if (CbBagajDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Bagaj");
                if (CbArkaTamponDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Arka Tampon");
                if (CbSagOnCamurlukDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Sağ Ön Çamurluk");
                if (CbSagOnKapiDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Sağ Ön Kapı");
                if (CbSagArkaKapiDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Sağ Arka Kapı");
                if (CbSagArkaCamurlukDegisen.IsChecked == true) Araba.Değişen_Parcalar.Add("Sağ Arka Çamurluk");

                if (RbKasko.IsChecked == true)
                    Araba.Kaskodan_Mi_Yapildi = true;

                else
                    Araba.Elden_Mi_Yapildi = false;

                Veriler.Arabalar.Add(Araba);
            }
            else
            {
                Araba.Marka = CbMarka.SelectedItem.ToString();
                Araba.Model = TxModel.Text;
                Araba.Yil = yil;
                Araba.Resim = (BitmapImage)ImgAraba.Source;
            }
            NavigationService.Content = new Arabalar();
        }

        private void BtnTemizle_Click(object sender, RoutedEventArgs e)
        {
            CbMarka.SelectedItem = null;
            TxModel.Text = null;
            TxYıl.Text = null;
            TxFiyat.Text = null;

            CbTavanBoya.IsChecked = false;
            CbTavanDegisen.IsChecked = false;

            CbKaputBoya.IsChecked = false;
            CbKaputDegisen.IsChecked = false;

            CbOnTamponBoya.IsChecked = false;
            CbOnTamponDegisen.IsChecked = false;

            CbSolOnCamurlukBoya.IsChecked = false;
            CbSolOnCamurlukDegisen.IsChecked = false;

            CbSolOnKapiBoya.IsChecked = false;
            CbSolOnKapiDegisen.IsChecked = false;

            CbSolArkaKapiBoya.IsChecked = false;
            CbSolArkaKapiDegisen.IsChecked = false;

            CbSolArkaCamurlukBoya.IsChecked = false;
            CbSolArkaCamurlukDegisen.IsChecked = false;

            CbArkaTamponBoya.IsChecked = false;
            CbArkaTamponDegisen.IsChecked = false;
            CbSagArkaCamurlukBoya.IsChecked = false;
            CbSagArkaCamurlukDegisen.IsChecked = false;
            CbBagajBoya.IsChecked = false;
            CbBagajDegisen.IsChecked = false;
            CbSagArkaKapiBoya.IsChecked = false;
            CbSagArkaKapiDegisen.IsChecked = false;

        }

        private void BtnGözat_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Resim Dosyaları|*-jpg; *.png",
                Title = "Resim Seç",
            };

            if (ofd.ShowDialog() == true)
            {
                SpArabaResim.Visibility = Visibility.Visible;
                ImgAraba.Visibility = Visibility.Visible;
                ImgAraba.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
    }
}
