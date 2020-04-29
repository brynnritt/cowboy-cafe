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

        private bool roomForCream = false;
        /// <summary>
        /// Bool for room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                InvokePropertyChanged("RoomForCream");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool ice = false;
        /// <summary>
        /// Bool for Ice set false by default
        /// </summary>
        public new bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                InvokePropertyChanged("Ice");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool decaf = false;
        /// <summary>
        /// Bool for room for decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                InvokePropertyChanged("Decaf");
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
                if (RoomForCream) instructions.Add("Room for Cream");
                if (Ice) instructions.Add("Add Ice");
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
                    if(Decaf) return "Small Decaf Cowboy Coffee";
                    return "Small Cowboy Coffee";
                case Size.Medium:
                    if (Decaf) return "Medium Decaf Cowboy Coffee";
                    return "Medium Cowboy Coffee";
                default:
                    if (Decaf) return "Large Decaf Cowboy Coffee";
                    return "Large Cowboy Coffee";
            }
        }

        public override string DrinkName()
        {
            return "Cowboy Coffee";
        }
        public override string Name()
        {
            return "Cowboy Coffee";
        }
    }

}
