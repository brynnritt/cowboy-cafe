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
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        double Subtotal;
        TransactionControl tc;


        public CashRegisterControl(double subtotal, TransactionControl tc)
        {
            InitializeComponent();
            Subtotal = subtotal;
            this.tc = tc;
        }

        public void CalculateChange_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is CashRegisterModelView mv)
            {
                double change = mv.RunningTotal - Subtotal;
                if (change < 0) MessageBox.Show("Insufficent Funds");
                mv.GiveChange(change);
                change = Math.Round(change, 2);
                MessageBox.Show("Change: " + change);
                MessageBox.Show("Printing Receipt...");
                tc.PrintReceipt("cash", change);
                if(tc.DataContext is OrderControl oc)
                {
                    oc.OrderComplete();
                }
                
            }
        }




    }
}
