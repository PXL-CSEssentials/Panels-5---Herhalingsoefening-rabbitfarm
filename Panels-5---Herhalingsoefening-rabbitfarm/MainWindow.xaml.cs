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

namespace Panels_5___Herhalingsoefening_rabbitfarm
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

        private void Clear()
        {
            numberOfHousesTextBox.Text = "0";
            numberOfFieldsTextBox.Text = "0";
            numberOfMonthsTextBox.Text = "0";
            leapTextBox.Text = "0";
            outputTextBox.Text = "";
        }

        private void simulateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberOfHousesTextBox.Text, out int numberOfHouses)
                && int.TryParse(numberOfFieldsTextBox.Text, out int numberOfFields)
                && int.TryParse(numberOfMonthsTextBox.Text, out int numberOfMonths)
                && double.TryParse(leapTextBox.Text, out double leap))
            {
                int maxCapacity = numberOfHouses * 40 + numberOfFields * 100;
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= numberOfMonths; i++)
                {
                    if (i > 3)
                    {
                        leap = Math.Floor(1.5 * leap);
                        leap = Math.Min(leap, maxCapacity);
                    }
                    sb.AppendLine($"maand {i}: {leap}");
                }
                outputTextBox.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show(
                    "Ongeldige input in aantal huizen, aantal velden, aantal maanden " +
                    "of grootte sprong",
                    "Ongeldige Input",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void capacityButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberOfHousesTextBox.Text, out int numberOfHouses)
                && int.TryParse(numberOfFieldsTextBox.Text, out int numberOfFields))
            {
                outputTextBox.Text = $"De totale capaciteit van je boerderij is {numberOfHouses * 40 + numberOfFields * 100} konijnen.";
            }
            else
            {
                MessageBox.Show(
                    "Ongeldige input in aantal huizen of aantal velden",
                    "Ongeldige Input",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Clear();
        }
    }
}
