using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeDrink.xaml
    /// </summary>
    public partial class CustomizeDrink : UserControl
    {
        Drink drink;
        Order order;
        JerkedSoda js;

        public CustomizeDrink(string buttonName, object ObjectName, object Order)
        {
            InitializeComponent();
            DrinkSwitch(buttonName);
            drink = (Drink)ObjectName;
            order = (Order)Order;
            AlterText(drink);
        }

        public void AlterText(Drink drink)
        {
            CustomizeDrinkLabel.Text += drink.DrinkName();
        }

        public void DrinkSwitch(string buttonName)
        {
            switch (buttonName)
            {
                case "Cowboy Coffee":
                    DisplayCowboyCoffee();
                    break;
                case "Texas Tea":
                    DisplayTexasTea();
                    break;
                case "Water":
                    DisplayWater();
                    break;
                case "Jerked Soda":
                    DisplayJerkedSoda();
                    break;
            }
        }

        public void DisplayCowboyCoffee()
        {
            CC_Decaf.Visibility = Visibility.Visible;
            CC_DecafCheck.Visibility = Visibility.Visible;
            CC_RoomforCream.Visibility = Visibility.Visible;
            CC_RoomforCreamCheck.Visibility = Visibility.Visible;
            Ice.Visibility = Visibility.Visible;
            Ice_Check.Visibility = Visibility.Visible;
        }

        public void DisplayTexasTea()
        {
            TT_Sweet.Visibility = Visibility.Visible;
            TT_SweetCheck.Visibility = Visibility.Visible;
            Ice.Visibility = Visibility.Visible;
            Ice_Check.Visibility = Visibility.Visible;
            Lemon.Visibility = Visibility.Visible;
            Lemon_Check.Visibility = Visibility.Visible;
        }

        public void DisplayWater()
        {
            Lemon.Visibility = Visibility.Visible;
            Lemon_Check.Visibility = Visibility.Visible;
            Ice.Visibility = Visibility.Visible;
            Ice_Check.Visibility = Visibility.Visible;
        }

        public void DisplayJerkedSoda()
        {
            Ice.Visibility = Visibility.Visible;
            Ice_Check.Visibility = Visibility.Visible;
            BirchBeer.Visibility = Visibility.Visible;
            CreamSoda.Visibility = Visibility.Visible;
            OrangeSoda.Visibility = Visibility.Visible;
            RootBeer.Visibility = Visibility.Visible;
            Sarsparilla.Visibility = Visibility.Visible;
        }

        private void Size_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton button)
            {
                switch (button.Tag)
                {
                    case "Medium":
                        drink.Size = CowboyCafe.Data.Size.Medium;
                        break;
                    case "Large":
                        drink.Size = CowboyCafe.Data.Size.Large;
                        break;
                    default:
                        drink.Size = CowboyCafe.Data.Size.Small;
                        break;
                }
                order.InvokePropertyChanged();
            }
        }

        private void Flavor_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton button)
            {
                js = (JerkedSoda)drink;
                switch (button.Tag)
                {
                    
                    case "BirchBeer":
                        js.Flavor = CowboyCafe.Data.SodaFlavor.BirchBeer;
                        break;
                    case "CreamSoda":
                        js.Flavor = CowboyCafe.Data.SodaFlavor.CreamSoda;
                        break;
                    case "OrangeSoda":
                        js.Flavor = CowboyCafe.Data.SodaFlavor.OrangeSoda;
                        break;
                    case "Sarsparilla":
                        js.Flavor = CowboyCafe.Data.SodaFlavor.Sarsparilla;
                        break;
                    case "RootBeer":
                        js.Flavor = CowboyCafe.Data.SodaFlavor.RootBeer;
                        break;
                }
                order.InvokePropertyChanged();
            }
        }

    }
}
