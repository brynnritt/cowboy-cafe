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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        double subtotal;
        ReceiptPrinter receipt = new ReceiptPrinter();
        
        public TransactionControl(object OrderControl)
        {
            InitializeComponent();
            DataContext = OrderControl;
            

            CalculateTax();
            if (DataContext is OrderControl o)
            {
                if(o.DataContext is Order order)
                {
                    Subtotal.Text = "$ " + (Math.Round(order.Subtotal, 2)).ToString();
                    OrderNumber.Text = (order.OrderNumber).ToString();
                }
            }
            
        }

        private void CalculateTax()
        {
            if (DataContext is OrderControl o) { 
                if (o.DataContext is Order order)
                {
                    subtotal = order.Subtotal;
                    double temp = subtotal * .16;
                    string tax = String.Format(" ${0:0.00}", temp);

                    temp = (subtotal * .16) + subtotal;
                    string total = String.Format(" ${0:0.00}", temp);
                    Tax.Text = tax;
                    Total.Text = total;
                }
            }
        }

        private void OnCredit_Click(object sender, RoutedEventArgs e)
        {
            CardTerminal ct = new CardTerminal();
            ResultCode result = ct.ProcessTransaction(subtotal);
            if(result is ResultCode.Success)
            {
                if (DataContext is OrderControl oc)
                {
                    if (oc.DataContext is Order order)
                    {
                        MessageBox.Show("Printing Receipt...");
                        PrintReceipt("credit", 0);
                        oc.OrderComplete();
                    }
                }
            }
            else
            {
                MessageBox.Show(result.ToString());
            }

        }

        private void OnCash_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is OrderControl oc)
            {
                CashRegisterControl registerControl = new CashRegisterControl(subtotal, this);
                registerControl.DataContext = new CashRegisterModelView();
                oc.SwapScreen(registerControl);
                                
            }
        }

        private void OnCancelTransaction_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is OrderControl oc)
                oc.SwapScreen(new MenuItemSelectionControl());
        }


        public void PrintReceipt(string paymentMethod, double change)
        {
            if (DataContext is OrderControl o) { 
            //DataContext = dc;
                if (o.DataContext is Order order)
                {

                    DateTime date = DateTime.Now;
                    string s = "Order Number: " + order.OrderNumber +
                        "\nDate: " + date +
                        "\n\nOrder: ";
                    foreach (IOrderItem i in order.Items)
                    {
                        s += "\n" + i.ToString() + " $" + i.Price;
                        foreach(string st in i.SpecialInstructions)
                        {
                            s += "\n\t" + st;
                        }
                            
                    }
                    //special instructions
                    s += "\nSubtotal: $" + Math.Round(order.Subtotal, 2) +
                        "\nTotal: $" + Math.Round((order.Subtotal * .16), 2) +
                        "\nPaid with: ";
                    if (paymentMethod == "cash")
                    {
                        s += "Cash" +
                            "\nAmount Paid: $" + Math.Round((order.Subtotal + change)) +
                            "\nChange: $" + change +"\n";
                    }
                    else
                    {
                        s += "Credit\n";
                    }
                    receipt.Print(s);
                }
            }
        
        }
    }
}
