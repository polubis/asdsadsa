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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Przepis NowyPrzepis = new Przepis();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(pobierzNazwe.Text) || string.IsNullOrEmpty(pobierzCzas.Text))
            {
                MessageBox.Show("Prosze uzupełnić wszystkie pola");
            }
            else 
            { 
                try
                {
                    NowyPrzepis.UstawNazweICzas(pobierzNazwe.Text, Convert.ToInt32(pobierzCzas.Text));
                    if(NowyPrzepis.CzyCzas()==false)
                    {
                        MessageBox.Show("Czas przygotowanie od 0 do 300");
                    }
                    else
                    {
                        StronaWyswietlajaca Strona = new StronaWyswietlajaca();
                        this.Ramka.NavigationService.Navigate(Strona);
                        Wyswietlacz.Text = "Przepis:" + pobierzNazwe.Text + "\n" + "Czas: " + pobierzCzas.Text;
                    }
                 
                }
                catch(Exception k)
                {
                    MessageBox.Show(k.Message);
                }
            }
       }

           

        
    }
}
