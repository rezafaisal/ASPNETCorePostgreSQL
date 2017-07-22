using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PgBookStore.Models;
using PgBookStore.Data;

namespace PgBookStore.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext db;
        public AuthorController(ApplicationDbContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var items = db.Authors.Select(p => p);

            return View(items);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author item)
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
            var item = db.Authors.SingleOrDefault(p=>p.AuthorID.Equals(id));
            
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("AuthorID,Name, Email")] Author item)
        {
            if(ModelState.IsValid){
                db.Update(item);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(item);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if(ModelState.IsValid)
            {
                var item = db.Authors.Find(id);
                db.Authors.Remove(item);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}