using AutoMapper;
using Bazar.Data;
using Bazar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bazar.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public AdminController(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var users = context.Users.ToList();
            return View(mapper.Map<List<UserViewModel>>(users));
        }
    }
}
