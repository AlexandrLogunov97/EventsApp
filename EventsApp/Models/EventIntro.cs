using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp.Models
{
    public class EventIntro
    {
        public HtmlString Heading { get; set; }
        public HtmlString Body { get; set; }
        public HtmlString Image { get; set; }
        public HtmlString Highlights { get; set; }
        public HtmlString Duration { get; set; }
        public HtmlString DifficultyLevel { get; set; }
        public HtmlString StartDate { get; set; }
    }
}