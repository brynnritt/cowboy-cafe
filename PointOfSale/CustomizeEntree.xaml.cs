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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCowpokeChili.xaml
    /// </summary>
    public partial class CustomizeEntree : UserControl
    {
        public CustomizeEntree(string ButtonName)
        {
            InitializeComponent();
            EntreeSwitch(ButtonName);
        }

        public void EntreeSwitch(string ButtonName)
        {
            switch (ButtonName)
            {
                case "Cowpoke Chili":
                    DisplayCowpokeChili();
                    break;
            }
        }

        public void DisplayCowpokeChili()
        {
            CowpokeChili.Visibility = Visibility.Visible;

        }
    }
}
