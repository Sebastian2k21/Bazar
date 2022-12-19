using Bazar.Data.Models;

namespace Bazar.Data.Repositories
{
    public interface IItemRepository
    {
        List<Item> GetAll();
        List<Item> GetAllByUserId(string userId);
        List<Item> GetAllNotSold();
        Item GetById(int id);
        void Create(Item item);
        void Update(Item item);
        void Delete(int id);
    }
}
