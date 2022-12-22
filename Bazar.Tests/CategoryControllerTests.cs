using Bazar.Controllers;
using Bazar.DTO.Category;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Tests
{
    public class CategoryControllerTests : TestBase
    {
        [Fact]
        public void GetAllCategoriesTest()
        {
            Services services = CreateServices();
            var controller = new CategoryController(services.CategoryRepository, services.Mapper);

            var result = controller.GetAll();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);

            var categories = okResult.Value as List<CategoryGetDTO>;
            Assert.NotNull(categories);
            Assert.NotEmpty(categories);    
        }

        [Fact]
        public void GetByIdCategoryTest()
        {
            Services services = CreateServices();
            var controller = new CategoryController(services.CategoryRepository, services.Mapper);

            var result = controller.Get(1);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);

            var categories = okResult.Value as CategoryGetDTO;
            Assert.NotNull(categories);
        }

        [Theory]
        [InlineData("Test category")]
        [InlineData("To jest testowa kategoria nr 1000000000000000")]
        [InlineData("T")]
        public void CreateCategoryTest(string categoryName)
        {
            Services services = CreateServices();
            var controller = new CategoryController(services.CategoryRepository, services.Mapper);

            var result = controller.Create(new DTO.Item.CategoryCreateDTO { Name = categoryName });
            var okResult = result as OkResult;
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);

            var categoryInDb = services.CategoryRepository.GetAll().FirstOrDefault(x => x.Name == categoryName);
            Assert.NotNull(categoryInDb);
            Assert.True(categoryInDb.Id > 0);
        }

        [Fact]
        public void DeleteCategoryTest()
        {
            Services services = CreateServices();
            var controller = new CategoryController(services.CategoryRepository, services.Mapper);

            var result = controller.Delete(1);
            var okResult = result as OkResult;
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);

            var categoryInDb = services.CategoryRepository.GetAll().FirstOrDefault(x => x.Id == 1);
            Assert.Null(categoryInDb);
        }
    }
}
