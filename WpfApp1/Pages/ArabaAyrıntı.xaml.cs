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
    /// ArabaAyrıntı.xaml etkileşim mantığı
    /// </summary>
    public partial class ArabaAyrıntı : Page
    {

        public ArabaAyrıntı(Araba araba)
        {
            InitializeComponent();
            if (araba != null)
            {
                ImgAraba.Visibility = Visibility.Visible;
                BtnArabalaraDön.Visibility = Visibility.Visible;

                List<string> boyanan = new List<string>();
                boyanan = araba.Boyanan_Parcalar;

                if (boyanan.Count == 0)
                    LbBoya.Items.Add("Boya Yok.");

                for (int i = 0; i < boyanan.Count; i++)
                    LbBoya.Items.Add(boyanan[i]);

                List<string> degisen = new List<string>();
                degisen = araba.Değişen_Parcalar;

                if (degisen.Count == 0)
                    LbDegisen.Items.Add("Değişen Yok.");

                for (int i = 0; i < degisen.Count; i++)
                    LbDegisen.Items.Add(degisen[i]);

                if (araba.Kaskodan_Mi_Yapildi==false)
                    TxYapı.Text = "Elden Yapıldı";

                else
                    TxYapı.Text = "Kaskodan Yapıldı";

                TxMarka.Text = araba.Marka;
                TxModel.Text = araba.Model;
                TxYil.Text = araba.Yil.ToString();
                TxFiyat.Text = araba.Toplam_Tutar.ToString();
                ImgAraba.Source = araba.Resim;
                if (araba.Kasko!=null)
                {
                    SpKaskoBilgileri.Visibility = Visibility.Visible;
                    TxSigortaSirketi.Text = araba.Kasko.Sigorta_Sirketi;
                    TxDosyaNo.Text = araba.Kasko.Dosya_No;
                    TxPoliceNo.Text = araba.Kasko.Police_No;
                    TxAracSahibi.Text = araba.Kasko.Arac_Sahibi;
                    TxTelefonNo.Text = araba.Kasko.Telefon_No;
                    TxPlaka.Text = araba.Kasko.Plaka;
                    TxTcNo.Text = araba.Kasko.Tc_No;
                    TxBelgeSeriNo.Text = araba.Kasko.Belge_Seri_No;
                    TxKazaTarihi.Text = araba.Kasko.Kaza_Tarihi.ToString();
                    TxKazaAdresi.Text = araba.Kasko.Kaza_Adresi;
                    TxVuranSurucu.Text = araba.Kasko.Vuran_Surucu;
                    TxVuranTcNo.Text = araba.Kasko.Vuran_Tc;
                    TxVuranTelefonNo.Text = araba.Kasko.Vuran_Telefon_No;
                    TxEksperAdi.Text = araba.Kasko.Eksper_Adi;
                    TxEksperTelefonNo.Text = araba.Kasko.Eksper_Telefon_No;
                }
                else
                {
                    SpKaskoBilgileri.Visibility = Visibility.Collapsed;
                    TxSigortaSirketi.Text = null;
                    TxDosyaNo.Text = null;
                    TxPoliceNo.Text = null;
                    TxAracSahibi.Text = null;
                    TxTelefonNo.Text = null;
                    TxPlaka.Text = null;
                    TxTcNo.Text = null;
                    TxBelgeSeriNo.Text = null;
                    TxKazaTarihi.Text = null;
                    TxKazaAdresi.Text = null;
                    TxVuranSurucu.Text = null;
                    TxVuranTcNo.Text = null;
                    TxVuranTelefonNo.Text = null;
                    TxEksperAdi.Text = null;
                    TxEksperTelefonNo.Text = null;

                }
            }

            BtnArabalaraDön.MouseEnter += BtnGalerilereDön_MouseEnter;
            BtnArabalaraDön.MouseLeave += BtnGalerilereDön_MouseLeave;
            BtnArabalaraDön.Click += BtnGalerilereDön_Click;
        }
        private void BtnGalerilereDön_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnArabalaraDön.Content = "<";
            BtnArabalaraDön.Width = 20;
            BtnArabalaraDön.Height = 20;
        }

        private void BtnGalerilereDön_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnArabalaraDön.Content = "Galerilere Dön";
            BtnArabalaraDön.Width = 85;
            BtnArabalaraDön.Height = 30;
        }

        private void BtnGalerilereDön_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new Arabalar();
        }

        private void StackPanel_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
