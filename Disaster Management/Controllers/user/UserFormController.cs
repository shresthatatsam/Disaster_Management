using Disaster_Management.Models.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Disaster_Management.Controllers.user
{
    public class UserFormController : Controller
    {
        private readonly IDisasterViewModel _disaster;

        public UserFormController(IDisasterViewModel disaster)
        {
        _disaster = disaster;
        }

        public IActionResult Index()
        {
            ViewBag.disasterList = _disaster.getAllDisasters();
            return View();
        }

       
    }
}
