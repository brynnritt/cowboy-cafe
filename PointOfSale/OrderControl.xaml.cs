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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();

            //AddTrailBurgerButton.Height = 90;
            AddCowpokeChiliButton.Click += CowPokeChiliButtonClicked;
        }

        /// <summary>
        /// Event handler for CowPokeChili Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CowPokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
                order.Add(new CowpokeChili());

        }

        /// <summary>
        /// Event handler for RustlersRibs Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order) order.Add(new RustlersRibs());
        }

        /// <summary>
        /// Event handler for Pescos Pulled Pork button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) order.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Event handler for Trail Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) order.Add(new TrailBurger());
        }

        /// <summary>
        /// Event handler for Dakota Double Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) order.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Event handler for Texas Triple button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) order.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Event handler for Angry Chicken button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) order.Add(new AngryChicken());
        }

        /// <summary>
        /// Event handler for Chili Cheese Fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) order.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Event handler for Corn Dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) order.Add(new CornDodgers());
        }

        /// <summary>
        /// Event handler for Pan de campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }

        /// <summary>
        /// Event handler for Baked beans button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// Event handler for Jerked Soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void JerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Event handler for Texas tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }

        /// <summary>
        /// Event handler for Cowboy Coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Event handler for water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WaterButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }
    }
}
