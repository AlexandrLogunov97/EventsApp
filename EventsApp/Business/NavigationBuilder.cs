using EventsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TAC.Sitecore.Abstractions.Interfaces;
using TAC.Sitecore.Abstractions.SitecoreImplementation;

namespace EventsApp.Business
{
    public class NavigationBuilder
    {
        readonly IRenderingContext context;
        public NavigationBuilder(): this(SitecoreRenderingContext.Create())
        {

        }
        public NavigationBuilder(IRenderingContext context)
        {
            this.context = context;
        }
        public NavigationMenuItem Build()
        {
            var root = context?.DatasourceOrContextItem;
            return new NavigationMenuItem
            (
                title: root?.DisplayName,
                url: root?.Url,
                children: root != null && context?.ContextItem != null ? Build(root, context.ContextItem): null
            );
        }
        private IEnumerable<NavigationMenuItem> Build(IItem node,IItem current)
        {
            return node.GetChildren().Select(i =>
            new NavigationMenuItem
            (
                title: i.DisplayName,
                url: i.Url,
                children: i.IsAncestorOrSelf(current)? Build(i, current): null
            ));
        }
    }
}