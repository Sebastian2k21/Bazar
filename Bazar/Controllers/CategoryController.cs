using AutoMapper;
using Bazar.Data;
using Bazar.Data.Models;
using Bazar.Data.Repositories;
using Bazar.DTO.Category;
using Bazar.DTO.Item;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bazar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            return Ok(mapper.Map<List<CategoryGetDTO>>(categoryRepository.GetAll()));
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult Get(int id)
        {
            var category = categoryRepository.GetById(id);
            if (category is null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<CategoryGetDTO>(category));
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateDTO category)
        {
            categoryRepository.Create(mapper.Map<Category>(category));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryCreateDTO category)
        {
            var categoryToUpdate = categoryRepository.GetById(id);
            if (categoryToUpdate is null)
            {
                return NotFound();
            }
            mapper.Map(category, categoryToUpdate);
            categoryRepository.Update(categoryToUpdate);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = categoryRepository.GetById(id);
            if (category is null)
            {
                return NotFound();
            }
            categoryRepository.Delete(id);
            return Ok();
        }
    }
}
