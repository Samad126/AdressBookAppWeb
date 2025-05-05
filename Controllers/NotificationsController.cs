using Microsoft.AspNetCore.Mvc;

namespace AdressBookAppWeb.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BirthdayDetail()
        {
            return View();
        }

        public IActionResult AddRequestDetail()
        {
            return View();
        }
    }
}
