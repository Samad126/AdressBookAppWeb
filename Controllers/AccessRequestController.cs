using Microsoft.AspNetCore.Mvc;

namespace AdressBookAppWeb.Controllers
{
    public class AccessRequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
