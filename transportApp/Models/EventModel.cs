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
        public static List<Event> events = new List<Event>();
        public static List<Car> cars = new List<Car>();

        public static Car car1 = new Car("Tobias Ueli", "St. Gallen BHF", 10, "11.12.2019 19:00");
        public static Car car2 = new Car("Sandro Schmid", "St. Gallen BHF", 5, "11.12.2019 18:30");
        public static Car car3 = new Car("Muhamed Ali", "Spreitenbach BHF", 10, "10.12.2019 19:00");

        public static Event event1 = new Event("testevent", "testlocation", "2001, 1, 12", cars);


        static EventModel()
        {
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

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