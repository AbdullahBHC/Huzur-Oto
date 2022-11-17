using System;
using System.Collections.Generic;
using System.Linq;
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
    /// GelirGider.xaml etkileşim mantığı
    /// </summary>
    public partial class GelirGider : Page
    {
        public GelirGider()
        {
            InitializeComponent();
            BtnGeri.Click += BtnGeri_Click;
            BtnGelirEkle.Click +=(s,e)=> NavigationService.Content = new ArabaEkle();
            BtnGiderEkle.Click +=(s,e)=> NavigationService.Content = new GiderEkle();
            LbGelirler.ItemsSource = Veriler.Arabalar;
            LbGiderler.ItemsSource = Veriler.Gider;
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
