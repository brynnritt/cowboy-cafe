using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }
        /// <summary>
        /// Calories in the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// Boolean for tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Boolean for lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// Boolean for mayo
        /// </summary>
        public bool Mayo { get; set; } = true;
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
        /// Boolean for bacon
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// Boolean for egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Creates and returns list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Bun) instructions.Add("hold bun");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Cheese) instructions.Add("hold cheese");
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");
                return instructions;
            }
        }
    }
}
