using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;
using ZeroHunger.Models;

namespace ZeroHunger.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        [HttpGet]
        public ActionResult VolunteerSignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VolunteerSignUp(VolunteerDTO volunteer)
        {
            if(ModelState.IsValid)
            {
                var db = new HungerEntities1();
                db.Volunteers.Add(Convert(volunteer));
                db.SaveChanges();
                return RedirectToAction("VlounteerLogIn", "LogIn");
            }
            return View();
        }
        [HttpGet]
        public ActionResult RestaurentSignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RestaurentSignUp(RestaurantDTO restaurant)
        {
            if (ModelState.IsValid)
            {
                var db = new HungerEntities1();
                db.Restaurants.Add(Convert(restaurant));
                db.SaveChanges();
                return RedirectToAction("RestaurantLogIn", "LogIn");
            }
            return View();  
        }
        Volunteer Convert(VolunteerDTO volunteer) 
        {
            var vol = new Volunteer()
            {
                id = volunteer.id,
                firstname = volunteer.firstname,
                lastname = volunteer.lastname,
                email = volunteer.email,
                gender = volunteer.gender,
                phone = volunteer.phone,
                position = volunteer.position,
                address = volunteer.address,
                age = volunteer.age,
                password = volunteer.password
            };
            return vol; 
        }
        VolunteerDTO Convert(Volunteer volunteer)
        {
            var vol = new VolunteerDTO()
            {
                id = volunteer.id,
                firstname = volunteer.firstname,
                lastname = volunteer.lastname,
                email = volunteer.email,
                gender = volunteer.gender,
                phone = volunteer.phone,
                position = volunteer.position,
                address = volunteer.address,
                age = volunteer.age,
                password = volunteer.password

            };
            return vol;
        }
        List<VolunteerDTO> Convert(List<Volunteer> volunteers) 
        { 
            var vols = new List<VolunteerDTO>();
            foreach (var item in volunteers) 
            {
                vols.Add(Convert(item));
            }
            return vols; 
        }
        Restaurant Convert(RestaurantDTO restaurant)
        {
            var res = new Restaurant()
            {
                id = restaurant.id,
                name = restaurant.name,
                address = restaurant.address,
                contact = restaurant.contact,
                email = restaurant.email,
                type = restaurant.type,
                password = restaurant.password
            };
            return res;
        }
        RestaurantDTO Convert(Restaurant restaurant)
        {
            var res = new RestaurantDTO()
            {
                id = restaurant.id,
                name = restaurant.name,
                address = restaurant.address,
                contact = restaurant.contact,
                email = restaurant.email,
                type = restaurant.type,
                password = restaurant.password
            };
            return res;
        }
        List<RestaurantDTO> Convert(List<Restaurant> restaurants)
        {
            var rest = new List<RestaurantDTO>();
            foreach(var item in restaurants)
            {
                rest.Add(Convert(item));
            }
            return rest;
        }
    }
}