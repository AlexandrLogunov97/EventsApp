using EventsApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsApp.Controllers
{
    public class BreadcrumbController : Controller
    {
        private readonly BreadcrumbBuilder builder;
        // GET: Breadcrumb
        public BreadcrumbController(): this(new BreadcrumbBuilder())
        {

        }

        public BreadcrumbController(BreadcrumbBuilder builder)
        {
            this.builder = builder;
        }

        public ActionResult Index()
        {
            return View(builder.Build());
        }
    }
}