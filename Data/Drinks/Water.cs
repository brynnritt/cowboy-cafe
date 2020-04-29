using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// Gets the price in the drink
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// Gets the calories in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
            
        }

        private bool lemon = false;
        /// <summary>
        /// Bool for room for lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                InvokePropertyChanged("Lemon");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Lemon) instructions.Add("Add Lemon");
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
            switch (Size)
            {
                case Size.Small:
                    return "Small Water";
                case Size.Medium:
                    return "Medium Water";
                default:
                    return "Large Water";

            }
        }

        public override string DrinkName()
        {
            return "Water";
        }
        public override string Name()
        {
            return "Water";
        }
    }
}
