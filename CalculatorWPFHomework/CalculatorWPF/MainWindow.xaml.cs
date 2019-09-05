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
using CalculatorWPFHomework;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculatorMethod calc = new CalculatorMethod();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cmbox = Operations.Text;
            double value1 = double.Parse(TextBox1.Text);
            //change the string to double in the Text Box
            double value2 = double.Parse(TextBox2.Text);
            double output = 0;

            switch (cmbox)
            {
                case "Division":
                    output = calc.Divide(value1, value2);
                    MessageBox.Show(output.ToString());
                    break;
                case "Addition":
                    output = calc.Add(value1, value2);
                    MessageBox.Show(output.ToString());
                    break;
                case "Multiplication":
                    output = calc.Multiply(value1, value2);
                    MessageBox.Show(output.ToString());
                    break;
                case "Subtraction":
                    output = calc.Subtract(value1, value2);
                    MessageBox.Show(output.ToString());
                    break;
            }
            TextBox1.Text = String.Empty;
            TextBox2.Text = string.Empty;
            Operations.Text = string.Empty;
            //clear the fields when user press "ok" on the button
        }
    }
}
