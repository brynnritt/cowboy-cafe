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
using Extention;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        
        /// <summary>
        /// Constructor
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            
        }

        public void OnAddEntreeButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            var cowpokeEntree = new CowpokeChili();
                            var screen = new CustomizeEntree("Cowpoke Chili", DataContext);
                            screen.DataContext = cowpokeEntree;
                            order.Add(cowpokeEntree);
                            orderControl.SwapScreen(screen);
                            order.InvokePropertyChanged();
                            break;
                        case "RustlersRibs":
                            var rustlersEntree = new RustlersRibs();
                            screen = new CustomizeEntree("Rustlers Ribs", DataContext);
                            screen.DataContext = rustlersEntree;
                            order.Add(rustlersEntree);
                            orderControl.SwapScreen(screen);
                            order.InvokePropertyChanged();
                            break;
                        case "AngryChicken":
                            var angryEntree = new AngryChicken();
                            screen = new CustomizeEntree("Angry Chicken", DataContext);
                            screen.DataContext = angryEntree;
                            order.Add(angryEntree);
                            orderControl.SwapScreen(screen);
                            order.InvokePropertyChanged();
                            break;
                        case "TexasTripleBurger":
                            var texasEntree = new TexasTripleBurger();
                            screen = new CustomizeEntree("Texas Triple", DataContext);
                            screen.DataContext = texasEntree;
                            order.Add(texasEntree);
                            orderControl.SwapScreen(screen);
                            break;
                        case "PecosPulledPork":
                            var pecosEntree = new PecosPulledPork();
                            screen = new CustomizeEntree("Pecos Pulled Pork", DataContext);
                            screen.DataContext = pecosEntree;
                            order.Add(pecosEntree);
                            orderControl.SwapScreen(screen);
                            break;
                        case "DakotaDoubleBurger":
                            var dakotaEntree = new DakotaDoubleBurger();
                            screen = new CustomizeEntree("Dakota Double Burger", DataContext);
                            screen.DataContext = dakotaEntree;
                            order.Add(dakotaEntree);
                            orderControl.SwapScreen(screen);
                            break;
                        case "TrailBurger":
                            var trailEntree = new TrailBurger();
                            screen = new CustomizeEntree("Trail Burger", DataContext);
                            screen.DataContext = trailEntree;
                            order.Add(trailEntree);
                            orderControl.SwapScreen(screen);
                            break;
                    }
                }
            }
        }


        public void OnAddDrinkButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowboyCoffee":
                            var cowboyCoffee = new CowboyCoffee();
                            var screen = new CustomizeDrink("CowboyCoffee", cowboyCoffee, order);
                            screen.DataContext = cowboyCoffee;
                            order.Add(cowboyCoffee);
                            orderControl.SwapScreen(screen);
                            break;
                        case "JerkedSoda":
                            var jerkedSoda = new JerkedSoda();
                            screen = new CustomizeDrink("JerkedSoda", jerkedSoda, order);
                            screen.DataContext = jerkedSoda;
                            order.Add(jerkedSoda);
                            orderControl.SwapScreen(screen);
                            break;
                        case "TexasTea":
                            var texasDrink = new TexasTea();
                            screen = new CustomizeDrink("TexasTea", texasDrink, order);
                            screen.DataContext = texasDrink;
                            order.Add(texasDrink);
                            orderControl.SwapScreen(screen);
                            break;
                        case "Water":
                            var water = new Water();
                            screen = new CustomizeDrink("Water", water, order);
                            screen.DataContext = water;
                            order.Add(water);
                            orderControl.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

        public void OnAddSideButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "BakedBeans":
                            var bakedBeans = new BakedBeans();
                            var screen = new CustomizeSide(bakedBeans, DataContext);
                            screen.DataContext = bakedBeans;
                            order.Add(bakedBeans);
                            orderControl.SwapScreen(screen);
                            break;
                        case "ChiliCheeseFries":
                            var chiliCheeseFries = new ChiliCheeseFries();
                            screen = new CustomizeSide(chiliCheeseFries, DataContext);
                            screen.DataContext = chiliCheeseFries;
                            order.Add(chiliCheeseFries);
                            orderControl.SwapScreen(screen);
                            break;
                        case "CornDodgers":
                            var cornDodgers = new CornDodgers();
                            screen = new CustomizeSide(cornDodgers, DataContext);
                            screen.DataContext = cornDodgers;
                            order.Add(cornDodgers);
                            orderControl.SwapScreen(screen);
                            break;
                        case "PanDeCampo":
                            var panDeCampo = new PanDeCampo();
                            screen = new CustomizeSide(panDeCampo, DataContext);
                            screen.DataContext = panDeCampo;
                            order.Add(panDeCampo);
                            orderControl.SwapScreen(screen);
                            break;
                    }
                }
            }
        }

    }
}

