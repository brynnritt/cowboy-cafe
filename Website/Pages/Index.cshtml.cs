using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Holds menu items after filter has been applied
        /// </summary>
        public IEnumerable<IOrderItem> FilteredMenu { get; set; } = Menu.All;

        /// <summary>
        /// The search terms entered in search bar
        /// </summary>
        public string SearchTerms { get; set; }
        /// <summary>
        /// Category to filter by
        /// </summary>
        public string Category { get; set; } = "";
        /// <summary>
        /// Min calories
        /// </summary>
        public int? CaloriesMin { get; set; }
        /// <summary>
        /// Max calories
        /// </summary>
        public int? CaloriesMax { get; set; }
        /// <summary>
        /// Min price
        /// </summary>
        public double? PriceMin { get; set; }
        /// <summary>
        /// Max price
        /// </summary>
        public double? PriceMax { get; set; }
       
        public void OnGet(string SearchTerms, int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            this.SearchTerms = SearchTerms;
            FilteredMenu = Menu.All;

            if (SearchTerms != null)
            {
                FilteredMenu = FilteredMenu.Where(item => item.ToString().Contains(SearchTerms));
            }

            if(Request.Query["Catagories"].Count != 0)
            {
                Category = Request.Query["Catagories"];
                //FilteredMenu = Menu.FilterByCategory(FilteredMenu, Category);
                if (!Category.Contains("entree")) FilteredMenu = FilteredMenu.Where(item => !(item is Entree));
                if (!Category.Contains("side")) FilteredMenu = FilteredMenu.Where(item => !(item is Side));
                if (!Category.Contains("drink")) FilteredMenu = FilteredMenu.Where(item => !(item is Drink));
            }

            //FilteredMenu = Menu.FilterByCalories(FilteredMenu, CaloriesMin, CaloriesMax);
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            if (CaloriesMin != null)
            {
                FilteredMenu = FilteredMenu.Where(item => item.Calories >= CaloriesMin);
            }
            
            if (CaloriesMax != null)
            {
                FilteredMenu = FilteredMenu.Where(item => item.Calories <= CaloriesMax);
            }

            //FilteredMenu = Menu.FilterByPrice(FilteredMenu, PriceMin, PriceMax);
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            if (PriceMin != null)
            {
                FilteredMenu = FilteredMenu.Where(item => item.Price >= PriceMin);
            }

            if (PriceMax != null)
            {
                FilteredMenu = FilteredMenu.Where(item => item.Price <= PriceMax);
            }
        }
    }
}
