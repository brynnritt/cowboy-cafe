﻿using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public class PanDeCampo : Side, IOrderItem
    {
        /// <summary>
        /// Price of the side, which varies based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    default:
                        return 1.99;
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
                        return 227;
                    case Size.Medium:
                        return 269;
                    default:
                        return 367;
                }

            }
        }


        /// <summary>
        /// To string method
        /// </summary>
        /// <returns>side as string</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Pan de Campo";
                case Size.Medium:
                    return "Medium Pan de Campo";
                default:
                    return "Large Pan de Campo";

            }
        }

        public override string Name()
        {
            return "Pan De Campo";
        }
    }
}
