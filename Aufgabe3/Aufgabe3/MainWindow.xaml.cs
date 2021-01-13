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

namespace Aufgabe3
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_rechnen_Click(object sender, RoutedEventArgs e)
        {
            if (btn_Tagen.IsChecked == true)
            {
                int Tage = Convert.ToInt32(textbox_Geschwindigkeit.Text);
                int resultat = 384400 / Tage / 24;
                textbox_Resultat.Text = resultat.ToString();
            }
            
            if (btn_Stunden.IsChecked == true)
            {
                int Stunden = Convert.ToInt32(textbox_Geschwindigkeit.Text);
                int resultat = 384400 / Stunden;
                textbox_Resultat.Text = resultat.ToString();
            }
        }

        private void btn_Tagen_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Stunden_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
