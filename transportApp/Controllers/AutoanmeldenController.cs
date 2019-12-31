using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using transportApp.Models;

namespace transportApp.Controllers
{
    public class AutoanmeldenController : Controller
    {
        // GET: Autoanmelden
        [HttpGet]
        public ActionResult autoanmelden(string parameter)
        {
            ViewBag.ClickedEvent = EventModel.events.Find(ev => ev.name.Equals(parameter));
            return View();
        }

        [HttpPost]
        public ActionResult autoanmelden(string drivername, string pickup, string datetime, int emptySeats, string eventname)
        {
            Car car1 = new Car(drivername, pickup, emptySeats, datetime);
            EventModel.events.Find(ev => ev.name.Equals(eventname)).cars.Add(car1);

            return RedirectToAction("", "eventübersicht");
        }
    }
}