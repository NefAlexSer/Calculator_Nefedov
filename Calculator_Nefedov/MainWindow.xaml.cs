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
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonLogic(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (CurInput.Length - 1 >= 0 && CurInput[CurInput.Length - 1] == '.' && (string)button.Content == ".")
                return;
            CurInput += button.Content;

            if (LastInput == "")
            {
                ResultWindow.Text = CurInput;
            }
            else
            {
                ResultWindow.Text = LastInput + CurInput;
            }
            
        }
        private void OperationLogic(string Op)
        {
            if (Op == "-" && CurInput == "")
            {
                CurInput += "-";
                if (LastInput == "")
                {
                    ResultWindow.Text = CurInput;
                }
                else
                {
                    ResultWindow.Text = LastInput + CurInput;
                }
                return;
            }
            if (CurInput == "" & FirstArg == "")
                return;
            if (FirstArg == "" && CurInput != "-" && CurInput != ".")
            {
                FirstArg = CurInput;
                Operation = Op;
                CurInput += Operation;
                LastInput = CurInput;
                ResultWindow.Text = LastInput;
                CurInput = "";
            }
        }

        string CurInput = "", Operation = "", FirstArg = "", SecondArg = "", LastInput = "", Result = "";

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
            if (FirstArg != "" && CurInput != ".")
            {
                SecondArg = CurInput;

                Result = Calc.Calculate(double.Parse(FirstArg, CultureInfo.InvariantCulture), double.Parse(SecondArg, CultureInfo.InvariantCulture), Operation).ToString();

                ResultWindow.Text = Result;

                CurInput = "";
                Operation = "";
                FirstArg = "";
                SecondArg = "";
                LastInput = "";
                Result = "";
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            CurInput = "";
            Operation = "";
            FirstArg = "";
            SecondArg = "";
            LastInput = "";
            Result = "";
            ResultWindow.Text = "";
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ButtonLogic(sender,e);
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
