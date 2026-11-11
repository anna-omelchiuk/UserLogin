using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserLogin.Models;

namespace UserLogin.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPost(User model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.SuccessMessage = "Registration completed successfully!";
                return View("Register", model);
            }

            return View("Register", model);
        }
    }
}
