using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// The price of the dish
        /// </summary>
       public override double Price
        {
            get { return 5.88; }
        }

        /// <summary>
        /// Number of calories in the dish
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }

        /// <summary>
        /// Boolean for bread
        /// </summary>
        public bool Bread { get; set; } = true;
        /// <summary>
        /// Boolean for pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Creates and returns list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");
                return instructions;
            }
        }

        /// <summary>
        /// To string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
