using Microsoft.AspNetCore.Mvc;
using PhotoProg.Models;

namespace PhotoProg.Controllers
{
    public class PictureController : Controller
    {
        private PictureDbContext Context { get; set; }
        public PictureController(PictureDbContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            var pictures = Context.Pictures.ToList();
            return View(pictures);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var pic = Context.Pictures.Find(id);
            return View(pic);

        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Picture pic)
        {
            if (ModelState.IsValid)
            {
                Context.Pictures.Add(pic);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }


            return View(pic);
            
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var pic=Context.Pictures.Find(id);
            return View(pic);
        }

        [HttpPost]
        public IActionResult Edit(Picture pic)
        {
            if (ModelState.IsValid)
            {
                Context.Pictures.Update(pic);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(pic);
            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var pic = Context.Pictures.Find(id);
            return View(pic);

        }

        [HttpPost]
        public IActionResult Delete(Picture pic)
        {
            if (ModelState.IsValid)
            {
                Context.Pictures.Remove(pic);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }

            return View(pic);
        }



    }
}
