﻿using System;
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
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        public void OrderComplete()
        {
            this.DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();
        }
        /// <summary>
        /// Button to select an item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ItemSelectionButton(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
        /// <summary>
        /// Event handler for button that cancels the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelOrderButton(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            
        }
        /// <summary>
        /// Event handler for button that completes the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteOrderButton(object sender, RoutedEventArgs e)
        {
            object dc = DataContext;
            TransactionControl tc = new TransactionControl(this);
            tc.DataContext = this;
            Container.Child = tc;
        }
    }
}
