using AutoMapper;
using Bazar.Data.Models;

namespace Bazar.Data.Repositories
{
    public class CategoryFakeRepository : ICategoryRepository
    {
        private readonly List<Category> categories = new List<Category>
        {
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Tools"},
            new Category { Id = 3, Name = "Furniture"},
        };

        private readonly IMapper mapper;
        private int counter = 1;

        public CategoryFakeRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public void Create(Category item)
        {
            item.Id = counter++;
            categories.Add(item);
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            if(category != null)
            {
                categories.Remove(category);
            }
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            return categories.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Category updatedCategory)
        {
            Category category = GetById(updatedCategory.Id);
            if (category != null)
            {
                mapper.Map(updatedCategory, category);
            }
        }
    }
}
