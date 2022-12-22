using Bazar.Controllers;
using Bazar.Data.Models;
using Bazar.Data.Repositories;
using Bazar.DTO.Item;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Tests
{
    public class FilterControllerTests : TestBase
    {
        private void FillItems(IItemRepository itemRepository)
        {
            List<Item> items = new List<Item>
            {
                new Item { Name = "Item 1", Price = 100, Sold = false, UserId = "123" },
                new Item { Name = "Item 2", Price = 1000, Sold = false, UserId = "123" },
                new Item { Name = "Item 3", Price = 2000, Sold = false, UserId = "123" },
                new Item { Name = "Item 4", Price = 10000, Sold = false, UserId = "123" },
                new Item { Name = "Sold", Price = 1, Sold = true, UserId = "123" },
            };
            items.ForEach(x => itemRepository.Create(x));
        }

        [Theory]
        [InlineData("", 1, 99, 0)]
        [InlineData("", 100, 999, 1)]
        [InlineData("", 2000, 9999, 1)]
        [InlineData("", 10000, 20000, 1)]
        [InlineData("", 1, 20000, 4)]
        [InlineData("Item", 1, 20000, 4)]
        [InlineData("Item 1", 1, 20000, 1)]
        [InlineData("Sold", 1, 20000, 0)]
        [InlineData("Item 2", 1000, 1000, 1)]
        [InlineData(null, -1, -1, 0)]
        public void FilterItemsTest(string text, int priceMIn, int priceMax, int expcetedItemCount)
        {
            var services = CreateServices();
            FillItems(services.ItemRepository);
            var controller = new FilterController(services.ItemRepository, services.Mapper);

            var result = controller.GetAll(text, priceMIn, priceMax).Result as OkObjectResult;
            Assert.Equal(200, result.StatusCode);

            var items = result.Value as List<ItemGetDTO>;
            Assert.Equal(expcetedItemCount, items.Count);

            foreach (var item in items)
            {
                Assert.Contains(text, item.Name);
                Assert.True(item.Price >= priceMIn && item.Price <= priceMax);
            }
        }

    }
}
