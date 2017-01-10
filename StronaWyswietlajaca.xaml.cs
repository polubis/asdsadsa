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

namespace Cukiernia
{
    /// <summary>
    /// Interaction logic for StronaWyswietlajaca.xaml
    /// </summary>
    public partial class StronaWyswietlajaca : Page
    {
        public StronaWyswietlajaca()
        {
            InitializeComponent();
        }


        private void Wyjscie(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NowaDostawa(object sender, RoutedEventArgs e)
        {

        }

        private void DodajSkladniki(object sender, RoutedEventArgs e)
        {
            OknoDodawaniaSkladnikow Okno = new OknoDodawaniaSkladnikow();
            Okno.Show();
        }

        private void NowyPrzepis(object sender, RoutedEventArgs e)
        {
            MainWindow Okno = new MainWindow();
            Okno.Show();
        }
    }
}
