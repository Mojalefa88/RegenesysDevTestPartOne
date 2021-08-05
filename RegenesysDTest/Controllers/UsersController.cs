using RegenesysDTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegenesysDTest.Controllers
{
    public class UsersController : Controller
    {
        private DataContext dbContext = new DataContext();
        // GET: Users
        public ActionResult Index()
        {
            return View(dbContext.Users.ToList());
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                user.DateStamp = DateTime.Now;
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                //return RedirectToAction("index");
            }
            return View(user);
        }
    }
}