using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs
    {
        /// <summary>
        /// The price of the ribs
        /// </summary>
        public double Price
        {
            get { return 7.5; }
        }

        /// <summary>
        /// The number of calories in the ribs
        /// </summary>
        public uint Calories
        {
            get { return 894; }
        }

        /// <summary>
        /// Creates and returns list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
    }
}
