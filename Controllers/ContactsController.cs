using Microsoft.AspNetCore.Mvc;

namespace AdressBookAppWeb.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddContact()
        {
            return View();
        }
        public IActionResult EditContact()
        {
            return View();
        }
        public IActionResult SearchUser()
        {
            return View();
        }
        public IActionResult ContactDetail(int userId)
        {
            ViewBag.UserId = userId;
            return View();
        }
    }
}
