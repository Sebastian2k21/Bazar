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
    public class OrderController : Controller
    {
        private readonly DataContext context;
        private readonly IItemRepository itemRepository;
        private readonly IMapper mapper;

        public OrderController(DataContext context, IItemRepository itemRepository, IMapper mapper)
        {
            this.context = context;
            this.itemRepository = itemRepository;
            this.mapper = mapper;
        }

        private void SetDataToViewBag()
        {
            var paymentMethods = context.PaymentMethods.ToList();
            var deliveryMethods = context.DeliveryMethods.ToList();
            ViewBag.PaymentMethods = new SelectList(paymentMethods, "Id", "Name");
            ViewBag.DeliveryMethods = new SelectList(deliveryMethods, "Id", "Name");
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public IActionResult Buy(int id)
        {
            var item = itemRepository.GetById(id);
            if (item == null || item.Sold || GetUserId() == item.UserId)
            {
                return RedirectToAction("Index", "Item");
            }
            ViewBag.Item = item;
            SetDataToViewBag();
            return View();
        }

        [HttpPost]
        public IActionResult Buy(int id, OrderViewModel model)
        {
            var item = context.Items.Find(id);
            if (item == null || item.Sold || GetUserId() == item.UserId)
            {
                return RedirectToAction("Index", "Item");
            }
            
            if (ModelState.IsValid)
            {
                var order = mapper.Map<Order>(model);
                order.ItemId = id;
                order.BuyerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                context.Orders.Add(order);
                item.Sold = true;
                context.SaveChanges();
                return RedirectToAction("Index", "Item");
            }
            
            ViewBag.Item = item;
            SetDataToViewBag();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var order = context.Orders
                .Include(x => x.Item)
                .Include(x => x.DeliveryMethod)
                .Include(x => x.PaymentMethod)
                .FirstOrDefault(x => x.Id == id);
            if (order == null || order.BuyerId != GetUserId())
            {
                return RedirectToAction("Index", "Order");
            }
            return View(mapper.Map<OrderDetailsViewModel>(order));
        }

        public IActionResult Index()
        {
            {
                var orders = context.Orders
                    .Include(x => x.Item)
                    .Include(x => x.DeliveryMethod)
                    .Include(x => x.PaymentMethod)
                    .Where(x => x.BuyerId == GetUserId())
                    .ToList();
                return View(orders);
            }
        }
    }
        
    
}
