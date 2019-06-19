using Sitecore.ContentSearch.FieldReaders;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp.Models
{
    public class EventDetails:SearchResultItem
    {
        public string ContentHeading { get; set; }
        public string ContentIntro { get; set; }
        public DateTime StartTime { get; set; }
        public HtmlString EventImage => new HtmlString(FieldRenderer.Render(this.GetItem(),"EventImage","DisableWebEditing=true&mw=150"));

    }
}