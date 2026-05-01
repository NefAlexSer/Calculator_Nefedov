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
using CalculatorLibrary;
using System.Globalization;

namespace Calculator_Nefedov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator Calc = new Calculator();
        double? currentValue;
        string pendingOperation;
        bool isNewInput = true;

        public MainWindow()
        {
            InitializeComponent();
            ResultWindow.Text = "0";
        }

        private void ButtonLogic(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string content = button.Content.ToString();

            if (isNewInput)
            {
                CurInput = "";
                isNewInput = false;
            }

            
            if (content == "." && CurInput.Contains("."))
                return;

            
            if (CurInput == "0" && content != ".")
            {
                CurInput = content;
            }
            else
            {
                CurInput += content;
            }

            UpdateDisplay();
        }

        private void OperationLogic(string Op)
        {
            
            if (!isNewInput && CurInput != "")
            {
                double currentNumber = double.Parse(CurInput, CultureInfo.InvariantCulture);

                if (currentValue != null && pendingOperation != null)
                {
                    currentValue = Calc.Calculate((double)currentValue, currentNumber, pendingOperation);
                    CurInput = currentValue.ToString();
                    UpdateDisplay();
                }
                else
                {
                    currentValue = currentNumber;
                }
            }

            if (Op == "-" && CurInput == "" && currentValue == null)
            {
                CurInput = "-";
                isNewInput = false;
                UpdateDisplay();
                return;
            }

            if (CurInput == "" && currentValue != null)
            {
                pendingOperation = Op;
                return;
            }

            pendingOperation = Op;
            isNewInput = true;

            UpdateDisplay();
        }

        private string CurInput = "";

        private void UpdateDisplay()
        {
            if (!isNewInput && !string.IsNullOrEmpty(CurInput))
            {
                ResultWindow.Text = CurInput;
            }
            else if (pendingOperation != null)
            {
                ResultWindow.Text = currentValue.ToString() + " " + pendingOperation;
            }
            else
            {
                ResultWindow.Text = currentValue.ToString();
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            OperationLogic("+");
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            OperationLogic("-");
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            OperationLogic("*");
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            OperationLogic("/");
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            OperationLogic("^");
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (pendingOperation != null && !isNewInput && CurInput != "")
            {
                double currentNumber = double.Parse(CurInput, CultureInfo.InvariantCulture);

                if (currentValue != null)
                {
                    double result = Calc.Calculate((double)currentValue, currentNumber, pendingOperation);
                    currentValue = result;
                    CurInput = result.ToString(CultureInfo.InvariantCulture);
                    pendingOperation = null;
                    isNewInput = true;
                    ResultWindow.Text = CurInput;
                }
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            currentValue = null;
            pendingOperation = null;
            CurInput = "";
            isNewInput = true;
            ResultWindow.Text = "0";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender, e);
        }
    }
}