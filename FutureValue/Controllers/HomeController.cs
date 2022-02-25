using FutureValue.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureValue.Controllers {
    public class HomeController : Controller {
     
        [HttpGet]
        public IActionResult Index() {

            ViewBag.Name = "Mary";
            ViewBag.FV = 99999.99;
            return View();

        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model) {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model);
        }



    }
}
