using Microsoft.AspNetCore.Mvc;

namespace AdressBookAppWeb.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Report(int id)
        {
            return View(id);
        }
    }
}
