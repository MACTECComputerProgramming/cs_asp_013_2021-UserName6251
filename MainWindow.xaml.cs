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

namespace cspn_013_Ethan
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double total = 0.0;
            string length = "";
            double lengthTotal = 0;
            if (Six.IsChecked == true)
            {
                length = "Six Inch ";
                lengthTotal = 3.50;
            }
            else if (Foot.IsChecked == true)
            {
                length = "Foot Long";
                lengthTotal = 5.0;
            }
            string bread = "";
            double breadTotal = 0;
            if (Wheat.IsChecked == true)
            {
                bread = "Wheat, ";
                breadTotal = 0;
            }
            else if (Italian.IsChecked == true)
            {
                bread = "Italian,";
                breadTotal = 0;
            }
            else if (Flat.IsChecked == true)
            {
                bread = "Flat";
                breadTotal = .50;
            }
            string Meat = "";
            double meatTotal = 0.0;
            if (Ham.IsChecked == true)
            {
                Meat = "Ham,";
                meatTotal = 0;
            }
            else if (Chicken.IsChecked == true)
            {
                Meat = "Roasted Chicken,";
                meatTotal = 0;
            }
            else if (MeatBall.IsChecked == true)
            {
                Meat = "MeatBalls, ";
                meatTotal = 1.00;
            }
            else if (Steak.IsChecked == true)
            {
                Meat = "Steak, ";
                meatTotal = 0;
            }
            String cheese = " ";
            Double cheeseTotal = 0.0;
            sandwhichLabel.Content = (American.IsChecked == true) ? cheese = "American Cheese, " : "";
            totalLabel.Content = (American.IsChecked == true) ? cheeseTotal = 0.25 : 0.0;

            sandwhichLabel.Content = (Swiss.IsChecked == true) ? cheese = "Swiss Cheese, " : "";
            totalLabel.Content = (Swiss.IsChecked == true) ? cheeseTotal = 0.30 : 0.0;

            sandwhichLabel.Content = (Green.IsChecked == true) ? cheese = "PepperJack Cheese, " : "";
            totalLabel.Content = (Green.IsChecked == true) ? cheeseTotal = 0.75 : 0.0;

            String veggies = " ";
            Double veggieTotal = 0.0;
            sandwhichLabel.Content = (Cucumber.IsChecked == true) ? veggies = "Cucumbers" : "";

            sandwhichLabel.Content = (Green.IsChecked == true) ? veggies = "Green Peppers" : "";
            sandwhichLabel.Content = (Green.IsChecked == true) ? veggieTotal = 0.15 : 0.0;

            sandwhichLabel.Content = (Lettuce.IsChecked == true) ? veggies = "Lettuce" : "";
            sandwhichLabel.Content = (Lettuce.IsChecked == true) ? veggieTotal = 0.15 : 0.0;

            sandwhichLabel.Content = (Onion.IsChecked == true) ? veggies = "Red Onion" : "";
            sandwhichLabel.Content = (Onion.IsChecked == true) ? veggieTotal = 0.10 : 0.0;

            sandwhichLabel.Content = (All.IsChecked == true) ? veggies = "Cucumbers, Green Peppers, Lettuce, Red Onion" : "";
            sandwhichLabel.Content = (All.IsChecked == true) ? veggieTotal = 0.25 : 0.0;

            String special = " ";
            Double specialTotal = 0.0;
            if ((Foot.IsChecked == true) && (Wheat.IsChecked == true) && (MeatBall.IsChecked == true) && (American.IsChecked == true)) 
            {
                special = "Special ($2.00 off)";
                specialTotal = -2.00;
            }

            sandwhichLabel.Content = length + bread + Meat + cheese + veggies + special;

            totalLabel.Content = lengthTotal + breadTotal + meatTotal + cheeseTotal + veggieTotal + specialTotal;
        }
    }
}
