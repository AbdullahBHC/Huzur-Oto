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
            LbArabalar.ItemsSource = Veriler.Arabalar;
            MiSil.Click += MiSil_Click;
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
                }
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
