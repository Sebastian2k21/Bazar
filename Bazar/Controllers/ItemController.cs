using AutoMapper;
using Bazar.Data;
using Bazar.Data.Models;
using Bazar.Data.Repositories;
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
        private readonly IItemRepository itemRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.itemRepository = itemRepository;
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        private SelectList CreateCategoriesList()
        {
            var categories = categoryRepository.GetAll();
            return new SelectList(categories, "Id", "Name");
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(itemRepository.GetAllNotSold());
        }

        public IActionResult MyItems()
        {
            var userId = GetUserId();
            return View(itemRepository.GetAllByUserId(userId)); 
        }

        public IActionResult Create()
        {
            ViewBag.Categories = CreateCategoriesList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ItemViewModel model)
        {
            if(ModelState.IsValid)
            {
                var item = mapper.Map<Item>(model);
                item.UserId = GetUserId();
                itemRepository.Create(item);
                return RedirectToAction("Index");
            }

            ViewBag.Categories = CreateCategoriesList();
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var item = itemRepository.GetById(id);
            
            if (item == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.CanBuy = GetUserId() != item.UserId && !item.Sold;
            return View(mapper.Map<ItemDetailsViewModel>(item));
        }

        public IActionResult Delete(int id)
        {
            var item = itemRepository.GetById(id); 
            if (item == null || item.UserId != GetUserId() || item.Sold)
            {
                return RedirectToAction("MyItems");
            }
            itemRepository.Delete(id);
            return RedirectToAction("MyItems");
        }

        public IActionResult Update(int id)
        {
            var item = itemRepository.GetById(id);
            if (item == null || item.UserId != GetUserId() || item.Sold)
            {
                return RedirectToAction("MyItems");
            }

            ViewBag.Categories = CreateCategoriesList();
            return View(mapper.Map<ItemViewModel>(item));
        }

        [HttpPost]
        public IActionResult Update(int id, ItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                var item = itemRepository.GetById(id);
                if (item == null || item.UserId != GetUserId() || item.Sold)
                {
                    return RedirectToAction("MyItems");
                }
                mapper.Map(model, item);
                itemRepository.Update(item);
                return RedirectToAction("Details", new { id=id });
            }

            ViewBag.Categories = CreateCategoriesList();
            return View(model);
        }
    }
}
