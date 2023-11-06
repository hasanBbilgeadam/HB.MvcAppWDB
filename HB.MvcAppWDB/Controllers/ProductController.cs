using HB.MvcAppWDB.Context;
using HB.MvcAppWDB.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HB.MvcAppWDB.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            return RedirectToAction(nameof(List));
        }
        public IActionResult List() => View(_context.Products.ToList());



    }
}
