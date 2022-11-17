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
    /// Arabalar.xaml etkileşim mantığı
    /// </summary>
    public partial class Arabalar : Page
    {
        public Arabalar()
        {
            InitializeComponent();
            BtnGeri.Click += BtnGeri_Click;
            LbArabalar.MouseDoubleClick += LbArabalar_MouseDoubleClick;
            MiDüzenle.Click += MiDüzenle_Click;
            MiSil.Click += MiSil_Click;
            BtnArabaEkle.Click += BtnArabaEkle_Click;
            LbArabalar.ItemsSource = Veriler.Arabalar;
        }

        private void LbArabalar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Araba SeçiliAraba = (Araba)LbArabalar.SelectedItem;
            if (SeçiliAraba != null)
            {
                NavigationService.Content = new ArabaAyrıntı(SeçiliAraba);
            }
        }

        private void BtnArabaEkle_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new ArabaEkle();
        }

        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            Araba SeçiliAraba = (Araba)LbArabalar.SelectedItem;
            if (SeçiliAraba != null)
            {
                var cevap = MessageBox.Show("Seçili Araba Silinsin Mi ?", "Araba Silme İşlemi", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.Arabalar.Remove(SeçiliAraba);
                    Veriler.Kaskolar.Remove(SeçiliAraba.Kasko);
                }
            }
        }

        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        {
            Araba SeçiliAraba = (Araba)LbArabalar.SelectedItem;
            if (SeçiliAraba != null)
            {
                //NavigationService.Content = new GaleriKayıtPage(SeçiliGaleri);
            }
        }

        private void BtnGeri_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.Visibility = Visibility.Visible;
            Window win = (Window)this.Parent;
            win.Close();
        }
    }
}
