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

namespace WpfApp1.Pages
{
    /// <summary>
    /// GelirEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class GelirEkle : Page
    {
        public GelirEkle()
        {
            InitializeComponent();
            BtnGeri.Click += BtnGeri_Click;
        }

        private void BtnGeri_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Pages/GelirGider.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
