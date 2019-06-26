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
        static string navigationTemplateID=string.Empty;      
        static Navigation()
        {
            navigationTemplateID = Sitecore.Configuration.Settings.GetSetting("NavigationTemplateID");
        }
        public static bool IsNavigationItem(Item item)
        {
            return item.ContainsTemplate(new ID(navigationTemplateID));
        }
    }
}