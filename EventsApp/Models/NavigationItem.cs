using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp.Models
{
    public class NavigationItem
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public bool Active { get; set; }
        public NavigationItem(string title, string url, bool active=false)
        {
            this.Title = title;
            this.Url = url;
            this.Active = active;
        }
    }
}