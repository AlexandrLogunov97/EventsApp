using EventsApp.Models;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventsApp.Utils;

namespace EventsApp.Business
{
    public class RelatedEventsProvider: IRelatedEventsProvider
    {
        RenderingContext renderingContext;
        public RelatedEventsProvider()
        {
            this.renderingContext = RenderingContext.Current;
        }
        public IEnumerable<NavigationItem> GetRelatedEvents()
        {
            return renderingContext.ContextItem
                .GetMultilistFieldItems("ReletedEvents")
                .Select(i =>
                    new NavigationItem(i.DisplayName, i.GetUrl() )
                );
        }
    }
}