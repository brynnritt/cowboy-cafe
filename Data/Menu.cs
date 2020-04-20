using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Compiles every entree into an IEnumerable 
        /// </summary>
        /// <returns>An IEnumberable containing every entree</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entree = new List<IOrderItem>();
            entree.Add(new AngryChicken());
            entree.Add(new CowpokeChili());
            entree.Add(new DakotaDoubleBurger());
            entree.Add(new PecosPulledPork());
            entree.Add(new RustlersRibs());
            entree.Add(new TexasTripleBurger());
            entree.Add(new TrailBurger());
            return entree;
        }

        /// <summary>
        /// Compiles every side into an IEnumerable 
        /// </summary>
        /// <returns>An IEnumberable containing every side</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> side = new List<IOrderItem>();
            side.Add(new BakedBeans());
            side.Add(new ChiliCheeseFries());
            side.Add(new CornDodgers());
            side.Add(new PanDeCampo());
            return side;
        }

        /// <summary>
        /// Compiles every drink into an IEnumerable 
        /// </summary>
        /// <returns>An IEnumberable containing every drink</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drink = new List<IOrderItem>();
            drink.Add(new CowboyCoffee());
            drink.Add(new JerkedSoda());
            drink.Add(new TexasTea());
            drink.Add(new Water());
            return drink;
        }

        /// <summary>
        /// Compiles the complete menu into an IEnumerable 
        /// </summary>
        /// <returns>An IEnumberable containing every entree, side, and drink</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
        List<IOrderItem> menu = new List<IOrderItem>();
        menu.Add(new AngryChicken());
        menu.Add(new CowpokeChili());
        menu.Add(new DakotaDoubleBurger());
        menu.Add(new PecosPulledPork());
        menu.Add(new RustlersRibs());
        menu.Add(new TexasTripleBurger());
        menu.Add(new TrailBurger());

        menu.Add(new BakedBeans());
        menu.Add(new ChiliCheeseFries());
        menu.Add(new CornDodgers());
        menu.Add(new PanDeCampo());

        menu.Add(new CowboyCoffee());
        menu.Add(new JerkedSoda());
        menu.Add(new TexasTea());
        menu.Add(new Water());

        return menu;

        }

        /// <summary>
        /// Returns the price of a drink or side based off size
        /// </summary>
        /// <param name="item">Drink or Side</param>
        /// <param name="size">Size of item</param>
        /// <returns>Price of item</returns>
        public static double GetPrice(IOrderItem item, Size size)
        {
            if(item is Side side)
            {
                side.Size = size;
                return side.Price;
            }
            if(item is Drink drink)
            {
                drink.Size = size;
                return drink.Price;
            }
            return 0;
        }

        /// <summary>
        /// Returns the calories in a drink or side based off size
        /// </summary>
        /// <param name="item">Drink or Side</param>
        /// <param name="size">Size of item</param>
        /// <returns>Calories in item</returns>
        public static uint GetCalories(IOrderItem item, Size size)
        {
            if (item is Side side)
            {
                side.Size = size;
                return side.Calories;
            }
            if (item is Drink drink)
            {
                drink.Size = size;
                return drink.Calories;
            }
            return 0;
        }
    }
}
