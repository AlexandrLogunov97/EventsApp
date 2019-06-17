using EventsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TAC.Sitecore.Abstractions.Interfaces;
using TAC.Sitecore.Abstractions.SitecoreImplementation;

namespace EventsApp.Business
{
    public class RelatedEventsProvider
    {
        IRenderingContext context;
        public RelatedEventsProvider(): this(SitecoreRenderingContext.Create())
        {
            
        }
        public RelatedEventsProvider(IRenderingContext context)
        {
            this.context = context;
        }
        public IEnumerable<NavigationItem> GetRelatedEvents()
        {
            return context.ContextItem
                .GetMultilistFieldItems("ReletedEvents")
                .Select(i =>
                new NavigationItem
                (
                    title: i.DisplayName,
                    url: i.Url
                ));
        }
    }
}