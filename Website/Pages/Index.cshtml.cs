using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<IOrderItem> Menu { get; set; }

        /// <summary>
        /// The terms to search
        /// </summary>
        public string SearchTerms { get; set; }

        public string[] Categories { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(double priceMin, double priceMax, int caloriesMin, int caloriesMax)
        {
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];
            Menu = Data.Menu.Search(Menu, SearchTerms);
            Menu = Data.Menu.FilterByCategory(Menu, Categories);
            Menu = Data.Menu.FilterByPrice(Menu, priceMin, priceMax);
            Menu = Data.Menu.FilteryByCalories(Menu, caloriesMin, caloriesMax);
        }
    }
}
