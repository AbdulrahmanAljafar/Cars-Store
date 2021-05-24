using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsStore.Controllers
{
    public class CarsController : Controller
    {
        public string Index()
        {
            return "test";
        }

        public IActionResult Details()
        {
            ViewData["Name"] = "BMW";
            ViewData["Model"] = 2020;
            ViewData["Color"] = "Black";

            return View();
        }

        public IActionResult Type()
        {
            return View();
        }
    }
}
