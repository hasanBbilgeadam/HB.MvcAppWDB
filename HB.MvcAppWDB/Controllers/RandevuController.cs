using HB.MvcAppWDB.Context;
using HB.MvcAppWDB.Entities;
using HB.MvcAppWDB.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HB.MvcAppWDB.Controllers
{
    public class RandevuController : Controller
    {
        private readonly AppDbContext _context;

        public RandevuController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {



            var islemTipleri = Enum.GetValues(typeof(işlem))

                      .Cast<işlem>()

                      .Select(e => new SelectListItem()
                      {

                          Text = e.ToString(),

                          Value = ((int)e).ToString()

                      }).ToList();

            ViewBag.islem = islemTipleri;

            return View();

        }
        [HttpPost]

        public IActionResult Add(Randevu randevu)
        {

        //18.05
        //19.05

            //18.40  => 17.40
            //18.40  => 19.40


          var result =   _context.Randevus.Any(x => x.RandevuTarih > randevu.RandevuTarih.AddHours(-1) && x.RandevuTarih < randevu.RandevuTarih.AddHours(1));

            if (!result)
            {

            _context.Randevus.Add(randevu);
            _context.SaveChanges();
            
            }
            return Redirect("/home/index");
        }
        public IActionResult List()
        {
            return View();
        }


    }
}
