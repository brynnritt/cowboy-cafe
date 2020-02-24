using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
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
                        return 1.00;
                    case (Size.Medium):
                        return 1.50;
                    default:
                        return 2.00;
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
                if (Sweet)
                {
                    switch (Size)
                    {
                        case (Size.Small):
                            return 10;
                        case (Size.Medium):
                            return 22;
                        default:
                            return 36;
                    }
                }
                switch (Size)
                {
                    case (Size.Small):
                        return 5;
                    case (Size.Medium):
                        return 11;
                    default:
                        return 18;
                }

            }
        }

        /// <summary>
        /// Bool for room for lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Bool for room for sweet
        /// </summary>
        public bool Sweet { get; set; } = true;

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
                    return "Small Texas Tea";
                case Size.Medium:
                    return "Medium Texas Tea";
                default:
                    return "Large Texas Tea";

            }
        }
    }
}
