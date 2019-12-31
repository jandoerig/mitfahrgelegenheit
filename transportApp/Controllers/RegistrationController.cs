using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using transportApp.Models;

namespace transportApp.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
		[HttpGet]
        public ActionResult register()
		{
            return View();
        }

		[HttpPost]
		public ActionResult register(string username, string password1, string password2)
		{
			if (username != "" && password1 != "" && password2 != "") {
				Console.WriteLine(username+ " " + password1 + " " + password2);
				User User = new User(username, password1, password2);
				UserModel.users.Add(User);
				Session["username"] = username;
				Session["password"] = password1;
				return RedirectToAction("", "eventübersicht");
			}
			return View();
		}
	}
}