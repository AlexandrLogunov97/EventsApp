using EventsApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsApp.Controllers
{
    public class RelatedEventsController : Controller
    {
        RelatedEventsProvider provider;
        public RelatedEventsController() : this(new RelatedEventsProvider())
        {

        }
        public RelatedEventsController(RelatedEventsProvider relatedEvents)
        {
            this.provider = relatedEvents;
        }
        public ActionResult Index()
        {
            return View(provider.GetRelatedEvents());
        }
    }
}