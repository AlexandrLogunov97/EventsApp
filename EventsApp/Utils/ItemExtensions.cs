using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Data.Managers;
using Sitecore.Data.Templates;
using Sitecore.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp.Utils
{
    public static class ItemExtensions
    {
        public static IEnumerable<Item> GetAncestors(this Item item)
        {
            return item.Axes.GetAncestors();
        }
        public static bool IsAncestorOrSelf(this Item item, Item child)
        {
            return item != null && (item.Axes.IsAncestorOf(child) || item.ID == child.ID);
        }
        public static TemplateList GetTemplates(this Item item)
        {
            return TemplateManager.GetTemplate(item).GetBaseTemplates();
        }
        public static bool ContainsTemplate(this Item item, ID id)
        {
            var templates = item.GetTemplates();
            return templates.Any(x => x.ID == id);
        }
        public static IEnumerable<Item> GetMultilistFieldItems(this Item item, string fieldNameOrID)
        {
            MultilistField field = item.Fields[fieldNameOrID];
            return field?.GetItems();
        }
        public static CheckboxField GetCheckBoxItem(this Item item, string fieldNameOrID)
        {
            CheckboxField field = item.Fields[fieldNameOrID];
            return field;
        }
        public static string GetUrl(this Item item)
        {
            return LinkManager.GetItemUrl(item);
        }
    }
}