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

namespace CalculatorWPF
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

        private void BClick0(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text != "0")
                NumberInput.Text += "0";
        }

        private void BClick1(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text == "0")
                NumberInput.Text = "";
            NumberInput.Text += "1";
        }

        private void BClick2(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text == "0")
                NumberInput.Text = "";
            NumberInput.Text += "2";
        }

        private void BClick3(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text == "0")
                NumberInput.Text = "";
            NumberInput.Text += "3";
        }

        private void BClick4(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text == "0")
                NumberInput.Text = "";
            NumberInput.Text += "4";
        }

        private void BClick5(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text == "0")
                NumberInput.Text = "";
            NumberInput.Text += "5";
        }

        private void BClick6(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text == "0")
                NumberInput.Text = "";
            NumberInput.Text += "6";
        }

        private void BClick7(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text == "0")
                NumberInput.Text = "";
            NumberInput.Text += "7";
        }

        private void BClick8(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text == "0")
                NumberInput.Text = "";
            NumberInput.Text += "8";
        }

        private void BClick9(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text == "0")
                NumberInput.Text = "";
            NumberInput.Text += "9";
        }

        private void BClickMinus(object sender, RoutedEventArgs e)
        {
            if (PreviousValue.Text == "")
            {
                PreviousValue.Text = NumberInput.Text;
                Operator.Text = "-";
            }
            else
            {
                var val1 = double.Parse(PreviousValue.Text);
                var val2 = double.Parse(NumberInput.Text);
                string op = Operator.Text;
                Calculate(val1, val2, op);
                Operator.Text = "-";
            }
            NumberInput.Text = "0";
        }

        private void bClickResult(object sender, RoutedEventArgs e)
        {
            if (PreviousValue.Text != "")
            {
                var val1 = double.Parse(PreviousValue.Text);
                var val2 = double.Parse(NumberInput.Text);
                string op = Operator.Text;
                Calculate(val1, val2, op);
            }
        }

        private void bClickClear(object sender, RoutedEventArgs e)
        {
            NumberInput.Text = "0";
            PreviousValue.Text = "";
            Operator.Text = "";
        }

        private void bClickComma(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text == "0")
                NumberInput.Text = "";
            NumberInput.Text += ",";
        }

        private void bClickPlus(object sender, RoutedEventArgs e)
        {
            if (PreviousValue.Text == "")
            {
                PreviousValue.Text = NumberInput.Text;
                Operator.Text = "+";
            }
            else
            {
                var val1 = double.Parse(PreviousValue.Text);
                var val2 = double.Parse(NumberInput.Text);
                string op = Operator.Text;
                Calculate(val1, val2, op);
                Operator.Text = "+";
            }
            NumberInput.Text = "0";
        }

        private void BClickBack(object sender, RoutedEventArgs e)
        {
            if (NumberInput.Text.Length > 1) 
            { 
                NumberInput.Text = NumberInput.Text.Remove(NumberInput.Text.Length - 1);
            } 
            else// if (NumberInput.Text != "0")
            {
                NumberInput.Text = "0";
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Calculate(double val1, double val2, String op)
        {
            double result;
            if (op == "+")
            {
                result = val1 + val2;
            }
            else if (op == "-")
            {
                result = val1 - val2;
            }
            else
                return;
            result = Math.Round(result, 2);
            PreviousValue.Text = result.ToString();
        }
    }
}
