using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;	
using System.Web.Mvc;
using transportApp.Models;

namespace transportApp.Controllers
{
    public class EventRegistrationController : Controller
    {
		// GET: EventRegistration
		[HttpGet]
		public ActionResult eventregistration()
        {
            
            return View();
        }
		[HttpPost]
		public ActionResult eventregistration(string eventname, string treffpunkt, string datum, string location)
		{
            EventModel.events.Add(new Event(eventname, treffpunkt, datum));
			// return Content($"Hello {Session["username"].ToString()} Password {Session["password"].ToString()}");
			return RedirectToAction("", "eventübersicht");
		}
	}
}