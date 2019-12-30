using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace transportApp.Controllers
{
    public class LoginController : Controller
    {
		// GET: Login
		[HttpGet]
		public ActionResult login()
		{
			return View();
		}
        public ActionResult logout() {
			Session.Remove("username");
			Session.Remove("password");

            return RedirectToAction("", "eventübersicht");
        }

		[HttpPost]
		public ActionResult login(string username, string password)
		{
			Session["username"] = username;
			Session["password"] = password;
			// return Content($"Hello {Session["username"].ToString()} Password {Session["password"].ToString()}");
			return RedirectToAction("", "eventübersicht");
		}
	}
}