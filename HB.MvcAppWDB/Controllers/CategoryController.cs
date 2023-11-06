﻿using HB.MvcAppWDB.Context;
using HB.MvcAppWDB.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HB.MvcAppWDB.Controllers
{
    public class CategoryController : Controller
    {

        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Kategori k)
        {


            var result = _context.Kategorler.Any(x => x.Name == k.Name);
            if (!result)
            {

                _context.Kategorler.Add(k);
                _context.SaveChanges();
                return RedirectToAction("List");

            }
            TempData["error"] = "aynı kategoriden iki adet olmaz";
            return RedirectToAction(nameof(Add));  
        }

        public IActionResult List()
        {
            return View(_context.Kategorler.ToList()); ;
        }
    }
}