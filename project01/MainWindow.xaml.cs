using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace project01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EMath emath = new EMath();
        private double saveA = 0;

        private bool XPowYFlag = false;
        private bool YSqrtXFlag = false;

        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement v in Buttons.Children)
                if (v is Button button)
                    button.Click += ButtonClick;
        }
        private void ButtonClick(Object sender, RoutedEventArgs e)
        {
            try
            {
                string content = ((Button)e.OriginalSource).Content.ToString();

                switch (content)
                {
                    default:
                        if (Regex.IsMatch(Display.Text, "0|не число|Ошибка"))
                            Display.Text = content;
                        else
                            Display.Text += content;
                        break;

                    case "AC":
                        Display.Text = "0";
                        ResetFlags();
                        break;

                    case "=":
                        Result();
                        break;

                    case "+":
                    case "-":
                    case "/":
                    case "*":
                        if (!CheckFormat())
                            Display.Text += content;
                        break;
                    case ".":
                        Display.Text += ".";
                        break;

                    case "%":
                        if (Display.Text != "")
                            Display.Text = (Convert.ToDouble(Display.Text) / 100).ToString();
                        break;
                    case "±":
                        if (!CheckFormat())
                            Display.Text = (Convert.ToDouble(Display.Text) * (-1)).ToString();
                        break;

                    case "1/x":
                        Display.Text = Convert.ToDouble(Display.Text).ToString();
                        break;

                    case "x²":
                        Display.Text = Math.Pow(Convert.ToDouble(Display.Text), 2).ToString();
                        break;
                    case "xᵞ":
                        ResetFlags();
                        XPowYFlag = true;
                        saveA = Convert.ToDouble(Display.Text);
                        Display.Text = "";
                        break;

                    case "²√x":
                        Display.Text = Math.Sqrt(Convert.ToDouble(Display.Text)).ToString();
                        break;
                    case "ᵞ√x":
                        ResetFlags();
                        YSqrtXFlag = true;
                        saveA = Convert.ToDouble(Display.Text);
                        Display.Text = "";
                        break;

                    case "ln":
                        Display.Text = Math.Log(Convert.ToDouble(Display.Text)).ToString();
                        break;
                    case "log₁₀":
                        Display.Text = Math.Log10(Convert.ToDouble(Display.Text)).ToString();
                        break;

                    case "x!":
                        Display.Text = emath.Factorial(Convert.ToDouble(Display.Text)).ToString();
                        break;

                    case "sin":
                        Display.Text = Math.Sin(Convert.ToDouble(Display.Text.Replace('.', ','))).ToString().Replace(",", ".");
                        break;
                    case "cos":
                        Display.Text = Math.Cos(Convert.ToDouble(Display.Text.Replace('.', ','))).ToString().Replace(",", ".");
                        break;
                    case "tan":
                        Display.Text = Math.Tan(Convert.ToDouble(Display.Text.Replace('.', ','))).ToString().Replace(",", ".");
                        break;

                    case "e":
                        Display.Text += Math.E.ToString();
                        break;
                    case "π":
                        Display.Text += Math.PI.ToString();
                        break;

                    case "Rad":
                        Rad.Text = "Rad";
                        btnRadDeg.Content = "Deg";
                        break;
                    case "Deg":
                        Rad.Text = "";
                        btnRadDeg.Content = "Rad";
                        break;
                }
            }
            catch (Exception)
            {
                Display.Text = "Ошибка";
            }
        }

        private void ResetFlags()
        {
            XPowYFlag = false;
            YSqrtXFlag = false;
        }
        private bool CheckFormat() => Regex.IsMatch(Display.Text, @"[\+-/\*]$|не число|Ошибка");

        private void Result()
        {
            try
            {
                if (!XPowYFlag && !YSqrtXFlag)
                {
                    var answer = new DataTable().Compute(Display.Text, null).ToString().Replace(',', '.');
                    Display.Text = answer;
                }

                if (XPowYFlag)
                {
                    Display.Text = Math.Pow(saveA, Convert.ToDouble(Display.Text)).ToString();
                }

                if (YSqrtXFlag)
                {
                    Display.Text = Math.Pow(saveA, 1 / Convert.ToDouble(Display.Text)).ToString();
                }

                ResetFlags();
            }
            catch (Exception)
            {
                Display.Text = "Ошибка";
            }
        }
    }
}
