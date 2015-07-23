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

namespace OpenCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double value = 0;
        bool isready = false;
        string operation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if ((result.Text == "0")||(isready)) 
            {
                result.Clear(); ///clear results if bool is false or result is 0.
            }
            string d = (sender as Button).Content.ToString();
            result.Text = result.Text + d;
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "0"; ///reset with CE
        }

        private void pi_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "3.141592653589793"; ///Pi mmmm Pi Flavor
        }

        private void op(object sender, RoutedEventArgs e)
        {
            
            string d = (sender as Button).Content.ToString(); ///get string data on button being pressed.
            operation = d;
            value = double.Parse(result.Text); ///parse value from result.text
            isready = true;

        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "÷":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;

            }
        }
    }
}
