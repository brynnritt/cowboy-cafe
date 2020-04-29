using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Gets the price in the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.59;
                    case (Size.Medium):
                        return 2.10;
                    default:
                        return 2.59;
                }
            }
        }

        /// <summary>
        /// Gets the calories in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 110;
                    case (Size.Medium):
                        return 146;
                    default:
                        return 198;
                }
            }
        }

        private SodaFlavor sodaFlavor;
        /// <summary>
        /// The flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return sodaFlavor; }
            set
            {
                sodaFlavor = value;
                InvokePropertyChanged("SodaFlavor");
            }
        }

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }

        /// <summary>
        /// To string method
        /// </summary>
        /// <returns>Drink as string</returns>
        public override string ToString()
        {
            string s = "";
            switch (Size)
            {
                case Size.Small:
                    s += "Small ";
                    break;
                case Size.Medium:
                    s += "Medium ";
                    break;
                default:
                    s += "Large ";
                    break;
            }
            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    s += "Birch Beer Jerked Soda";
                    break;
                case SodaFlavor.CreamSoda:
                    s += "Cream Soda Jerked Soda";
                    break;
                case SodaFlavor.OrangeSoda:
                    s += "Orange Soda Jerked Soda";
                    break;
                case SodaFlavor.RootBeer:
                    s += "Root Beer Jerked Soda";
                    break;
                case SodaFlavor.Sarsparilla:
                    s += "Sarsparilla Jerked Soda";
                    break;
            }
            return s;
        }

        public override string DrinkName()
        {
            return "Jerked Soda";
        }
        public override string Name()
        {
            return "Jerked Soda";
        }
    }
}
