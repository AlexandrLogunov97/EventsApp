using EventsApp.Business;
using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsApp.Controllers
{
    public class BreadcrumbController : Controller
    {
        private readonly IBreadcrumbBuilder _builder;

        public BreadcrumbController(IBreadcrumbBuilder builder)
        {
            _builder = builder;
        }

        public ActionResult Index()
        {
            return View(_builder.Build());
        }
    }
}