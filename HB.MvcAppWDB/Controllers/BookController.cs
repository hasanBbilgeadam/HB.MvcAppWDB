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

        public IActionResult List()
        {
            

            // kategorisi null olan kitaplar gelmiyor
            //bunun için join kodunda değişiklik yapılması gerekiyor !!!!!
            return View(_context.Kitaplar.Include(x => x.Kategori).ToList()) ;
        }
       


        public IActionResult Update(int id)
        {
             var data = _context.Kitaplar.Find(id);

            ViewBag.kategoriler = _context.Kategorler.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected =x.Id == data.KategoriID
                
            }).ToList();


            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Kitap kitap)
        {


            _context.Update(kitap);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var data =  _context.Kitaplar.Find(id);
            _context.Kitaplar.Remove(data);
            _context.SaveChanges();


            return RedirectToAction("List");
        }

    }
}
