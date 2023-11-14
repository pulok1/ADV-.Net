using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;
using ZeroHunger.Models;

namespace ZeroHunger.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        [HttpGet]
        public ActionResult VolunteerLogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VolunteerLogIn(VolunteerLogInDTO volog)
        {
            var db = new HungerEntities1();
            var user = (from v in db.Volunteers
                        where v.email.Equals(volog.email) && v.password.Equals(volog.password) 
                        select v).SingleOrDefault();
            if (user != null) 
            {
                Session["volunteerEmail"] = user.email;
                return RedirectToAction("Index", "Landing");
            }
            return View();
        }
        [HttpGet]
        public ActionResult RestaurantLogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RestaurantLogIn(RestaurantLogInDTO reslog)
        {
            var db = new HungerEntities1();
            var user = (from rest in db.Restaurants
                        where rest.email.Equals(reslog.email) && rest.password.Equals(reslog.password)
                        select rest).SingleOrDefault();
            if (user != null)
            {
                Session["restaurantEmail"] = user.email;
                return RedirectToAction("Index", "Landing");
            }
            return View();
        }
        [HttpGet]
        public ActionResult NgoLogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NgoLogIn(NgoDTO ngo)
        {
            var db = new HungerEntities1();
            var user = (from n in db.NGOes
                        where n.email.Equals(ngo.email) && n.password.Equals(ngo.password)
                        select n).SingleOrDefault();
            if (user != null)
            {
                Session["ngoEmail"] = ngo.email;
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }
    }
}