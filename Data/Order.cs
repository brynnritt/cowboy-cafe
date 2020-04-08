/*
 * Author: Brynn Rittenhouse
 * Class: Order.cs
 * Purpose: Order class
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        public Order()
        {
            LastOrderNumber++;
        }
        /// <summary>
        /// Keeps track of last order number
        /// </summary>
        private static uint LastOrderNumber = 0;
        /// <summary>
        /// List of items in order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Handles event for adding and removing items
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the list of order items
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// Price of order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }


        /// <summary>
        /// The next order number
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                return LastOrderNumber;
            }
        }

        
        /// <summary>
        /// Adds an item to the order by adding it to the list of items ordered
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes item from list of items ordered
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void InvokePropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
