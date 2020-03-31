/*
 * 
 * Refrence: Zachery Brunner
 */
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
    /// Interaction logic for CustomizeSide.xaml
    /// </summary>
    public partial class CustomizeSide : UserControl
    {
        Side side;
        Order order;
        public CustomizeSide(object ObjectName, object Order)
        {
            InitializeComponent();
            side = (Side)ObjectName;
            order = (Order)Order;
        }

               
        private void Size_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton button)
            {
                switch (button.Tag)
                {                        
                    case "Medium":
                        side.Size = CowboyCafe.Data.Size.Medium;

                        break;
                    case "Large":
                        side.Size = CowboyCafe.Data.Size.Large;
                        break;
                    default:
                        side.Size = CowboyCafe.Data.Size.Small;
                        break;
                }
            }
            order.InvokePropertyChanged();
        }
    }

}
