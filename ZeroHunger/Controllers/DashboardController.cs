using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;
using ZeroHunger.Models;

namespace ZeroHunger.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            var db = new HungerEntities1();
            var requests = db.Requests.ToList();

            if (requests != null && requests.Count > 0)
            {
                var modelList = requests.Select(r => new RequestDTO()
                {
                    id = r.id,
                    restaurentName = r.retaurant_name,
                    requestDate = r.requestdate,
                    status = r.status,
                    quantity = r.quantity
                }).ToList();

                return View(modelList);
            }

            return View();
        }
        [HttpGet]
        public ActionResult Restaurant()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Restaurant(RequestDTO request)
        {
            if(ModelState.IsValid)
            {
                var db = new HungerEntities1();
                db.Requests.Add(Convert(request));
                db.SaveChanges();
                ViewBag.msg = "Successfully Requested";
                return RedirectToAction("Restaurant");
            }
            return View();
        }
        [HttpGet]
        public ActionResult RequstVolunteer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RequstVolunteer(PickupDTO pickup)
        {
            if (ModelState.IsValid)
            {
                var db = new HungerEntities1();
                db.PickupInfoes.Add(Convert(pickup));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        Request Convert(RequestDTO request)
        {
            var req = new Request()
            {
                id = request.id,
                retaurant_name = request.restaurentName,
                requestdate = request.requestDate,
                status = request.status,
                quantity = request.quantity
            };
            return req;
        }

        RequestDTO Convert(Request request)
        {
            var req = new RequestDTO()
            {
                id = request.id,
                restaurentName = request.retaurant_name,
                requestDate = request.requestdate, 
                status = request.status,
                quantity = request.quantity
            };
            return req;
        }

        PickupInfo Convert(PickupDTO pickup)
        {
            var pick = new PickupInfo()
            {
                id = pickup.id,
                restaurant_requested = pickup.restaurentRequsted,
                status = pickup.status,
                quantity = pickup.quantity,
                last_pickup_allowed = pickup.lastPickupAllowed,
                dilivery_address = pickup.diliveryAddress
            };
            return pick;
        }
    }
}