using Bazar.Data;
using Bazar.Data.Models;
using Bazar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Bazar.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public LoginController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = userManager.FindByEmailAsync(model.Email).Result;
                if(user == null)
                {
                    ViewBag.EmailError = "Invalid email";
                    return View();
                }
                var result = userManager.CheckPasswordAsync(user, model.Password).Result;
                if (!result)
                {
                    ViewBag.EmailError = "Invalid password";
                    return View();
                }

                signInManager.SignInAsync(user, true).Wait();

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
