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

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(context.Items.Where(x => !x.Sold).ToList());
        }

        public IActionResult MyItems()
        {
            var userId = GetUserId();
            return View(context.Items.Where(x => x.UserId == userId).ToList());
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
                var item = mapper.Map<Item>(model);
                item.UserId = GetUserId();
                context.Add(item);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            var categories = context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View(model);
        }

        [AllowAnonymous]
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
            ViewBag.CanBuy = GetUserId() != item.UserId && !item.Sold;
            return View(mapper.Map<ItemDetailsViewModel>(item));
        }

        public IActionResult Delete(int id)
        {
            var item = context.Items.Find(id);
            if (item == null || item.UserId != GetUserId() || item.Sold)
            {
                return RedirectToAction("MyItems");
            }
            context.Remove(item);
            context.SaveChanges();
            return RedirectToAction("MyItems");
        }

        public IActionResult Update(int id)
        {
            var item = context.Items.Find(id);
            if (item == null || item.UserId != GetUserId() || item.Sold)
            {
                return RedirectToAction("MyItems");
            }

            var categories = context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View(mapper.Map<ItemViewModel>(item));
        }

        [HttpPost]
        public IActionResult Update(int id, ItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                var item = context.Items.Find(id);
                if (item == null || item.UserId != GetUserId() || item.Sold)
                {
                    return RedirectToAction("MyItems");
                }
                mapper.Map(model, item);
                context.Update(item);
                context.SaveChanges();
                return RedirectToAction("Details", new { id=id });
            }

            var categories = context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View(model);
        }
    }
}
