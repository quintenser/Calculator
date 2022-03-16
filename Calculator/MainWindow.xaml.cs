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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int X = 0;
        public int Y = 0;
        public int calculatedResult = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void parseInput(object sender, RoutedEventArgs e)
        {   
            try { X = Int32.Parse(inputX.Text); }
            catch
            {
                string msg = "X is geen getal.";
                string title = "Verkeerde invoer";
                MessageBox.Show(msg, title);
                return;
            }

            try { Y = Int32.Parse(inputY.Text); }
            catch
            {
                string msg = "Y is geen getal.";
                string title = "Verkeerde invoer";
                MessageBox.Show(msg, title);
                return;
            }
        }
        private void ShowResult(object sender, RoutedEventArgs e)
        {
            try {if (calculatedResult < 0)
                {
                    throw new NegativeResultException("");
                }
                result_Copy.Text = Convert.ToString(calculatedResult);
                result.Text = Convert.ToString(calculatedResult);
            }

            catch (NegativeResultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
            
        }
        private void NumY_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NumX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, RoutedEventArgs e)
        {

        }

        private void add(object sender, RoutedEventArgs e)
        {
            parseInput(sender, e);
            calculatedResult = X + Y;
            ShowResult(sender, e);
        }

        private void subtract(object sender, RoutedEventArgs e)
        {
            parseInput(sender, e);
            calculatedResult = X - Y;
            ShowResult(sender, e);
        }
        private void multiply(object sender, RoutedEventArgs e)
        {
            parseInput(sender, e);
            calculatedResult = X * Y;
            ShowResult(sender, e);
        }
        private void divide(object sender, RoutedEventArgs e)
        {
            parseInput(sender, e);
            calculatedResult = X / Y;
            ShowResult(sender, e);
        }
        private void root(object sender, RoutedEventArgs e)
        {
            parseInput(sender, e);
            var doubleX = Convert.ToDouble(X);
            calculatedResult = (int)Math.Sqrt(doubleX);
            ShowResult(sender, e);
        }
        private void expone(object sender, RoutedEventArgs e)
        {
            parseInput(sender, e);
            var exponeX = Convert.ToDouble(X);
            var exponeY = Convert.ToDouble(Y);
            calculatedResult = (int)Math.Pow(exponeX, exponeY);
            ShowResult (sender, e);
        }
    }
}
