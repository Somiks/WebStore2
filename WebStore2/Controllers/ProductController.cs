using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore2.Models;

namespace WebStore2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Random()
        {
            var product = new Product()
            {
                Name = "proudct 1"
            };

            return View(product);
        }
    }
}