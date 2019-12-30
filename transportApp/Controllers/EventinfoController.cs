using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using transportApp.Models;

namespace transportApp.Controllers
{
    public class EventinfoController : Controller
    {
        // GET: Eventinfo
        public ActionResult eventinfo(string parameter)
        {
            ViewBag.ClickedEvent = EventModel.events.Find(ev => ev.name.Equals(parameter));
            return View();
        }
    }
}