using Bazar.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Bazar.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext context;

        public CategoryRepository(DataContext context)
        {
            this.context = context;
        }
        
        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Create(Category item)
        {
            context.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Category item = GetById(id);
            if (item != null)
            {
                context.Remove(item);
                context.SaveChanges();
            }
        }
        public Category GetById(int id)
        {
            return context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Category item)
        {
            context.Update(item);
            context.SaveChanges();
        }
    }
}
