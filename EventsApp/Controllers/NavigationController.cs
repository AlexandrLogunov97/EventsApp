using EventsApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsApp.Controllers
{
    public class NavigationController : Controller
    {
        NavigationBuilder builder;
        //public NavigationController(): this(new NavigationBuilder())
        //{

        //}
        public NavigationController(NavigationBuilder builder)
        {
            this.builder = builder;
        }
        // GET: Navigation
        public ActionResult Index()
        {
            var navigationMenuItem = builder.Build();
            return View(navigationMenuItem);
        }
    }
}