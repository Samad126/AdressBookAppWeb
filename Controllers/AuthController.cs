using Microsoft.AspNetCore.Mvc;

namespace AdressBookAppWeb.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ResetPass()
        {
            return View();
        }

        public IActionResult ResetPassEnd()
        {
            return View();
        }
    }
}
