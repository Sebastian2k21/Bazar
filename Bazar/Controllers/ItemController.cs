using AutoMapper;
using Bazar.Data;
using Bazar.Data.Models;
using Bazar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Bazar.Controllers
{
    [Authorize]
    public class ItemController : Controller
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public ItemController(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(context.Items.ToList());
        }

        public IActionResult Create()
        {
            var categories = context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(ItemViewModel model)
        {
            if(ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var item = mapper.Map<Item>(model);
                item.UserId = userId;
                context.Add(item);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            var categories = context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var item = context.Items
                .Include(x => x.User)
                .Include(x => x.Category)
                .FirstOrDefault(x => x.Id == id);
            
            if (item == null)
            {
                return RedirectToAction("Index");
            }
            return View(mapper.Map<ItemDetailsViewModel>(item));
        }
    }
}
