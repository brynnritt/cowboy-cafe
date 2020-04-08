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

        private bool sweet = true;
        /// <summary>
        /// Bool for room for sweet
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                InvokePropertyChanged("Sweet");
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
                    if (Sweet) return "Small Texas Sweet Tea";
                    return "Small Texas Plain Tea";
                case Size.Medium:
                    if (Sweet) return "Medium Texas Sweet Tea";
                    return "Medium Texas Plain Tea";
                default:
                    if (Sweet) return "Large Texas Sweet Tea";
                    return "Large Texas Plain Tea";

            }
        }

        public override string DrinkName()
        {
            return "Texas Tea";
        }
    }
}
