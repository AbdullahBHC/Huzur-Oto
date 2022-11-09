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
    /// KaskoIslemleri.xaml etkileşim mantığı
    /// </summary>
    public partial class KaskoIslemleri : Page
    {
        public KaskoIslemleri()
        {
            InitializeComponent();
            BtnGeri.Click += BtnGeri_Click;
            LbKaskolar.ItemsSource = Veriler.Kaskolar;
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
