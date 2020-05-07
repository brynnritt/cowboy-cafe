/*
 * Brynn Rittenhouse
 * Menu.cs
 * This class enables menu to be displayed on website
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Compiles every entree into an IEnumerable 
        /// </summary>
        /// <returns>An IEnumberable containing every entree</returns>
        public static IEnumerable<IOrderItem> Entrees
        {
            get
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
        }

        /// <summary>
        /// Compiles every side into an IEnumerable 
        /// </summary>
        /// <returns>An IEnumberable containing every side</returns>
        public static IEnumerable<IOrderItem> Sides
        {
            get
            {
                List<IOrderItem> side = new List<IOrderItem>();
                side.Add(new BakedBeans());
                side.Add(new ChiliCheeseFries());
                side.Add(new CornDodgers());
                side.Add(new PanDeCampo());
                return side;
            }
        }

        /// <summary>
        /// Compiles every drink into an IEnumerable 
        /// </summary>
        /// <returns>An IEnumberable containing every drink</returns>
        public static IEnumerable<IOrderItem> Drinks
        {
            get
            {
                List<IOrderItem> drink = new List<IOrderItem>();
                drink.Add(new CowboyCoffee());
                drink.Add(new JerkedSoda());
                drink.Add(new TexasTea());
                drink.Add(new Water());
                return drink;
            }
        }

        /// <summary>
        /// Compiles the complete menu into an IEnumerable 
        /// </summary>
        /// <returns>An IEnumberable containing every entree, side, and drink</returns>
        public static IEnumerable<IOrderItem> All
        { 
            get
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
        /// <summary>
        /// Searches menu for matching terms
        /// </summary>
        /// <param name="terms">The term being searched for</param>
        /// <returns>The menu items with matching terms</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string term)
        {
            if (items == null) return All;
            if (term == null) return items;
            List<IOrderItem> result = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if (item.ToString().Contains(term))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        /// <summary>
        /// Filters menu items by catagory
        /// </summary>
        /// <param name="items">The menu items</param>
        /// <param name="catagory">The catagory to filter by</param>
        /// <returns>The catagory matching the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, string category)
        {
            List<IOrderItem> result = new List<IOrderItem>();
            //if (catagory == null) return All;
            foreach (IOrderItem item in items)
            {
                if(category == "entree")
                {
                    if(item is Entree)
                    {
                        result.Add(item);
                    }
                }
                else if (category == "side")
                {
                    if(item is Side)
                    {
                        result.Add(item);
                    }
                }
                else if(category == "drink")
                {
                    if(item is Drink)
                    {
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;
            List<IOrderItem> result = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) result.Add(item);
                }
                return result;
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) result.Add(item);
                }
                return result;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max) result.Add(item);
            }
            return result;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            List<IOrderItem> result = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) result.Add(item);
                }
                return result;
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) result.Add(item);
                }
                return result;
            }
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max) result.Add(item);
            }
            return result;
        }


    }
}
