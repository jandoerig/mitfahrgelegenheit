using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;
using transportApp.Models;

namespace transportApp.Controllers
{
    public class EventübersichtController : Controller
    {

        public void MessageboxShow(User user)
        {
            MessageBox.Show(user.username);
        }

        // GET: Eventübersicht
        public ActionResult eventübersicht()
        {
            ViewBag.List = EventModel.events;
            return View();
        }
    }
}