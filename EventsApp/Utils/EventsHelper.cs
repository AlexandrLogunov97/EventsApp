using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp.Utils
{
    public static class EventsHelper
    {
        public static bool IsEventsListItem(Item item)
        {
            var eventsListTemplateID = Sitecore.Configuration.Settings.GetSetting("EventsListTemplateID");
            return item.ContainsTemplate(new ID(eventsListTemplateID));
        }
    }
}