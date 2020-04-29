using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class MenuTests
    {
        [Fact]
        public void MenuShoudConainAllEntrees()
        {
            var entrees = new List<IOrderItem>(Menu.Entrees);
            entrees.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                Menu.Entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        [Fact]
        public void MenuShouldContainAllSides()
        {
            var sides = new List<IOrderItem>(Menu.Sides);
            sides.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                Menu.Sides,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        [Fact]
        public void MenuShouldContainAllDrinks()
        {
            var drinks = new List<IOrderItem>(Menu.Drinks);
            drinks.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                Menu.Drinks,
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (water) => { Assert.IsType<Water>(water); }
                );
        }

        [Fact]
        public void MenuShouldContainAllItems()
        {
            // var items = new List<IOrderItem>(Menu.All);
            // items.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                Menu.All,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },

                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },

                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (water) => { Assert.IsType<Water>(water); }
                );
        }

        [Theory]
        [InlineData("Burger", 3)]
        [InlineData(null, 15)]
        public void SearchFunctionShouldReturnResultsOfSearch(string parameter, int expectedResults)
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> results = Menu.Search(menu, parameter);
            int resultsCount = results.Count();
            Assert.Equal(expectedResults, resultsCount);
        }

        [Theory]
        [InlineData("entree", 7)]
        [InlineData("side", 4)]
        [InlineData("drink", 4)]
        public void FilterByCategoryReturnsCorrectItems(String category, int expectedResults)
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> result = Menu.FilterByCategory(menu, category);
            int resultCount = result.Count();
            Assert.Equal(expectedResults, resultCount);

            if (category == "side")
            {
                Assert.Collection(
                    result,
                    (bb) => { Assert.IsType<BakedBeans>(bb); },
                    (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                    (cd) => { Assert.IsType<CornDodgers>(cd); },
                    (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                    );
            }
            else if (category == "entree")
            {
                Assert.Collection(
                    result,
                    (ac) => { Assert.IsType<AngryChicken>(ac); },
                    (cc) => { Assert.IsType<CowpokeChili>(cc); },
                    (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                    (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                    (rr) => { Assert.IsType<RustlersRibs>(rr); },
                    (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                    (tb) => { Assert.IsType<TrailBurger>(tb); }
                    );
            }
            else if (category == "drink")
            {
                Assert.Collection(
                    result,
                    (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                    (js) => { Assert.IsType<JerkedSoda>(js); },
                    (tt) => { Assert.IsType<TexasTea>(tt); },
                    (water) => { Assert.IsType<Water>(water); }
                    );
            }
        }

        [Theory]
        [InlineData(10, 300)]
        [InlineData(300, 500)]
        public void FilterByCaloriesShouldReturnCorrectItems(int? minCal, int? maxCal)
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> result = Menu.FilterByCalories(menu, minCal, maxCal);

            foreach (IOrderItem item in result)
            {
                Assert.True(item.Calories >= minCal);
                Assert.True(item.Calories <= maxCal);
            }
        }

        [Theory]
        [InlineData(null, null)]
        public void FilterByCaloresRetunsListWhenPassedNull(int? minCal, int? maxCal)
        {

            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> result = Menu.FilterByCalories(menu, minCal, maxCal);
            Assert.Equal(result, menu);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(3, 8)]
        public void FilterByPriceShouldReturnCorrectItems(double? minPrice, double? maxPrice)
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> result = Menu.FilterByPrice(menu, minPrice, maxPrice);

            foreach (IOrderItem item in result)
            {
                Assert.True(item.Price >= minPrice);
                Assert.True(item.Price <= maxPrice);
            }
        }

        [Theory]
        [InlineData(null, null)]
        public void FilerByPriceReturnsItemsWhenPassedNull(double? minPrice, double? maxPrice)
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            IEnumerable<IOrderItem> result = Menu.FilterByPrice(menu, minPrice, maxPrice);
            Assert.Equal(result, menu);
        }
    }
}
