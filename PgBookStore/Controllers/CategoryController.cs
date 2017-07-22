using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using PgBookStore.Models;
using PgBookStore.Data;

namespace PgBookStore.Controllers
{
    [Authorize(Roles = "user")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext db;
        public CategoryController(ApplicationDbContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var items = db.Categories.Select(p => p);

            return View(items);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category item)
        {
            if(ModelState.IsValid){
                db.Add(item);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var item = db.Categories.SingleOrDefault(p=>p.CategoryID.Equals(id));

            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("CategoryID,Name")] Category item)
        {
            if(ModelState.IsValid){
                db.Update(item);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if(ModelState.IsValid)
            {
                var item = db.Categories.Find(id);
                db.Categories.Remove(item);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
