using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;	
using System.Web.Mvc;

namespace transportApp.Controllers
{
    public class EventRegistrationController : Controller
    {
		// GET: EventRegistration
		[HttpGet]
		public ActionResult Index()
        {
            return View();
        }
		[HttpPost]
		public ActionResult Index(string eventname, string treffpunkt, string datum, string location)
		{
			// return Content($"Hello {Session["username"].ToString()} Password {Session["password"].ToString()}");
			return RedirectToAction("", "eventübersicht");
		}
	}
}