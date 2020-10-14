using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Simple_Currency_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CurrencyController currencyController;
        public MainWindow()
        {
            InitializeComponent();
            currencyController = new CurrencyController();
        }

        private void hitungButton_Click(object sender, RoutedEventArgs e)
        {
            var nominalString = inputTextBox.Text;

            var result = "Inputan tidak valid";

            if(currencyController.isAllowed(nominalString))
            {
                result = "Rp. " + currencyController.usdToIdr(nominalString);
            }

            resultLabel.Content = result;
            
        }
    }
}
