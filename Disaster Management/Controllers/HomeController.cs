﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Disaster_Management.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

      
    }
}
