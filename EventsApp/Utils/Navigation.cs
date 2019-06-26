using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp.Utils
{
    public static class Navigation
    {
        public static bool IsNavigationItem(Item item)
        {
            var navigationTemplateID = Sitecore.Configuration.Settings.GetSetting("NavigationTemplateID");
            return item.ContainsTemplate(new ID(navigationTemplateID));
        }
    }
}