using Bazar.Data.Models;

namespace Bazar.Data.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Create(Category item);
        void Update(Category item);
        void Delete(int id);
    }
}
