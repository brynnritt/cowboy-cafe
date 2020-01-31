using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger
    {
        public double Price
        {
            get
            {
                return 5.20;
            }
        }

        public uint Calories
        {
            get
            {
                return 288;
            }
        }

        public bool Tomato { get; set; } = true;
        public bool Lettuce { get; set; } = true;
        public bool Mayo { get; set; } = true;
        public bool Bun { get; set; } = true;
        public bool Pickle { get; set; } = true;
        public bool Ketchup { get; set; } = true;
        public bool Mustard { get; set; } = true;
        public bool Cheese { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get {
                List<string> instructions = new List<string>();
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Bun) instructions.Add("hold bun");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Cheese) instructions.Add("hold cheese");
                return instructions;
            }

    }
}
