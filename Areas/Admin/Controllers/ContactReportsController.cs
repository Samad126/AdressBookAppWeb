using Microsoft.AspNetCore.Mvc;

namespace AdressBookAppWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactReportDetail()
        {
            return View();
        }
    }
}
