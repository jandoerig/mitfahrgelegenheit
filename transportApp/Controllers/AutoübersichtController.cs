using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using transportApp.Models;

namespace transportApp.Controllers
{
    public class AutoübersichtController : Controller
    {
        // GET: Autoübersicht
        public ActionResult autoübersicht(string parameter)
        {
            ViewBag.ClickedEvent = EventModel.events.Find(ev => ev.name.Equals(parameter));
            return View();
        }
    }
}