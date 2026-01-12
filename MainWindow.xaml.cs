using System;
using System.IO;
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
        private static int mathOperator;

        public MainWindow()
        {
            InitializeComponent();
        }

        public static double[] zahlenEingegeben = new double[2];

        public void berechneErgebnis()
        {
            if (double.TryParse(Ergebnis.Text, out double ersteZahl))
            {
                zahlenEingegeben[0] = ersteZahl;
                Ergebnis.Text = ""; // Leeren für die zweite Zahl
            }
            else
            {
                // Optional: Fehlermeldung
                MessageBox.Show("Ungültige Eingabe für die erste Zahl");
            }
        }

        private void button_Close(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text = string.Empty;
        }

        private void button_Zero(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "0";
        }

        private void button_1(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "1";
        }

        private void button_2(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "2";
        }

        private void button_3(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "3";
        }

        private void button_4(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "4";
        }

        private void button_5(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "5";
        }

        private void button_6(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "6";
        }

        private void button_7(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "7";
        }

        private void button_8(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "8";
        }

        private void button_9(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += "9";
        }

        public void button_Addition(object sender, RoutedEventArgs e)
        {
            mathOperator = 1;
            berechneErgebnis();
        }

        public void button_Subtraction(object sender, RoutedEventArgs e)
        {
            mathOperator = 2;
            berechneErgebnis();
        }

        private void button_Multiplication(object sender, RoutedEventArgs e)
        {
            mathOperator = 3;
            berechneErgebnis();
        }
        public void button_Division(object sender, RoutedEventArgs e)
        {
            mathOperator = 4;
            berechneErgebnis();
        }

        public void button_Point(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += ".";
        }

        public void button_Reframe(object sender, RoutedEventArgs e)
        {
            double NumberReframe = double.Parse(this.Ergebnis.Text) * -1;
            this.Ergebnis.Text = NumberReframe.ToString();
        }

        public void button_AllClear(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text = "";
        }

        public void button_Equals(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(Ergebnis.Text, out double zweiteZahl))
            {
                Ergebnis.Text = "Ungültige Eingabe";
                return;
            }

            zahlenEingegeben[1] = zweiteZahl;

            double result = 0;

            switch (mathOperator)
            {
                case 1:
                    result = zahlenEingegeben[0] + zahlenEingegeben[1];
                    break;
                case 2:
                    result = zahlenEingegeben[0] - zahlenEingegeben[1];
                    break;
                case 3:
                    result = zahlenEingegeben[0] * zahlenEingegeben[1];
                    break;
                case 4:
                    if (zahlenEingegeben[1] == 0)
                    {
                        Ergebnis.Text = "Fehler: /0";
                        return;
                    }
                    result = zahlenEingegeben[0] / zahlenEingegeben[1];
                    break;
                default:
                    Ergebnis.Text = "Kein Operator";
                    return;
            }

            Ergebnis.Text = result.ToString();
        }

        
        public void toCSVfile()
        {
            String folderPath = "C:\\Users\\sebas\\OneDrive\\Desktop\\Coding\\C#\\Taschenrechner";
            String filePath = System.IO.Path.Combine(folderPath, "export.csv");  // Kombiniert Ordner + Dateiname

            try
            {
                File.WriteAllText(filePath, Ergebnis.Text);
                MessageBox.Show("Export erfolgreich!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}");
            }
        }

        // CSV-Export
        private void Button_Export(object sender, RoutedEventArgs e)
        {
            toCSVfile();
        }

    }
}