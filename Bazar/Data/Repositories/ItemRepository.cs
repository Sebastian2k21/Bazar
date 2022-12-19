using Bazar.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Bazar.Data.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext context;

        public ItemRepository(DataContext context)
        {
            this.context = context;
        }
        
        public void Create(Item item)
        {
            context.Add(item);
            context.SaveChanges();
        }
         
        public void Delete(int id)
        {
            Item item = GetById(id);
            if(item != null)
            {
                context.Remove(item);
                context.SaveChanges();
            }
        }

        public List<Item> GetAll()
        {
            return context.Items
                .Include(x => x.User)
                .Include(x => x.Category)
                .ToList();
        }

        public List<Item> GetAllByUserId(string userId)
        {
            return context.Items
               .Include(x => x.User)
               .Include(x => x.Category)
               .Where(x => x.UserId == userId)
               .ToList();
        }

        public List<Item> GetAllNotSold()
        {
            return context.Items
               .Include(x => x.User)
               .Include(x => x.Category)
               .Where(x => !x.Sold)
               .ToList();
        }

        public Item GetById(int id)
        {
            return context.Items
                .Include(x => x.User)
                .Include(x => x.Category)
                .FirstOrDefault(x => x.Id == id);
        }

        public void Update(Item item)
        {
            context.Update(item);
            context.SaveChanges();
        }
    }
}
