using AutoMapper;
using Bazar.Data;
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
        private readonly DataContext context;
        private readonly IMapper mapper;

        public FilterController(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll(string? text = null, int? from = null, int? to = null)
        {
            var items = await context.Items
                .Where(x => !x.Sold)
                .ToListAsync();
            if(text is not null)
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
