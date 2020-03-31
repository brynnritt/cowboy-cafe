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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        //var oc = this.FindAncestor<OrderControl>();
        MenuItemSelectionControl menu = new MenuItemSelectionControl();
        /// <summary>
        /// Constructor
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0 && e.AddedItems[0] is IOrderItem)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if(DataContext is Order order)
                {
                    menu.OnItemSelectionChanged(sender, e, orderControl, order);
                }
            }
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
             //(IOrderItem)this.DataContext.Items[0];
            if(DataContext is Order order)
            {
                if (sender is Button button) {

                    IOrderItem item = (IOrderItem)button.DataContext;
                    order.Remove(item);
                }
            }
        }
    }
}
