using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Abstractions;
using EventsApp.Business;
using TAC.Sitecore.Abstractions.Interfaces;
using TAC.Sitecore.Abstractions.SitecoreImplementation;
using Sitecore.DependencyInjection;
using System.Web.Mvc;
using Sitecore.Diagnostics;
using EventsApp.Controllers;

namespace EventsApp
{
    public class EventsServicesConfigurator: IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllersInCurrentAssembly();
            serviceCollection.AddSingleton<INavigationBuilder, NavigationBuilder>();// (typeof(INavigationBuilder), typeof(NavigationBuilder));
            serviceCollection.AddSingleton<IBreadcrumbBuilder, BreadcrumbBuilder>();// (typeof(IBreadcrumbBuilder), typeof(BreadcrumbBuilder));
            serviceCollection.AddSingleton<IRelatedEventsProvider, RelatedEventsProvider>();// (typeof(IRelatedEventsProvider), typeof(RelatedEventsProvider));
            serviceCollection.AddSingleton<IEventsProvider, EventsProvider>();// (typeof(IRelatedEventsProvider), typeof(EventsProvider));
            serviceCollection.AddSingleton<IRenderingContext, SitecoreRenderingContext>();// (typeof(IRenderingContext), typeof(SitecoreRenderingContext));
        }
    }
}