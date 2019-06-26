using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp.Utils
{
    public static class RenderingContextExtensions
    {
        public static Item GetDatasourceOrContextItem(this RenderingContext renderingContext)
        {
            return renderingContext.Rendering.Item;
        }
    }
}