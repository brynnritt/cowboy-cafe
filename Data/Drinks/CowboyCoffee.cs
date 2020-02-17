using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Gets the price in the drink
        /// </summary>
        public override double Price
        {
            get {
                switch (Size)
                {
                    case (Size.Small):
                        return 0.60;
                    case (Size.Medium):
                        return 1.10;
                    default:
                        return 1.60;
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
                        return 3;
                    case (Size.Medium):
                        return 5;
                    default:
                        return 7;
                }
            }
        }

        /// <summary>
        /// Bool for room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Bool for Ice set false by default
        /// </summary>
        public new bool Ice { get; set; } = false;

        /// <summary>
        /// Bool for room for decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Gets special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (RoomForCream) instructions.Add("Room for Cream");
                if (Ice) instructions.Add("Add Ice");
                return instructions;
            }
        }    
    }
}
