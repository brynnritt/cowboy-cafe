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
            FilteredMenu = Menu.Search(FilteredMenu, SearchTerms);

            if(Request.Query["Catagories"].Count != 0)
            {
                Category = Request.Query["Catagories"];
                FilteredMenu = Menu.FilterByCategory(FilteredMenu, Category);
            }

            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            FilteredMenu = Menu.FilterByCalories(FilteredMenu, CaloriesMin, CaloriesMax);

            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            FilteredMenu = Menu.FilterByPrice(FilteredMenu, PriceMin, PriceMax);
        }
    }
}
