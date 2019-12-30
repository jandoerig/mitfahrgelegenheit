using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using transportApp.Models;

namespace transportApp.Models
{
    public static class EventModel
    {
        public static List<Event> events;

        static EventModel()
        {
            events = new List<Event>();
            Event event1 = new Event("testevent", "testlocation", "2001, 1, 12");
            events.Add(event1);
        }

        public static void insertEvent(Event ev)
        {
            events.Add(ev);
        }

        public static void remove(Event ev)
        {
            events.Remove(ev);
        }
        public static void modify(Event ev, Event newEv)
        {
            events[events.IndexOf(ev)] = newEv;
        }


    }
}