﻿using EventsApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsApp.Controllers
{
    public class EventsListController : Controller
    {
        // GET: Eventslist
        private readonly IEventsProvider provider;
        //public EventsListController():this(new EventsProvider())
        //{

        //}

        public EventsListController(IEventsProvider provider)
        {
            this.provider = provider;
        }
        public ActionResult Index(int page=1)
        {
            return View(provider.GetEventsList(page-1));
        }
    }
}