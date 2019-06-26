using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp.Models
{
    public class NavigationMenuItem : NavigationItem,ICloneable
    {
        public List<NavigationMenuItem> Children { get; set; }
        public NavigationMenuItem Parent { get; set; }
        public bool IsExcludeFromNavigation { get; set; }
        public NavigationMenuItem()
        {
            Children = new List<NavigationMenuItem>();
        }
        public NavigationMenuItem(string title, string url, IEnumerable<NavigationMenuItem> children) : base(title, url, false)
        {
            Children = children?.ToList();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}