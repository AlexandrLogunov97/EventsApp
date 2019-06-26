using EventsApp.Models;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TAC.Sitecore.Abstractions.Interfaces;
using TAC.Sitecore.Abstractions.SitecoreImplementation;
using EventsApp.Utils;
using Sitecore.Data.Items;
using Sitecore.Collections;
using Sitecore.Data.Fields;

namespace EventsApp.Business
{
    public class NavigationBuilder : INavigationBuilder
    {
        readonly RenderingContext renderingContext;
        public NavigationBuilder()
        {
            this.renderingContext = RenderingContext.Current;
        }
        public NavigationMenuItem Build()
        {
            var root = renderingContext?.GetDatasourceOrContextItem();
            var items = new List<NavigationMenuItem>();

            Build(root, items, null);

            var navigationMenuItem = new NavigationMenuItem
            (
                title: root?.DisplayName,
                url: root?.GetUrl(),
                children: root != null && renderingContext?.ContextItem != null ? items : null
            );
            return navigationMenuItem;
        }

        private void Build(Item node, List<NavigationMenuItem> items, NavigationMenuItem previousNode)
        {
            if (Navigation.IsNavigationItem(node))
            {
                var navitem = new NavigationMenuItem(node.DisplayName, node.GetUrl(), new List<NavigationMenuItem>());
                CheckboxField isExcludeFromNavigation = node.GetCheckBoxItem("ExcludeFromNavigation");
                if (!isExcludeFromNavigation.Checked)
                {
                    if (node.HasChildren)
                    {
                        previousNode = navitem;
                        items.Add((NavigationMenuItem)previousNode.Clone());
                    }
                    else
                    {
                        previousNode.Children.Add(navitem);
                    }
                }
            }
            node.GetChildren().ToList().ForEach(i =>
            {
                Build(i, previousNode.Children, previousNode);
            });
        }
    }
}