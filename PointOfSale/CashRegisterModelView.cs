using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace PointOfSale
{
    class CashRegisterModelView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public static CashDrawer drawer = new CashDrawer();

        public double TotalValue => drawer.TotalValue;

        public double StartValue = drawer.TotalValue;

        public double RunningTotal => TotalValue - StartValue;

        public int Pennies
        {
            get => drawer.Pennies;
            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");

            }
        }

        public int Nickels
        {
            get => drawer.Nickels;
            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0) drawer.AddCoin(Coins.Nickel, quantity);
                else drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickels");

            }
        }

        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0) drawer.AddCoin(Coins.Dime, quantity);
                else drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");

            }
        }

        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0) drawer.AddCoin(Coins.Quarter, quantity);
                else drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");
            }
        }

        public int HalfDollars
        {
            get => drawer.HalfDollars;
            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollars");
            }
        }

        public int Dollars
        {
            get => drawer.Dollars;
            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0) drawer.AddCoin(Coins.Dollar, quantity);
                else drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollars");
            }
        }

        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones;
                if (quantity > 0) drawer.AddBill(Bills.One, quantity);
                else drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");
            }
        }

        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos;
                if (quantity > 0) drawer.AddBill(Bills.Two, quantity);
                else drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");
            }
        }

        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0) drawer.AddBill(Bills.Five, quantity);
                else drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanged("Fives");
            }
        }

        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0) drawer.AddBill(Bills.Ten, quantity);
                else drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");
            }
        }

        public int Twenties
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0) drawer.AddBill(Bills.Twenty, quantity);
                else drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twenties");
            }
        }

        public int Fifties
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0) drawer.AddBill(Bills.Fifty, quantity);
                else drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fifties");
            }
        }

        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0) drawer.AddBill(Bills.Hundred, quantity);
                else drawer.RemoveBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundreds");
            }
        }

        public void GiveChange(double change)
        {
            
            while (change > 0.0)
            {
                change = Math.Round(change, 2);
                if (change > 1)
                {
                    if(change >= 100 && drawer.Hundreds >= 1)
                    {                        
                        drawer.RemoveBill(Bills.Hundred, 1);
                        change -= 100;                        
                    }
                    else if(change >= 50 && drawer.Fifties >= 1)
                    {                                               
                        drawer.RemoveBill(Bills.Fifty, 1);
                        change -= 50;                        
                    }
                    else if (change >= 20 && drawer.Twenties >= 1)
                    {
                        drawer.RemoveBill(Bills.Twenty, 1);
                        change -= 20;                        
                    }
                    else if (change >= 10 && drawer.Tens >= 1)
                    {
                        drawer.RemoveBill(Bills.Ten, 1);
                        change -= 10;
                    }
                    else if (change >= 5 && drawer.Fives >= 1)
                    {
                        drawer.RemoveBill(Bills.Five, 1);
                        change -= 5;                         
                    }
                    else
                    {
                        if (drawer.Ones >= (int)change)
                        {
                            drawer.RemoveBill(Bills.One, (int)change);
                            change -= (int)change;
                        }
                    }
                }
                else
                {
                    if(change >= .25 && drawer.Quarters >= 1)
                    {
                        drawer.RemoveCoin(Coins.Quarter, 1);
                        change -= .25;
                    }
                    else if (change >= .10 && drawer.Dimes >= 1)
                    {
                        drawer.RemoveCoin(Coins.Dime, 1);
                        change -= .10;
                    }
                    else if (change >= .05 && drawer.Nickels >= 1)
                    {
                        drawer.RemoveCoin(Coins.Nickel, 1);
                        change -= .05;
                    }
                    else
                    {
                        if (drawer.Pennies >= (int)(change * 100))
                        {
                            drawer.RemoveCoin(Coins.Penny, (int)(change*100));
                            change -= (int)(change*100);
                        }
                    }
                }
            }
        }

        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RunningTotal"));
        }
    }
}
