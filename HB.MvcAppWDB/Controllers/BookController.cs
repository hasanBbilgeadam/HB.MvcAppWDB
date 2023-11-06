using HB.MvcAppWDB.Context;
using HB.MvcAppWDB.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HB.MvcAppWDB.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {

            var data = _context.Kategorler.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();
            ViewBag.data = data;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Kitap k)
        {

            _context.Kitaplar.Add(k);
            _context.SaveChanges();

            return RedirectToAction("List");
        }

        public IActionResult List() => 
            View(_context.Kitaplar.Include(x => x.Kategori).ToList());


    }
}
