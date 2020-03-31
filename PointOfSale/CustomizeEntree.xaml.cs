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
                case "Angry Chicken":
                    DisplayAngryChicken();
                    break;
                case "Texas Triple":
                    DisplayTexasTriple();
                    break;
                case "Pecos Pulled Pork":
                    DisplayPecosPulledPork();
                    break;
                case "Trail Burger":
                    DisplayTrailBurger();
                    break;
                case "Dakota Double Burger":
                    DisplayDakotaDoubleBurger();
                    break;
            }
        }

        public void DisplayCowpokeChili()
        {
            CowpokeChili.Visibility = Visibility.Visible;
            CCGreenOnions.Visibility = Visibility.Visible;
            CCGreenOnionsCheck.Visibility = Visibility.Visible;
            CCCheese.Visibility = Visibility.Visible;
            CCCheeseCheck.Visibility = Visibility.Visible;
            CCSourCream.Visibility = Visibility.Visible;
            CCSourCreamCheck.Visibility = Visibility.Visible;
            CCTortillaStrips.Visibility = Visibility.Visible;
            CCTortillaStripsCheck.Visibility = Visibility.Visible;
            
            
        }

        public void DisplayAngryChicken()
        {
            AngryChicken.Visibility = Visibility.Visible;
            ACBread.Visibility = Visibility.Visible;
            ACBreadCheck.Visibility = Visibility.Visible;
            ACPickle.Visibility = Visibility.Visible;
            ACPickleCheck.Visibility = Visibility.Visible;
        }

        public void DisplayTexasTriple()
        {
            TexasTriple.Visibility = Visibility.Visible;
            TTTomato.Visibility = Visibility.Visible;
            TTTomatoCheck.Visibility = Visibility.Visible;
            TTPickle.Visibility = Visibility.Visible;
            TTPickleCheck.Visibility = Visibility.Visible;
            TTMustard.Visibility = Visibility.Visible;
            TTMustardCheck.Visibility = Visibility.Visible;
            TTMayo.Visibility = Visibility.Visible;
            TTMayoCheck.Visibility = Visibility.Visible;
            TTLettuce.Visibility = Visibility.Visible;
            TTLettuceCheck.Visibility = Visibility.Visible;
            TTKetchup.Visibility = Visibility.Visible;
            TTKetchupCheck.Visibility = Visibility.Visible;
            TTCheese.Visibility = Visibility.Visible;
            TTCheeseCheck.Visibility = Visibility.Visible;
            TTBacon.Visibility = Visibility.Visible;
            TTBaconCheck.Visibility = Visibility.Visible;
            TTBun.Visibility = Visibility.Visible;
            TTBunCheck.Visibility = Visibility.Visible;
            TTEgg.Visibility = Visibility.Visible;
            TTEggCheck.Visibility = Visibility.Visible;

        }

        public void DisplayPecosPulledPork()
        {
            PecosPulledPork.Visibility = Visibility.Visible;
            PPBread.Visibility = Visibility.Visible;
            PPBreadCheck.Visibility = Visibility.Visible;
            PPPickle.Visibility = Visibility.Visible;
            PPPickleCheck.Visibility = Visibility.Visible;
        }

        public void DisplayDakotaDoubleBurger()
        {
            DakotaDoubleBurger.Visibility = Visibility.Visible;
            DDTomato.Visibility = Visibility.Visible;
            DDTomatoCheck.Visibility = Visibility.Visible;
            DDLettuce.Visibility = Visibility.Visible;
            DDLettuceCheck.Visibility = Visibility.Visible;
            DDMayo.Visibility = Visibility.Visible;
            DDMayoCheck.Visibility = Visibility.Visible;
            DDBun.Visibility = Visibility.Visible;
            DDBunCheck.Visibility = Visibility.Visible;
            DDPickle.Visibility = Visibility.Visible;
            DDPickleCheck.Visibility = Visibility.Visible;
            DDKetchup.Visibility = Visibility.Visible;
            DDKetchupCheck.Visibility = Visibility.Visible;
            DDCheese.Visibility = Visibility.Visible;
            DDCheeseCheck.Visibility = Visibility.Visible;
        }

        public void DisplayTrailBurger()
        {
            TrailBurger.Visibility = Visibility.Visible;
            TBBun.Visibility = Visibility.Visible;
            TBBunCheck.Visibility = Visibility.Visible;
            TBPickle.Visibility = Visibility.Visible;
            TBPickleCheck.Visibility = Visibility.Visible; 
            TBKetchup.Visibility = Visibility.Visible;
            TBKetchupCheck.Visibility = Visibility.Visible;
            TBMustard.Visibility = Visibility.Visible;
            TBMustardCheck.Visibility = Visibility.Visible;
            TBCheese.Visibility = Visibility.Visible;
            TBCheeseCheck.Visibility = Visibility.Visible;

        }

    }
}
