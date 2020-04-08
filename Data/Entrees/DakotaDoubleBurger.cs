using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// Price of the dish
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }
        /// <summary>
        /// Number of calories in the dish
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }
        /// <summary>
        /// Private backing bool for tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Boolean for tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                InvokePropertyChanged("Tomato");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Private backing bool for lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Boolean for lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                InvokePropertyChanged("Lettuce");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Backing variable for mayo
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// Boolean for mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                InvokePropertyChanged("Mayo");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Backing bool for Bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Boolean for bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                InvokePropertyChanged("Bun");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Backing bool for pickle
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Boolean for pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                InvokePropertyChanged("Pickle");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Backing bool for ketchup
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Boolean for ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                InvokePropertyChanged("Ketchup");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Backing bool for mustard
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Boolean for mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                InvokePropertyChanged("Mustard");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Backing bool for cheese
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// Boolean for cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                InvokePropertyChanged("Cheese");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

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
                return instructions;
            }
        }

        /// <summary>
        /// To string method
        /// </summary>
        /// <returns>Entree as string</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
