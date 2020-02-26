using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public interface IOrderItem
    {
        public double Price { get; set; }

        public List<string> SpecialIntructions { get; set; }
    }
}
