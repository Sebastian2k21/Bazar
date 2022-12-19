using AutoMapper;
using Bazar.Data.Models;
using System.Diagnostics.Metrics;

namespace Bazar.Data.Repositories
{
    public class ItemFakeRepository : IItemRepository
    {
        private readonly IMapper mapper;
        private List<Item> items = new List<Item>();
        private int counter = 1;

        public ItemFakeRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }


        public void Create(Item item)
        {
            item.Id = counter++;
            items.Add(item);
        }

        public void Delete(int id)
        {
            Item item = GetById(id);
            if(item != null)
            {
                items.Remove(item); 
            }
        }

        public List<Item> GetAll()
        {
            return items;
        }

        public List<Item> GetAllByUserId(string userId)
        {
            return items.Where(x => x.UserId == userId).ToList();
        }

        public List<Item> GetAllNotSold()
        {
            return items.Where(x => !x.Sold).ToList();
        }

        public Item GetById(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Item updatedItem)
        {
            Item item = GetById(updatedItem.Id);
            if (item != null)
            {
                mapper.Map(updatedItem, item);
            }
        }
    }
}
