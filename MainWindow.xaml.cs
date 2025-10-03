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

        private int mathCounter;

        public MainWindow()
        {
            InitializeComponent();
        }

        Button[] buttonArray = new Button[14];
        public static int[] Zwischenergebnis = new int[2];
        public static double[] zahlenEingegeben = new double[2];

        Button one = new Button();
        Button two = new Button();
        Button three = new Button();
        Button four = new Button();
        Button five = new Button();
        Button six = new Button();
        Button seven = new Button();
        Button eight = new Button();
        Button nine = new Button();
        Button addition = new Button();
        Button subtraction = new Button();
        Button multiplication = new Button();
        Button division = new Button();
        Button equals = new Button();

        public void createButton()
        {
            buttonArray[0] = one;
            buttonArray[1] = two;
            buttonArray[2] = three;
            buttonArray[3] = four;
            buttonArray[4] = five;
            buttonArray[5] = six;
            buttonArray[6] = seven;
            buttonArray[7] = eight;
            buttonArray[8] = nine;
            buttonArray[9] = addition;
            buttonArray[10] = subtraction;
            buttonArray[11] = multiplication;
            buttonArray[12] = division;
            buttonArray[13] = equals;
        }

        public void berechneErgebnis()
        {
            string ZwischenergebnisA_String = Ergebnis.Text;
            double ZwischenergebnisA_Double = double.Parse(ZwischenergebnisA_String);
            zahlenEingegeben[0] = ZwischenergebnisA_Double;
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
            berechneErgebnis();
            mathCounter = 1;
            this.Ergebnis.Text += "+";
        }

        // man muss noch Umweg +/- Button gehen, sonst Fehler 
        public void button_Subtraction(object sender, RoutedEventArgs e)
        {
            berechneErgebnis(); 
            this.Ergebnis.Text += "-"; 
            mathCounter = 2;
        }

        private void button_Multiplication(object sender, RoutedEventArgs e)
        {
            berechneErgebnis();
            mathCounter = 3;
            this.Ergebnis.Text += "*";
        }
        public void button_Division(object sender, RoutedEventArgs e)
        {
            berechneErgebnis();
            mathCounter = 4;
            this.Ergebnis.Text += "/";
        }
        
        public void button_Comma(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text += ",";
        }

        public void button_AllClear(object sender, RoutedEventArgs e)
        {
            this.Ergebnis.Text = "";
        }

        public void button_Equals(object sender, RoutedEventArgs e)
        {
            String ZwischenergebnisB_String = this.Ergebnis.Text;
            String StringNew = ZwischenergebnisB_String.Substring(1);
            double ZwischenergebnisB_double = Int32.Parse(StringNew);

            zahlenEingegeben[1] = ZwischenergebnisB_double;

            switch (mathCounter)
            {
                case 1:
                    Double ErgebnisAdditon = zahlenEingegeben[0] + zahlenEingegeben[1];
                    this.Ergebnis.Text = String.Concat(ErgebnisAdditon);
                    break;
                case 2:
                    Double ErgebnisSubtraction = zahlenEingegeben[0] - zahlenEingegeben[1];
                    this.Ergebnis.Text = String.Concat(ErgebnisSubtraction);
                    break;
                case 3:
                    Double ErgebnisMultiplication = zahlenEingegeben[0] * zahlenEingegeben[1];
                    this.Ergebnis.Text = String.Concat(ErgebnisMultiplication);
                    break;
                case 4:
                    Double ErgebnisDivision = zahlenEingegeben[0] / zahlenEingegeben[1];
                    this.Ergebnis.Text = String.Concat(ErgebnisDivision);
                    break;
                default:
                    this.Ergebnis.Text = "Empty";
                    break;
            }
        }

        public void button_Reframe(object sender, RoutedEventArgs e)
        {
            double NumberReframe = double.Parse(this.Ergebnis.Text) * -1;
            this.Ergebnis.Text = NumberReframe.ToString();

        }

    }
}