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

        public RegisterController(UserManager<User> userManager)
        {

            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new User
                {
                    Email = model.Email,
                    UserName = model.Username
                };
                userManager.CreateAsync(user, model.Password).Wait();
                return RedirectToAction("Index", "Login");
            }
            return View(model);
        }
    }
}
