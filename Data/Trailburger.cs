using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Trailburger
    {
        public double Price
        {
            get
            {
                return 4.50;
            }
        }

        public uint Calories
        {
            get
            {
                return 288;
            }
        }

        public bool Bun { get; set; } = true;
        public bool Pickle { get; set; } = true;
        public bool Ketchup { get; set; } = true;
        public bool Mustard { get; set; } = true;
        public bool Cheese { get; set; } = true;

        public List<string> SpecialIntructions
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
