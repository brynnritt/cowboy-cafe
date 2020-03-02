using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order
    {
        /// <summary>
        /// Keeps track of last order number
        /// </summary>
        private uint LastOrderNumber;
        /// <summary>
        /// List of items in order
        /// </summary>
        public List<IOrderItem> items;
        public IEnumerable<IOrderItem> Items { get; }
        /// <summary>
        /// Price of order
        /// </summary>
        public double Subtotal { get; }
        /// <summary>
        /// The order number
        /// </summary>
        public uint OrderNumber { get; }
        /// <summary>
        /// Handles event for adding and removing items
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds an item to the order by adding it to the list of items ordered
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        /// <summary>
        /// Removes item from list of items ordered
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
