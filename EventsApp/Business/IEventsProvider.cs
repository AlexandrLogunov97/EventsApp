using EventsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp.Business
{
    public interface IEventsProvider
    {
        EventsList GetEventsList(int pageNo);
    }
}
