using Microsoft.AspNetCore.Mvc;

namespace Disaster_Management.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
