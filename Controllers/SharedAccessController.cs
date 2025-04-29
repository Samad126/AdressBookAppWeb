using Microsoft.AspNetCore.Mvc;

namespace AdressBookAppWeb.Controllers
{
    public class SharedAccessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
