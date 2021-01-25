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
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double a, b, c, bx2, inside, ac, fourAc;

        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            Label_Calculation.Content = "";
            TextBox_aCoefficient.Text = "";
            TextBox_bCoefficient.Text = "";
            TextBox_cCoefficient.Text = "";
        }

        public void Button_Help(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            a = ValidateACoefficient();
            b = ValidateBCoefficient();
            c = ValidateCCoefficient();

            bx2 = b * b;
            ac = a * c;
            fourAc = 4 * ac;
            inside = bx2 - fourAc;
            Complex sq = Complex.Sqrt(inside); ;
            Complex c1 = -b + sq;
            Complex c2 = -b - sq;
            Label_Calculation.Content = "x1 = " + c1 / (2 * a) + "\n" + "x2 = " + c2 / (2 * a);
        }

        private double ValidateACoefficient()
        {
            bool validResponse = false;
            double userInput = 0;

            do
            {
                if (double.TryParse(TextBox_aCoefficient.Text, out double aCoefficient))
                {
                    userInput = aCoefficient;
                    validResponse = true;
                }
                else
                {
                    Label_Calculation.Content = "Please enter a vaild integer";
                    validResponse = false;
                }
            } while (!validResponse);

            return userInput;
        }

        private double ValidateBCoefficient()
        {
            bool validResponse = false;
            double userInput = 0;

            do
            {
                if (double.TryParse(TextBox_bCoefficient.Text, out double aCoefficient))
                {
                    userInput = aCoefficient;

                    validResponse = true;
                }
                else
                {
                    Label_Calculation.Content = "Please enter a vaild integer";
                    validResponse = false;
                }
            } while (!validResponse);

            return userInput;
        }

        private double ValidateCCoefficient()
        {
            bool validResponse = false;
            double userInput = 0;

            do
            {
                if (double.TryParse(TextBox_cCoefficient.Text, out double aCoefficient))
                {
                    userInput = aCoefficient;
                    validResponse = true;
                }
                else
                {
                    Label_Calculation.Content = "Please enter a vaild integer";
                    validResponse = false;
                }
            } while (!validResponse);

            return userInput;
        }
    }
}