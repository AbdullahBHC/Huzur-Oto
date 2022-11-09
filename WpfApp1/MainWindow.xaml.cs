using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GrdArabalar.MouseLeftButtonDown += GrdArabalar_MouseLeftButtonDown;
            GrdKasko.MouseLeftButtonDown += GrdKasko_MouseLeftButtonDown;
            GrdGelirGider.MouseLeftButtonDown += GrdGelirGider_MouseLeftButtonDown;
        }

        private void GrdGelirGider_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Pages/GelirGider.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void GrdKasko_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Pages/KaskoIslemleri.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void GrdArabalar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Pages/Arabalar.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
