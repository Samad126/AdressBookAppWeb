using Microsoft.AspNetCore.Mvc;

namespace AdressBookAppWeb.Controllers
{
    public class SharedAccessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult ContactDetails()
        {
            return View();
        }
    }
}
