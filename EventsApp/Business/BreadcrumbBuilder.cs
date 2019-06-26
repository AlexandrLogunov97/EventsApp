using EventsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Extensions.DependencyInjection.Extensions;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using EventsApp.Utils;
using Sitecore.Data;
using Sitecore;

namespace EventsApp.Business
{
    public class BreadcrumbBuilder : IBreadcrumbBuilder
    {
        readonly RenderingContext renderingContext;
        public BreadcrumbBuilder()
        {
            this.renderingContext = RenderingContext.Current;
        }

        public IEnumerable<NavigationItem> Build()
        {
            var homeItem = Sitecore.Context.Database.GetItem(Context.Site.StartPath);
            return homeItem == null ?
                Enumerable.Empty<NavigationItem>() :
                renderingContext
                .ContextItem
                .GetAncestors()
                .Where(i => homeItem.IsAncestorOrSelf(i) && Navigation.IsNavigationItem(i))
                .Select(i => new NavigationItem(i.DisplayName, i.GetUrl(), false))
                .Concat(
                    new[]{
                        new NavigationItem(renderingContext.ContextItem.DisplayName, renderingContext.ContextItem.GetUrl(), true)}
                    );

        }
    }
}