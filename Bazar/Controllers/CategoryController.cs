using AutoMapper;
using Bazar.Data;
using Bazar.Data.Models;
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
        private readonly DataContext context;
        private readonly IMapper mapper;

        public CategoryController(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            return Ok(mapper.Map<List<CategoryGetDTO>>(context.Categories.ToList()));
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult Get(int id)
        {
            var category = context.Categories.Find(id);
            if (category is null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<CategoryGetDTO>(category));
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateDTO category)
        {
            context.Categories.Add(mapper.Map<Category>(category));
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryCreateDTO category)
        {
            var categoryToUpdate = context.Categories.Find(id);
            if (categoryToUpdate is null)
            {
                return NotFound();
            }
            mapper.Map(category, categoryToUpdate);
            context.Update(categoryToUpdate);
            context.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = context.Categories.Find(id);
            if (category is null)
            {
                return NotFound();
            }
            context.Categories.Remove(category);
            context.SaveChanges();
            return Ok();
        }
    }
}
