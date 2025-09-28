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

namespace Taschenrechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Partielle Klasse wird auch in anderen Dokument definiert (Verbindung zu XAML)
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int[] zahlenEingegeben = new int[10];

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text = string.Empty;
        }

        private void Button_0(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text = "0";
        }

        private void Button_1(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "1";
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "2";
        }

        private void Button_3(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "3";
        }

        private void Button_4(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "4";
        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "5";
        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "6";
        }

        private void Button_Plus(object sender, RoutedEventArgs e)
        {
            String Zwischenergebnis_String = this.Ergebnis.Text;
            int Zwischenergebnis_int = Int32.Parse(Zwischenergebnis_String);

            zahlenEingegeben[0] = Zwischenergebnis_int;
            this.Ergebnis.Text = "+";
        }

        private void Button_7(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "7";
        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "8";
        }

        private void Button_9(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "9";
        }

        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text = "-";
        }

        private void Button_Komma(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += ",";
        }

        private void Button_Negieren(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text = "";
        }

        private void Button_Istgleich(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < zahlenEingegeben.Length; i++) 
            {
                int Ergebnis = zahlenEingegeben[i];

            }
            this.Ergebnis.Text = Ergebnis.ToString();
        }
    }
}