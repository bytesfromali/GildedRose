using GildedRose.Console;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class GildedRoseShould
    {
        [Fact]
        public void RunWithoutError_GivenEmptyCollection()
        {
            //IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            //Console.GildedRose app = new Console.GildedRose(Items);
            //app.UpdateQuality();
            //Assert.Equal("fixme", Items[0].Name);
            var items = new List<Item>();
            var gR = new Console.GildedRose(items);
            gR.UpdateQuality();
        }
    }
}