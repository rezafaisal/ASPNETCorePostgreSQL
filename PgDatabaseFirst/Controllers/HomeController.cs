using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using PgDatabaseFirst.Models;

namespace PgDatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly GuestBookDataContext db;
        public HomeController(GuestBookDataContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GuestBookList()
        {
            var items = db.GuestBooks.ToList();
            
            return View(items);
        }

        [HttpGet]
        public IActionResult GuestBookCreate(){
            return View();
        }

        [HttpPost]
        public IActionResult GuestBookCreate(GuestBook item){
            if(ModelState.IsValid){
                db.Add(item);
                db.SaveChanges();

                return RedirectToAction("GuestBookList");
            }
            return View();
        }
    }
}
