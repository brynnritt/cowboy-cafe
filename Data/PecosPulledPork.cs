using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
       public double Price
        {
            get { return 5.88; }
        }

        public uint Calories
        {
            get { return 528; }
        }

        public bool Bread { get; set; } = true;
        public bool Pickle { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");
                return instructions;
            }
        }
    }
}
