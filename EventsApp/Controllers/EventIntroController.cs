using EventsApp.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsApp.Controllers
{
    public class EventIntroController : Controller
    {
        public EventIntroController()
        {

        }
        private static EventIntro CreateIventIntro()
        {
            var item = RenderingContext.Current.ContextItem;
            var eventIntro = new EventIntro()
            {
                Heading=new HtmlString(FieldRenderer.Render(item,"ContentHeading")),
                Body = new HtmlString(FieldRenderer.Render(item, "ContentBody")),
                Image = new HtmlString(FieldRenderer.Render(item, "EventImage","mw=400")),
                Highlights = new HtmlString(FieldRenderer.Render(item, "Highlights")),
                Duration = new HtmlString(FieldRenderer.Render(item, "Duration")),
                DifficultyLevel  = new HtmlString(FieldRenderer.Render(item, "DifficultyLevel")),
                StartDate= new HtmlString(FieldRenderer.Render(item, "StartDate"))
            };
            return eventIntro;
        }
        public ActionResult Index()
        {
            return View(CreateIventIntro());
        }
    }
}