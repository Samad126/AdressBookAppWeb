using Microsoft.AspNetCore.Mvc;

namespace AdressBookAppWeb.Controllers
{
    public class GroupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddGroup()
        {
            return View();
        }
        public IActionResult EditGroup()
        {
            return View();
        }
    }
}
