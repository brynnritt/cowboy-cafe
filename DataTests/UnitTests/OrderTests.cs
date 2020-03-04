using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;
/*
namespace CowboyCafe.DataTests
{
    public class MockOrderItem : IOrderItem
    {
        public double Price { get; set; }

        public List<string> SpecialInstructions => throw new NotImplementedException();
    }
    public class OrderTests
    {
        /// <summary>
        /// Adding something to the order should add it to the Items property
        /// </summary>
        public void AddedIOrderItemsAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        /// <summary>
        /// Removing something from order should remove it from Items property
        /// </summary>
        [Fact]
        public void RemovedOrderItemsDoNotAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Item);
        }
        [Theory]
        [InlineData(new double[] {0})]
        [InlineData(new double[] { 10, 15, 18 })]
        [InlineData(new double[] {20, -4, 3.6, 8})]
        [InlineData(new double[] {100, -5})]
        
        public void SubtotalShouldBeTheSumOfOrderItemsPrice(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem(){
                    Price = price
                });
            }
            Assert.Equal(total, order.GetSubtotal());
        }
        [Fact]
        public void ItemsShouldContainOnlyAddedItems(MockOrderItem[] item)
        {
            var items = new IOrderItem[]
            {
                new MockOrderItem() {Price = 3},
                new MockOrderItem() {Price = 4},
                new MockOrderItem() {Price = 7},

            };
            var order = new Order();
            foreach(var item in items)
            {
                order.Add(item);
            }
            Assert.Equal(items.Length, order.Items.Count());
            foreach(var item in items)
            {
                Assert.Contains
            }
        }
    }
}
*/


