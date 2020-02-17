using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger : Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// The number of calories in the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Boolean for bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Boolean for pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Boolean for ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Boolean for mustard
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Boolean for cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Creates and returns list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("hold bun");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Cheese) instructions.Add("hold cheese");
                return instructions;
            }
        }
    }
}
