using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken : Entree
    {
        /// <summary>
        /// Price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// Calories in entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// This bool represents whether or not the customer wants bread
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// This bool represents whether or not the customer wants pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Returns the special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if(!Bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                return instructions;
            }
        }

        /// <summary>
        /// To string method for entree
        /// </summary>
        /// <returns>Entree as string</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
