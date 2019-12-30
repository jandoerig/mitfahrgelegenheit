using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using transportApp.Models;

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
            User loginUser = UserModel.users.Find(user => user.username.Equals(username));
            if(loginUser == null)
            {
                return RedirectToAction("login", "Login");
            } else
            {
                if (password == loginUser.password)
                {
                    Session["username"] = username;
                    Session["password"] = password;
                    return RedirectToAction("", "eventübersicht");
                }
                else
                {
                    return RedirectToAction("login", "Login");
                }
            }
			// return Content($"Hello {Session["username"].ToString()} Password {Session["password"].ToString()}");
		}
	}
}