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
    /// GiderEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class GiderEkle : Page
    {
        Gider Gider;
        public GiderEkle()
        {
            InitializeComponent();
            BtnGeri.Click +=(s,e) => NavigationService.GoBack();
            BtnTemizle.Click += BtnTemizle_Click;
            BtnKaydet.Click += BtnKaydet_Click;

            CbGiderTuru.ItemsSource = new string[] { "Nalbur","Kira","Fatura","Eleman Maaşı","Harici Usta Ödemesi","Dükkan Harcaması","Diğer"};
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxUrunAdet.Text, out int urunadet);
            int.TryParse(TxUrunAdetFiyat.Text, out int urunadetfiyat);
            decimal.TryParse(TxUrunAdetFiyat.Text, out decimal fiyat);
            if (Gider == null)
            {
                Gider = new Gider()
                {
                    Urun_Adi = TxUrunAdi.Text,
                    Urun_Adet = urunadet,
                    Urun_Adet_Fiyat = urunadetfiyat,
                    Gider_Turu = CbGiderTuru.SelectedItem.ToString(),
                    Toplam_Fiyat = fiyat,
                };

                Veriler.Gider.Add(Gider);
                NavigationService.Content = new GelirGider();
            }
        }

        private void BtnTemizle_Click(object sender, RoutedEventArgs e)
        {
            TxFiyat.Text = null;
            TxUrunAdet.Text = null;
            TxUrunAdetFiyat.Text = null;
            TxUrunAdi.Text = null;
            CbGiderTuru.SelectedItem = null;
        }
    }
}
