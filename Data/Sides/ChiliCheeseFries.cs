﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side , IOrderItem
    {
        /// <summary>
        /// Price of the side, varying based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    default:
                        return 3.99;
                }
            }
       }

        /// <summary>
        /// Calories in the side, varying based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    default:
                        return 610;
                }

            }
        }

        /// <summary>
        /// To string method
        /// </summary>
        /// <returns>Side as a string</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Chili Cheese Fries";
                case Size.Medium:
                    return "Medium Chili Cheese Fries";
                default:
                    return "Large Chili Cheese Fries";
            }
        }

        public override string Name()
        {
            return "Chili Cheese Fries";
        }
    }
}
