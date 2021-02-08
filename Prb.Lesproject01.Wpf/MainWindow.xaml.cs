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

namespace Prb.Lesproject01.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDoeBerekening_Click(object sender, RoutedEventArgs e)
        {
            int getal1;
            int getal2;
            int getal3;
            int getal4;
            int.TryParse(txtGetal1.Text, out getal1);
            int.TryParse(txtGetal2.Text, out getal2);
            int.TryParse(txtGetal3.Text, out getal3);
            int.TryParse(txtGetal4.Text, out getal4);

            txtGetal1.Text = getal1.ToString();
            txtGetal2.Text = getal2.ToString();
            txtGetal3.Text = getal3.ToString();
            txtGetal4.Text = getal4.ToString();


            int som = getal1 + getal2 + getal3 + getal4;
            double gemiddelde = (double)som / 4;
            long product = getal1 * getal2 * getal3 * getal4;

            lblSom.Content = som;
            lblGemiddelde.Content = gemiddelde.ToString("#,##0.00");
            lblProduct.Content = product;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtGetal1.Text = "";
            txtGetal2.Text = "";
            txtGetal3.Text = "";
            txtGetal4.Text = "";

            lblSom.Content = "";
            lblGemiddelde.Content = "";
            lblProduct.Content = "";

            txtGetal1.Focus();
        }
    }
}
