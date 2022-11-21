using AutoMapper;
using Bazar.Data;
using Bazar.Data.Models;
using Bazar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Bazar.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IMapper mapper;

        public RegisterController(UserManager<User> userManager, IMapper mapper)
        {

            this.userManager = userManager;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = mapper.Map<User>(model);
                var result = await userManager.CreateAsync(user, model.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    ViewBag.Error = result.Errors.First().Description;
                }
            }
            return View(model);
        }
    }
}
