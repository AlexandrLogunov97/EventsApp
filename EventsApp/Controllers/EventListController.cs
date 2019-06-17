using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsApp.Controllers
{
    public class EventListController : Controller
    {
        // GET: EventList
        public ActionResult Index()
        {
            return View();
        }
    }
}