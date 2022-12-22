using AutoMapper;
using Bazar.Controllers;
using Bazar.Data.Models;
using Bazar.Data.Repositories;
using Bazar.Models;
using Bazar.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Principal;

namespace Bazar.Tests
{
    public class ItemControllerTests : TestBase
    {
        [Fact]
        public void CreateCorrectItemTest()
        {
            ItemViewModel item = new ItemViewModel
            {
                CategoryId = 1,
                CourierDelivery = false,
                Description = "This is test item",
                IsNew = true,
                Name = "Test item",
                PickupInPerson = false,
                Price = 100
            };

            Services services = CreateServices();

            var controller = new ItemController(services.ItemRepository, services.CategoryRepository, services.Mapper);
            var result = controller.Create(item);

            var itemFromDb = services.ItemRepository.GetById(1);
            Assert.IsType<RedirectResult>(result);
            Assert.NotNull(itemFromDb);
            Assert.Equal(services.ItemRepository.GetAll().Count, 1);
            Assert.Equal(itemFromDb.Name, item.Name);
            Assert.Equal(itemFromDb.Price, item.Price);
        }
    }
}