using Microsoft.AspNetCore.Mvc;

namespace AdressBookAppWeb.Areas.Admin.Controllers
{
    public class ProfileController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
