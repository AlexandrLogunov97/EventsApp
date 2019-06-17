using EventsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TAC.Sitecore.Abstractions.Interfaces;
using TAC.Sitecore.Abstractions.SitecoreImplementation;

namespace EventsApp.Business
{
    public class BreadcrumbBuilder
    {
        readonly IRenderingContext context;
        public BreadcrumbBuilder() : this(SitecoreRenderingContext.Create())
        {

        }
        public BreadcrumbBuilder(IRenderingContext context)
        {
            this.context = context;
        }
        public IEnumerable<NavigationItem> Build()
        {
            return context?.HomeItem == null || context?.HomeItem == null ?
                Enumerable.Empty<NavigationItem>() :
                context
                .ContextItem
                .GetAncestors()
                .Where(i => context.HomeItem.IsAncestorOrSelf(i))
                .Select(i => new NavigationItem(
                    title: i.DisplayName,
                    url: i.Url,
                    active: false
                    ))
                .Concat(
                    new[]
                    {
                        new NavigationItem
                        (
                            title: context.ContextItem.DisplayName,
                            url: context.ContextItem.Url,
                            active: true
                            )
                    }
                    );

        }
    }
}