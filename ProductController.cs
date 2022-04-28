using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFcore1.Models;

namespace EFcore1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                ProductDBcontext dBContext = new ProductDBcontext();
                dBContext.Add(p);
                dBContext.SaveChanges();
                return Content("Saved");

            }
            return View("Index");
        }
    }
}
