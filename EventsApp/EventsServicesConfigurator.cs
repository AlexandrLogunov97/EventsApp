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

namespace EventsApp
{
    public class EventsServicesConfigurator: IServicesConfigurator
    {
       
        public EventsServicesConfigurator()
        {
            var a = 1;
        }
        public void Configure(IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<NavigationBuilder, NavigationBuilder>();
            serviceCollection.AddTransient<BreadcrumbBuilder, BreadcrumbBuilder>();
            serviceCollection.AddTransient<IRenderingContext,SitecoreRenderingContext>();
        }
    }
}