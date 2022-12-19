using AutoMapper;
using Bazar.Data;
using Bazar.Data.Repositories;
using Bazar.DTO.Item;
using Bazar.Models;
using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bazar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterController : ControllerBase
    {
        private readonly IItemRepository itemRepository;
        private readonly IMapper mapper;

        public FilterController(IItemRepository itemRepository, IMapper mapper)
        {
            this.itemRepository = itemRepository;
            this.mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll(string? text = null, int? from = null, int? to = null)
        {
            var items = itemRepository.GetAllNotSold();
            
            if (text is not null)
            {
                items = items.Where(x => x.Name.ToLower().Contains(text.ToLower())).ToList();
            }
            if(from is not null)
            {
                items = items.Where(x => x.Price >= from).ToList();
            }
            if (to is not null)
            {
                items = items.Where(x => x.Price <= to).ToList();
            }

            return Ok(mapper.Map<List<ItemGetDTO>>(items));
        }
    }
}
