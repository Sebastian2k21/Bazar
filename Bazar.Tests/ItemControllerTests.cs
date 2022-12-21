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
    public class ItemControllerTests
    {
        private IMapper CreateMapper()
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });
            return mockMapper.CreateMapper();
        }
       
        private ClaimsIdentity CreateIdentity()
        {
            var identity = new ClaimsIdentity();
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, "123"));
            return identity;
        }

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

            IMapper mapper = CreateMapper();
            IItemRepository itemRepository = new ItemFakeRepository(mapper);
            ICategoryRepository categoryRepository = new CategoryFakeRepository(mapper);
            var controller = new ItemController(itemRepository, categoryRepository, mapper);
            controller.User.AddIdentity(CreateIdentity());
            var result = controller.Create(item);

            var itemFromDb = itemRepository.GetById(1);
            Assert.IsType<RedirectResult>(result);
            Assert.NotNull(itemFromDb);
            Assert.Equal(itemRepository.GetAll().Count, 1);
            Assert.Equal(itemFromDb.Name, item.Name);
            Assert.Equal(itemFromDb.Price, item.Price);
        }
    }
}