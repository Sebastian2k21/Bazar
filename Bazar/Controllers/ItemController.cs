using Bazar.Data;
using Bazar.Data.Models;
using Bazar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace Bazar.Controllers
{
    [Authorize]
    public class ItemController : Controller
    {
        private readonly DataContext context;

        public ItemController(DataContext context)
        {
            this.context = context;
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
                var useId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var item = new Item
                {
                    CategoryId = model.CategoryId,
                    CourierDelivery = model.CourierDelivery,
                    Description = model.Description,
                    IsNew = model.IsNew,
                    Name = model.Name,
                    PickupInPerson = model.PickupInPerson,
                    Price = model.Price,
                    UserId = useId
                };

                context.Add(item);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            var categories = context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View(model);
        }
    }
}
