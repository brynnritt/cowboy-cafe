﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Order Interface
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Price of item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// List of special intsructions
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
